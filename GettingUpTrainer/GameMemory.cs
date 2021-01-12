using Binarysharp.MemoryManagement;
using Binarysharp.MemoryManagement.Native;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GettingUpTrainer
{
	class GameMemory
	{
		private Process _process = null;
		private MemorySharp _memory = null;

		private Thread _processCheckThread = null;
		private Thread _memoryWatchThread = null;

		private IntPtr _moduleGCore = IntPtr.Zero;

		private Character _player = new Character();
		private int _enemySelectedIndex = -1;
		private List<Character> _enemyList = new List<Character>();

		public GameMemory()
		{
			_processCheckThread = new Thread(new ParameterizedThreadStart(ProcessCheckThread));
			_processCheckThread.Start();
		}

		~GameMemory()
		{
			if (_memoryWatchThread != null) {
				_memoryWatchThread.Abort();
			}

			if (_processCheckThread != null) {
				_processCheckThread.Abort();
			}

			if (_memory != null) {
				_memory.Dispose();
			}
		}

		private void ProcessCheckThread(object sender)
		{
			while (_process == null) {
				Process[] foundProcesses = Process.GetProcessesByName(Modules.MEGU);
				if (foundProcesses.Length > 0) {
					Process foundProcess = foundProcesses[0];
					ProcessModule module = foundProcess.Modules.Cast<ProcessModule>().FirstOrDefault(x => x.ModuleName == Modules.GCORE_DLL);

					if (module != null) {
						_process = foundProcess;
						_moduleGCore = module.BaseAddress;
						_memory = new MemorySharp(_process.Id);

						// Init memory watch thread
						_memoryWatchThread = new Thread(new ParameterizedThreadStart(MemoryWatchThread));
						_memoryWatchThread.Start();

						// Show overlay UI
						//_overlayForm.Invoke(new Action(() => _overlayForm.BindOverlayToGameProcess(_process)));

						// Update process status to subscribers
						UpdateProcessStatus(true);
					}
				}

				Thread.Sleep(100);
			}
		}

		private void MemoryWatchThread(object sender)
		{
			while (IsGameRunning()) {
				CheckModuleAddress();
				ReadGameMemory();
				SendEventGameMemory();
			}

			// Update process status to subscribers
			UpdateProcessStatus(false);

			// Clear memory object
			if(_memory != null) {
				_memory.Dispose();
			}

			_process = null;
			_moduleGCore = IntPtr.Zero;

			// Reset the process check thread
			_processCheckThread = null;
			_processCheckThread = new Thread(new ParameterizedThreadStart(ProcessCheckThread));
			_processCheckThread.Start();
		}

		private bool IsGameRunning()
		{
			Process[] foundProcesses = Process.GetProcessesByName(Modules.MEGU);
			bool isRunning = foundProcesses.Length > 0;
			if (isRunning) {
				_process = foundProcesses[0];
			}

			return isRunning;
		}

		private void CheckModuleAddress()
		{
			try {
				_memory[_moduleGCore, false].Read<IntPtr>();
			} catch { // Find new module's address
				try {
					ProcessModule module = _process.Modules.Cast<ProcessModule>().FirstOrDefault(x => x.ModuleName == Modules.GCORE_DLL);
					if (module != null) {
						_moduleGCore = module.BaseAddress;
					} else {
						_moduleGCore = IntPtr.Zero;
					}
				} catch {
					_moduleGCore = IntPtr.Zero;
				}
			}
		}

		private void ReadGameMemory()
		{
			if (_moduleGCore == IntPtr.Zero) {
				_player.Clear();
				_enemyList.Clear();
				return;
			}

			IntPtr instanceManager = ReadFromMemory<IntPtr>(_moduleGCore, (int)Offsets.Main.INSTANCE_MANAGER);
			if (instanceManager == IntPtr.Zero) {
				_player.Clear();
				_enemyList.Clear();
				return;
			}

			IntPtr characterManagerArray = ReadFromMemory<IntPtr>(instanceManager, (int)Offsets.InstanceManager.CHARACTER_MANAGER_ARRAY);
			if (characterManagerArray == IntPtr.Zero) {
				_player.Clear();
				_enemyList.Clear();
				return;
			}

			// Get every Characters's addresses
			int charactersSpawned = ReadFromMemory<int>(instanceManager, (int)Offsets.InstanceManager.CHARACTERS_SPAWNED);
			for (int i = 0; i < charactersSpawned; i++) {
				int characterOffset = i * 4;
				IntPtr characterManager = ReadFromMemory<IntPtr>(characterManagerArray, characterOffset);
				if (characterManager == IntPtr.Zero) {
					charactersSpawned = i;
					if (i == 0) {
						_player.Clear();
					}
					break;
				}

				Character character = new Character();
				character.BaseAddress = ReadFromMemory<IntPtr>(characterManager, (int)Offsets.CharacterManager.CHARACTER);
				if (character.BaseAddress == IntPtr.Zero) {
					break;
				}

				IntPtr offsetAddress;
				// Model Name
				offsetAddress = character.GetOffsetAddress((int)Offsets.Character.MODEL_NAME);
				character.ModelName = new Pointer<string>(offsetAddress, ReadStringFromMemory(offsetAddress));

				// Health
				offsetAddress = character.GetOffsetAddress((int)Offsets.Character.HEALTH_CURRENT);
				character.HealthCurrent = new Pointer<float?>(offsetAddress, ReadFromMemory<float>(offsetAddress));
				offsetAddress = character.GetOffsetAddress((int)Offsets.Character.HEALTH_MAX);
				character.HealthMax = new Pointer<float?>(offsetAddress, ReadFromMemory<float>(offsetAddress));

				// Power
				offsetAddress = character.GetOffsetAddress((int)Offsets.Character.POWER_CURRENT);
				character.PowerCurrent = new Pointer<float?>(offsetAddress, ReadFromMemory<float>(offsetAddress));
				offsetAddress = character.GetOffsetAddress((int)Offsets.Character.POWER_MAX);
				character.PowerMax = new Pointer<float?>(offsetAddress, ReadFromMemory<float>(offsetAddress));

				// Rep
				offsetAddress = character.GetOffsetAddress((int)Offsets.Character.REP_CURRENT);
				character.RepCurrent = new Pointer<int?>(offsetAddress, ReadFromMemory<int>(offsetAddress));
				offsetAddress = character.GetOffsetAddress((int)Offsets.Character.REP_MAX);
				character.RepMax = new Pointer<int?>(offsetAddress, ReadFromMemory<int>(offsetAddress));

				// Position
				offsetAddress = character.GetOffsetAddress((int)Offsets.Character.TRANSFORM_POSITION_X);
				character.PositionX = new Pointer<float?>(offsetAddress, ReadFromMemory<float>(offsetAddress));
				offsetAddress = character.GetOffsetAddress((int)Offsets.Character.TRANSFORM_POSITION_Y);
				character.PositionY = new Pointer<float?>(offsetAddress, ReadFromMemory<float>(offsetAddress));
				offsetAddress = character.GetOffsetAddress((int)Offsets.Character.TRANSFORM_POSITION_Z);
				character.PositionZ = new Pointer<float?>(offsetAddress, ReadFromMemory<float>(offsetAddress));

				if (i == 0) { // Add player
					_player = character;
				}
				else { // Add enemy to list
					if (_enemyList.Count <= i - 1) {
						_enemyList.Add(character);
					}
					else {
						_enemyList[i - 1] = character;
					}
				}
			}

			// Remove any extra enemy actors left
			int enemySpawnedCount = charactersSpawned > 0 ? charactersSpawned - 1 : 0;
			for (int i = enemySpawnedCount; i < _enemyList.Count; i++) {
				_enemyList.RemoveAt(i);
			}
		}

		private T ReadFromMemory<T>(IntPtr address)
		{
			T value = default;

			if (address != IntPtr.Zero) {
				try {
					value = _memory[address, false].Read<T>();
				}
				catch (Exception) {
					// nothing
				}
			}

			return value;
		}

		private T ReadFromMemory<T>(IntPtr address, int offset)
		{
			T value = default;

			if (address != IntPtr.Zero) {
				try {
					value = _memory[address, false].Read<T>(offset);
				}
				catch (Exception) {
					// nothing
				}
			}

			return value;
		}

		private string ReadStringFromMemory(IntPtr address)
		{
			string value = "";

			if (address != IntPtr.Zero) {
				try {
					value = _memory[address, false].ReadString(Encoding.Default);
				}
				catch (Exception) {
					// nothing
				}
			}

			return value;
		}

		private void WriteToMemory<T>(IntPtr address, T value)
		{
			if (address != IntPtr.Zero) {
				try {
					_memory[address, false].Write(value);
				}
				catch (Exception) {
					// nothing
				}
			}
		}

		public void SetPlayerHealth(float? healthCurrent, float? healthMax)
		{
			if (healthCurrent.HasValue) {
				WriteToMemory(_player.HealthCurrent.Address, (float)healthCurrent);
			}

			if (healthMax.HasValue) {
				WriteToMemory(_player.HealthMax.Address, (float)healthMax);
			}
		}

		public void SetPlayerPower(float? powerCurrent, float? powerMax)
		{
			if (powerCurrent.HasValue) {
				WriteToMemory(_player.PowerCurrent.Address, (float)powerCurrent);
			}

			if (powerMax.HasValue) {
				WriteToMemory(_player.PowerMax.Address, (float)powerMax);
			}
		}

		public void SetPlayerRep(int? repCurrent, int? repMax)
		{
			if (repCurrent.HasValue) {
				WriteToMemory(_player.RepCurrent.Address, (int)repCurrent);
			}

			if (repMax.HasValue) {
				WriteToMemory(_player.RepMax.Address, (int)repMax);
			}
		}

		public void SetPlayerPosition(float? positionX, float? positionY, float? positionZ)
		{
			if (positionX.HasValue) {
				WriteToMemory(_player.PositionX.Address, (float)positionX);
			}

			if (positionY.HasValue) {
				WriteToMemory(_player.PositionY.Address, (float)positionY);
			}

			if (positionZ.HasValue) {
				WriteToMemory(_player.PositionZ.Address, (float)positionZ);
			}
		}

		public void SetEnemyHealth(float? healthCurrent, float? healthMax)
		{
			if (_enemySelectedIndex >= 0) {
				if (_enemySelectedIndex >= _enemyList.Count) {
					_enemySelectedIndex = -1;
				} else {
					Character enemySelected = _enemyList[_enemySelectedIndex];

					if (healthCurrent.HasValue) {
						WriteToMemory(enemySelected.HealthCurrent.Address, (float)healthCurrent);
					}

					if (healthMax.HasValue) {
						WriteToMemory(enemySelected.HealthMax.Address, (float)healthMax);
					}
				}
			}
		}

		public void SetEnemyPosition(float? positionX, float? positionY, float? positionZ)
		{
			if (_enemySelectedIndex >= 0) {
				if (_enemySelectedIndex >= _enemyList.Count) {
					_enemySelectedIndex = -1;
				} else {
					Character enemySelected = _enemyList[_enemySelectedIndex];

					if (positionX.HasValue) {
						WriteToMemory(enemySelected.PositionX.Address, (float)positionX);
					}

					if (positionY.HasValue) {
						WriteToMemory(enemySelected.PositionY.Address, (float)positionY);
					}

					if (positionZ.HasValue) {
						WriteToMemory(enemySelected.PositionZ.Address, (float)positionZ);
					}
				}
			}
		}

		public int EnemySelectedIndex
		{
			get { return _enemySelectedIndex; }
			set { _enemySelectedIndex = value; }
		}

		public EventHandler<ProcessStatusArgs> ProcessStatusEventHandler;
		private void UpdateProcessStatus(bool loaded)
		{
			ProcessStatusArgs processStatusArgs = new ProcessStatusArgs();
			processStatusArgs.Loaded = loaded;
			ProcessStatusEventHandler.Invoke(this, processStatusArgs);
		}

		public EventHandler<GameMemoryArgs> MemoryWatchEventHandler;
		private void SendEventGameMemory()
		{
			GameMemoryArgs gameMemoryArgs = new GameMemoryArgs();

			gameMemoryArgs.PlayerLoaded = _player.BaseAddress != IntPtr.Zero;
			gameMemoryArgs.EnemyListLoaded = _enemyList.Count > 0;


			// Player
			gameMemoryArgs.PlayerModelName = _player.ModelName.Value;
			gameMemoryArgs.PlayerHealthCurrent = _player.HealthCurrent.Value.ToString();
			gameMemoryArgs.PlayerHealthMax = _player.HealthMax.Value.ToString();
			gameMemoryArgs.PlayerPowerCurrent = _player.PowerCurrent.Value.ToString();
			gameMemoryArgs.PlayerPowerMax = _player.PowerMax.Value.ToString();
			gameMemoryArgs.PlayerRepCurrent = _player.RepCurrent.Value.ToString();
			gameMemoryArgs.PlayerRepMax = _player.RepMax.Value.ToString();
			gameMemoryArgs.PlayerPositionX = _player.PositionX.Value.ToString();
			gameMemoryArgs.PlayerPositionY = _player.PositionY.Value.ToString();
			gameMemoryArgs.PlayerPositionZ = _player.PositionZ.Value.ToString();

			// Enemy List
			gameMemoryArgs.EnemyList = _enemyList.Select((i, index) => $"{(index + 1).ToString()}: {i.ModelName.Value}").ToArray();
			gameMemoryArgs.EnemyCount = _enemyList.Count.ToString();

			// Enemy Selected
			if (_enemySelectedIndex > -1) {
				if (_enemySelectedIndex >= _enemyList.Count) {
					_enemySelectedIndex = -1;  // Out of bounds: clear index
				} else {
					Character enemySelected = _enemyList[_enemySelectedIndex];
					gameMemoryArgs.EnemySelectedHealthCurrent = enemySelected.HealthCurrent.Value.ToString();
					gameMemoryArgs.EnemySelectedHealthMax = enemySelected.HealthMax.Value.ToString();
					gameMemoryArgs.EnemySelectedPositionX = enemySelected.PositionX.Value.ToString();
					gameMemoryArgs.EnemySelectedPositionY = enemySelected.PositionY.Value.ToString();
					gameMemoryArgs.EnemySelectedPositionZ = enemySelected.PositionZ.Value.ToString();
				}
			}

			MemoryWatchEventHandler.Invoke(this, gameMemoryArgs);
		}
	}

	public struct Character {
		public IntPtr BaseAddress;

		public Pointer<string> ModelName;
		public Pointer<float?> HealthCurrent;
		public Pointer<float?> HealthMax;
		public Pointer<float?> PowerCurrent;
		public Pointer<float?> PowerMax;
		public Pointer<int?> RepCurrent;
		public Pointer<int?> RepMax;
		public Pointer<float?> PositionX;
		public Pointer<float?> PositionY;
		public Pointer<float?> PositionZ;

		public IntPtr GetOffsetAddress(int offset)
		{
			return BaseAddress + offset;
		}

		public void Clear()
		{
			BaseAddress = IntPtr.Zero;
			ModelName.Clear();
			HealthCurrent.Clear();
			HealthMax.Clear();
			PowerCurrent.Clear();
			PowerMax.Clear();
			RepCurrent.Clear();
			RepMax.Clear();
			PositionX.Clear();
			PositionY.Clear();
			PositionZ.Clear();
		}
	}

	public struct Pointer<T>
	{
		public IntPtr Address;
		public T Value;

		public Pointer(IntPtr addr, T val)
		{
			Address = addr;
			Value = val;
		}

		public void Clear()
		{
			Address = IntPtr.Zero;
			Value = default;
		}
	}

	public class ProcessStatusArgs : EventArgs
	{
		public bool Loaded { get; set; }
	}

	public class GameMemoryArgs : EventArgs
	{
		public bool PlayerLoaded { get; set; }
		public bool EnemyListLoaded { get; set; }

		// Player
		public string PlayerModelName { get; set; }
		public string PlayerHealthCurrent { get; set; }
		public string PlayerHealthMax { get; set; }
		public string PlayerPowerCurrent { get; set; }
		public string PlayerPowerMax { get; set; }
		public string PlayerRepCurrent { get; set; }
		public string PlayerRepMax { get; set; }
		public string PlayerPositionX { get; set; }
		public string PlayerPositionY { get; set; }
		public string PlayerPositionZ { get; set; }

		// Enemy List
		public string[] EnemyList { get; set; }
		public string EnemyCount { get; set; }

		// Enemy Selected
		public string EnemySelectedHealthCurrent { get; set; }
		public string EnemySelectedHealthMax { get; set; }
		public string EnemySelectedPositionX { get; set; }
		public string EnemySelectedPositionY { get; set; }
		public string EnemySelectedPositionZ { get; set; }
	}
}
