using System;
using System.Windows.Forms;

namespace GettingUpTrainer.Forms
{
	public partial class SettingsForm : Form
	{
		private string hotkeyControlActive = string.Empty;
		private KeyManager _keyManager;

		public SettingsForm(KeyManager keyManager)
		{
			InitializeComponent();
			_keyManager = keyManager;
			
			Key key;
			key = _keyManager.GetKey(KeyControls.PLAYER_HEALTH);
			lblHotkeysPlayerHealthValue.Text = (key == null) ? Properties.Resources.None : key.Name;
			lblHotkeysPlayerHealthValue.Tag = KeyControls.PLAYER_HEALTH;

			key = _keyManager.GetKey(KeyControls.PLAYER_POWER);
			lblHotkeysPlayerPowerValue.Text = (key == null) ? Properties.Resources.None : key.Name;
			lblHotkeysPlayerPowerValue.Tag = KeyControls.PLAYER_POWER;

			key = _keyManager.GetKey(KeyControls.PLAYER_REP);
			lblHotkeysPlayerRepValue.Text = (key == null) ? Properties.Resources.None : key.Name;
			lblHotkeysPlayerRepValue.Tag = KeyControls.PLAYER_REP;

			key = _keyManager.GetKey(KeyControls.PLAYER_POSITION);
			lblHotkeysPlayerPositionValue.Text = (key == null) ? Properties.Resources.None : key.Name;
			lblHotkeysPlayerPositionValue.Tag = KeyControls.PLAYER_POSITION;

			key = _keyManager.GetKey(KeyControls.ENEMY_HEALTH);
			lblHotkeysEnemyHealthValue.Text = (key == null) ? Properties.Resources.None : key.Name;
			lblHotkeysEnemyHealthValue.Tag = KeyControls.ENEMY_HEALTH;

			key = _keyManager.GetKey(KeyControls.ENEMY_POSITION);
			lblHotkeysEnemyPositionValue.Text = (key == null) ? Properties.Resources.None : key.Name;
			lblHotkeysEnemyPositionValue.Tag = KeyControls.ENEMY_POSITION;

			key = _keyManager.GetKey(KeyControls.PEDESTRIAN_POSITION);
			lblHotkeysPedestrianPositionValue.Text = (key == null) ? Properties.Resources.None : key.Name;
			lblHotkeysPedestrianPositionValue.Tag = KeyControls.PEDESTRIAN_POSITION;
		}

		private void SettingsForm_Load(object sender, EventArgs e)
		{
			// Select the first item
			if (listBoxSettings.Items.Count > 0) {
				listBoxSettings.SelectedIndex = 0;
			}
		}

		private void listBoxSettings_SelectedValueChanged(object sender, EventArgs e)
		{
			// Hide all other option panels here

			// TODO: Add enum
			switch(listBoxSettings.SelectedIndex) {
				case 0: // Show hotkey panel
					tblPanelHotkeys.Visible = true;
					break;
				default:
					break;
			}
		}

		private void SettingsForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (!string.IsNullOrEmpty(hotkeyControlActive)) {
				Label lbl = (Label)tblPanelHotkeys.Controls[hotkeyControlActive];

				// Remove the previous bind from the manager
				_keyManager.RemoveKey((string)lbl.Tag);

				// Add the new one
				_keyManager.AddKey((string)lbl.Tag, e.KeyValue, e.KeyCode.ToString());

				// Assign the hotkey to the selected pair
				lbl.Text = e.KeyCode.ToString();

				hotkeyControlActive = string.Empty;
			}
		}

		// Constants for decoding the Win32 message.
		protected const int WM_MOUSEACTIVATE = 0x0021;

		protected override void WndProc(ref Message m)
		{
			// Check the Message parameter to see if the message is WM_MOUSEACTIVATE indicating that a control was clicked.
			if (m.Msg == WM_MOUSEACTIVATE) {
				// TODO: Check if tab selected is hotkeys tab

				if (!string.IsNullOrEmpty(hotkeyControlActive)) {
					// Cancel any previous hotkey control waiting to assign
					Label lbl = (Label)tblPanelHotkeys.Controls[hotkeyControlActive];
					lbl.Text = Properties.Resources.None;

					hotkeyControlActive = string.Empty;
				}
			}

			base.WndProc(ref m);
		}

		private void btnHotkeysPlayerHealthEdit_Click(object sender, EventArgs e)
		{
			hotkeyControlActive = lblHotkeysPlayerHealthValue.Name;
			lblHotkeysPlayerHealthValue.Text = Properties.Resources.ClickToCancel;
		}

