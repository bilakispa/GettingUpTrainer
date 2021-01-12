using Binarysharp.MemoryManagement;
using GettingUpTrainer.Forms;
using GettingUpTrainer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace GettingUpTrainer
{
	public partial class UserInterfaceForm : Form
	{
        private KeyManager _keyManager;
        private GameMemory _gameMemory;
        private OverlayForm _overlayForm = new OverlayForm();

        public UserInterfaceForm()
		{
			InitializeComponent();
        }

		private void UserInterface_Load(object sender, EventArgs e)
		{
            // Show overlay UI (Nothing to show on load) [Proof of concept]
            // _overlayForm.Show();

            _gameMemory = new GameMemory();
            _gameMemory.ProcessStatusEventHandler += UpdateProcessStatus;
            _gameMemory.MemoryWatchEventHandler += UpdateFormControls;

            // Init Key Listener
            _keyManager = new KeyManager();
            _keyManager.AddKey(Keys.F12);
            _keyManager.KeyDownEvent += new KeyManager.KeyHandler(HandleKeyDownEvent);
        }

        private void UserInterface_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void UpdateProcessStatus(object sender, ProcessStatusArgs args)
        {
            if (this.IsHandleCreated) {
                this.BeginInvoke((MethodInvoker)delegate
                {
                    if (args.Loaded) {
                        lblAppStatusValue.Text = Resources.Loaded;
                    }
                    else {
                        lblAppStatusValue.Text = Resources.WaitingForGettingUpExe;
                    }
                });
            }
        }

        private void UpdateFormControls(object sender, GameMemoryArgs args)
        {
            if(this.IsHandleCreated) {
                this.BeginInvoke((MethodInvoker)delegate
                {
                    gbPlayer.Enabled = args.PlayerLoaded;
                    gbEnemy.Enabled = args.EnemyListLoaded;

                    // Player
                    lblPlayerValueModelName.Text = args.PlayerModelName;
                    lblPlayerValueHealthCurrent.Text = args.PlayerHealthCurrent;
                    lblPlayerValueHealthMax.Text = args.PlayerHealthMax;
                    lblPlayerValuePowerCurrent.Text = args.PlayerPowerCurrent;
                    lblPlayerValuePowerMax.Text = args.PlayerPowerMax;
                    lblPlayerValueRepCurrent.Text = args.PlayerRepCurrent;
                    lblPlayerValueRepMax.Text = args.PlayerRepMax;
                    lblPlayerValuePositionX.Text = args.PlayerPositionX;
                    lblPlayerValuePositionY.Text = args.PlayerPositionY;
                    lblPlayerValuePositionZ.Text = args.PlayerPositionZ;

                    // Enemy List
                    if (cbEnemySelected.Items.Count != args.EnemyList.Length) {
                        pnlEnemySelected.Enabled = false;
                        cbEnemySelected.Items.Clear();
                        cbEnemySelected.Items.AddRange(args.EnemyList);
                        _gameMemory.EnemySelectedIndex = -1;
                    }
                    lblEnemyCountValue.Text = args.EnemyCount;

                    // Enemy Selected
                    lblEnemyValueHealthCurrent.Text = args.EnemySelectedHealthCurrent;
                    lblEnemyValueHealthMax.Text = args.EnemySelectedHealthMax;
                    lblEnemyValuePositionX.Text = args.EnemySelectedPositionX;
                    lblEnemyValuePositionY.Text = args.EnemySelectedPositionY;
                    lblEnemyValuePositionZ.Text = args.EnemySelectedPositionZ;
                });
            }
        }

        private void HandleKeyDownEvent(int keyId, string keyName)
        {
            switch ((Keys)keyId) {
                case Keys.F9:
                    btnPlayerHealth_Click(this, EventArgs.Empty);
                    break;
                case Keys.F10:
                    btnPlayerPower_Click(this, EventArgs.Empty);
                    break;
                case Keys.F11:
                    btnPlayerRep_Click(this, EventArgs.Empty);
                    break;
                case Keys.F12:
                    btnPlayerPosition_Click(this, EventArgs.Empty);
                    break;
            }
        }

        private void btnPlayerHealth_Click(object sender, EventArgs e)
        {
            float? healthCurrent = null, healthMax = null;
            float tmpOut;

            if (float.TryParse(txtPlayerHealthCurrent.Text, out tmpOut)) {
                healthCurrent = tmpOut;
            }

            if (float.TryParse(txtPlayerHealthMax.Text, out tmpOut)) {
                healthMax = tmpOut;
            }

            _gameMemory.SetPlayerHealth(healthCurrent, healthMax);
        }

        private void btnPlayerPower_Click(object sender, EventArgs e)
        {
            float? powerCurrent = null, powerMax = null;
            float tmpOut;

            if (float.TryParse(txtPlayerPowerCurrent.Text, out tmpOut)) {
                powerCurrent = tmpOut;
            }

            if (float.TryParse(txtPlayerPowerMax.Text, out tmpOut)) {
                powerMax = tmpOut;
            }

            _gameMemory.SetPlayerPower(powerCurrent, powerMax);
        }

        private void btnPlayerRep_Click(object sender, EventArgs e)
        {
            int? repCurrent = null, repMax = null;
            int tmpOut;

            if (int.TryParse(txtPlayerRepCurrent.Text, out tmpOut)) {
                repCurrent = tmpOut;
            }

            if (int.TryParse(txtPlayerRepMax.Text, out tmpOut)) {
                repMax = tmpOut;
            }

            _gameMemory.SetPlayerRep(repCurrent, repMax);
        }

        private void btnPlayerPosition_Click(object sender, EventArgs e)
        {
            float? positionX = null, positionY = null, positionZ = null;
            float tmpOut;

            if (float.TryParse(txtPlayerPositionX.Text, out tmpOut)) {
                positionX = tmpOut;
            }

            if (float.TryParse(txtPlayerPositionY.Text, out tmpOut)) {
                positionY = tmpOut;
            }

            if (float.TryParse(txtPlayerPositionZ.Text, out tmpOut)) {
                positionZ = tmpOut;
            }

            _gameMemory.SetPlayerPosition(positionX, positionY, positionZ);
        }

        private void cbEnemySelected_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlEnemySelected.Enabled = true;
            _gameMemory.EnemySelectedIndex = cbEnemySelected.SelectedIndex;
        }

        private void btnEnemyHealth_Click(object sender, EventArgs e)
        {
            float? healthCurrent = null, healthMax = null;
            float tmpOut;

            if (float.TryParse(txtEnemyHealthCurrent.Text, out tmpOut)) {
                healthCurrent = tmpOut;
            }

            if (float.TryParse(txtEnemyHealthMax.Text, out tmpOut)) {
                healthMax = tmpOut;
            }
            
            _gameMemory.SetEnemyHealth(healthCurrent, healthMax);
        }

        private void btnEnemyPosition_Click(object sender, EventArgs e)
        {
            float? positionX = null, positionY = null, positionZ = null;
            float tmpOut;

            if (float.TryParse(txtEnemyPositionX.Text, out tmpOut)) {
                positionX = tmpOut;
            }

            if (float.TryParse(txtEnemyPositionY.Text, out tmpOut)) {
                positionY = tmpOut;
            }

            if (float.TryParse(txtEnemyPositionZ.Text, out tmpOut)) {
                positionZ = tmpOut;
            }

            _gameMemory.SetEnemyPosition(positionX, positionY, positionZ);
        }
    }
}