		private void btnHotkeysPlayerHealthClear_Click(object sender, EventArgs e)
		{
			_keyManager.RemoveKey((string)lblHotkeysPlayerHealthValue.Tag);
			lblHotkeysPlayerHealthValue.Text = Properties.Resources.None;
		}

		private void btnHotkeysPlayerPowerEdit_Click(object sender, EventArgs e)
		{
			hotkeyControlActive = lblHotkeysPlayerPowerValue.Name;
			lblHotkeysPlayerPowerValue.Text = Properties.Resources.ClickToCancel;
		}

		private void btnHotkeysPlayerPowerClear_Click(object sender, EventArgs e)
		{
			_keyManager.RemoveKey((string)lblHotkeysPlayerPowerValue.Tag);
			lblHotkeysPlayerPowerValue.Text = Properties.Resources.None;
		}

		private void btnHotkeysPlayerRepEdit_Click(object sender, EventArgs e)
		{
			hotkeyControlActive = lblHotkeysPlayerRepValue.Name;
			lblHotkeysPlayerRepValue.Text = Properties.Resources.ClickToCancel;
		}

		private void btnHotkeysPlayerRepClear_Click(object sender, EventArgs e)
		{
			_keyManager.RemoveKey((string)lblHotkeysPlayerRepValue.Tag);
			lblHotkeysPlayerRepValue.Text = Properties.Resources.None;
		}

		private void btnHotkeysPlayerPositionEdit_Click(object sender, EventArgs e)
		{
			hotkeyControlActive = lblHotkeysPlayerPositionValue.Name;
			lblHotkeysPlayerPositionValue.Text = Properties.Resources.ClickToCancel;
		}

		private void btnHotkeysPlayerPositionClear_Click(object sender, EventArgs e)
		{
			_keyManager.RemoveKey((string)lblHotkeysPlayerPositionValue.Tag);
			lblHotkeysPlayerPositionValue.Text = Properties.Resources.None;
		}

		private void btnHotkeysEnemyHealthEdit_Click(object sender, EventArgs e)
		{
			hotkeyControlActive = lblHotkeysEnemyHealthValue.Name;
			lblHotkeysEnemyHealthValue.Text = Properties.Resources.ClickToCancel;
		}

		private void btnHotkeysEnemyHealthClear_Click(object sender, EventArgs e)
		{
			_keyManager.RemoveKey((string)lblHotkeysEnemyHealthValue.Tag);
			lblHotkeysEnemyHealthValue.Text = Properties.Resources.None;
		}

		private void btnHotkeysEnemyPositionEdit_Click(object sender, EventArgs e)
		{
			hotkeyControlActive = lblHotkeysEnemyPositionValue.Name;
			lblHotkeysEnemyPositionValue.Text = Properties.Resources.ClickToCancel;
		}

		private void btnHotkeysEnemyPositionClear_Click(object sender, EventArgs e)
		{
			_keyManager.RemoveKey((string)lblHotkeysEnemyPositionValue.Tag);
			lblHotkeysEnemyPositionValue.Text = Properties.Resources.None;
		}

		private void btnHotkeysPedestrianPositionEdit_Click(object sender, EventArgs e)
		{
			hotkeyControlActive = lblHotkeysPedestrianPositionValue.Name;
			lblHotkeysPedestrianPositionValue.Text = Properties.Resources.ClickToCancel;
		}

		private void btnHotkeysPedestrianPositionClear_Click(object sender, EventArgs e)
		{
			_keyManager.RemoveKey((string)lblHotkeysPedestrianPositionValue.Tag);
			lblHotkeysPedestrianPositionValue.Text = Properties.Resources.None;
		}

		private void SettingsForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			// Save settings
			Properties.Settings.Default.HotkeyPlayerHealth = _keyManager.GetKey(KeyControls.PLAYER_HEALTH);
			Properties.Settings.Default.HotkeyPlayerPower = _keyManager.GetKey(KeyControls.PLAYER_POWER);
			Properties.Settings.Default.HotkeyPlayerRep = _keyManager.GetKey(KeyControls.PLAYER_REP);
			Properties.Settings.Default.HotkeyPlayerPosition = _keyManager.GetKey(KeyControls.PLAYER_POSITION);
			Properties.Settings.Default.HotkeyEnemyHealth = _keyManager.GetKey(KeyControls.ENEMY_HEALTH);
			Properties.Settings.Default.HotkeyEnemyPosition = _keyManager.GetKey(KeyControls.ENEMY_POSITION);
			Properties.Settings.Default.HotkeyPedestrianPosition = _keyManager.GetKey(KeyControls.PEDESTRIAN_POSITION);

			Properties.Settings.Default.Save();
		}
	}
}
