using GettingUpTrainer.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GettingUpTrainer
{
    public partial class UserInterfaceForm : Form
	{
        private KeyManager _keyManager;
        private GameMemory _gameMemory;
        private OverlayForm _overlayForm = new OverlayForm();
        private bool modalOpen = false;

        public UserInterfaceForm()
		{
			InitializeComponent();

            // Fix the right padding on the status strip still taking account for the grip, even though it's disabled
            statusStrip.Padding = new Padding(statusStrip.Padding.Left, statusStrip.Padding.Top, statusStrip.Padding.Left, statusStrip.Padding.Bottom);
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
            _keyManager.KeyDownEvent += new KeyManager.KeyHandler(HandleKeyDownEvent);

            // Load settings
            _keyManager.AddKey(KeyControls.PLAYER_HEALTH, Properties.Settings.Default.HotkeyPlayerHealth);
            _keyManager.AddKey(KeyControls.PLAYER_POWER, Properties.Settings.Default.HotkeyPlayerPower);
            _keyManager.AddKey(KeyControls.PLAYER_REP, Properties.Settings.Default.HotkeyPlayerRep);
            _keyManager.AddKey(KeyControls.PLAYER_POSITION, Properties.Settings.Default.HotkeyPlayerPosition);
            _keyManager.AddKey(KeyControls.ENEMY_HEALTH, Properties.Settings.Default.HotkeyEnemyHealth);
            _keyManager.AddKey(KeyControls.ENEMY_POSITION, Properties.Settings.Default.HotkeyEnemyPosition);
            _keyManager.AddKey(KeyControls.PEDESTRIAN_POSITION, Properties.Settings.Default.HotkeyPedestrianPosition);

            // Load saved positions
            lbPlayerPositions.DisplayMember = "Name";
            PlayerPositionCollection playerPositions = Properties.Settings.Default.PlayerPositions;
            if (playerPositions != null) {
                lbPlayerPositions.DataSource = playerPositions.PlayerPositions;
            }
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
                        lblAppStatusValue.Text = Properties.Resources.Loaded;
                    }
                    else {
                        lblAppStatusValue.Text = Properties.Resources.WaitingForGettingUpExe;
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
                    gbPlayerPositions.Enabled = args.PlayerLoaded;
                    btnPlayerPositions.Enabled = args.PlayerLoaded;
                    gbEnemy.Enabled = args.EnemyListLoaded;
                    gbPedestrian.Enabled = args.PedestrianListLoaded;
                    gbGeneral.Enabled = args.GeneralLoaded;

                    // Player
                    lblPlayerModelNameValue.Text = args.PlayerModelName;
                    lblPlayerHealthCurrentValue.Text = args.PlayerHealthCurrent;
                    lblPlayerHealthMaxValue.Text = args.PlayerHealthMax;
                    lblPlayerPowerCurrentValue.Text = args.PlayerPowerCurrent;
                    lblPlayerPowerMaxValue.Text = args.PlayerPowerMax;
                    lblPlayerRepCurrentValue.Text = args.PlayerRepCurrent;
                    lblPlayerRepMaxValue.Text = args.PlayerRepMax;
                    lblPlayerPositionXValue.Text = args.PlayerPositionX;
                    lblPlayerPositionYValue.Text = args.PlayerPositionY;
                    lblPlayerPositionZValue.Text = args.PlayerPositionZ;
                    lblPlayerRotationYawValue.Text = args.PlayerRotationYaw;

                    // Enemy List
                    if (cbEnemySelected.Items.Count != args.EnemyList.Length) {
                        tblEnemySelected.Enabled = false;
                        cbEnemySelected.Items.Clear();
                        cbEnemySelected.Items.AddRange(args.EnemyList);
                        _gameMemory.EnemySelectedIndex = -1;
                    }
                    lblEnemyCountValue.Text = args.EnemyCount;

                    // Enemy Selected
                    lblEnemyHealthCurrentValue.Text = args.EnemySelectedHealthCurrent;
                    lblEnemyHealthMaxValue.Text = args.EnemySelectedHealthMax;
                    lblEnemyPositionXValue.Text = args.EnemySelectedPositionX;
                    lblEnemyPositionYValue.Text = args.EnemySelectedPositionY;
                    lblEnemyPositionZValue.Text = args.EnemySelectedPositionZ;
                    lblEnemyRotationYawValue.Text = args.EnemySelectedRotationYaw;

                    // Pedestrian List
                    if (cbPedestrianSelected.Items.Count != args.PedestrianList.Length) {
                        tblPedestrianSelected.Enabled = false;
                        cbPedestrianSelected.Items.Clear();
                        cbPedestrianSelected.Items.AddRange(args.PedestrianList);
                        _gameMemory.PedestrianSelectedIndex = -1;
                    }
                    lblPedestrianCountValue.Text = args.PedestrianCount;
                    
                    // Pedestrian Selected
                    lblPedestrianPositionXValue.Text = args.PedestrianSelectedPositionX;
                    lblPedestrianPositionYValue.Text = args.PedestrianSelectedPositionY;
                    lblPedestrianPositionZValue.Text = args.PedestrianSelectedPositionZ;

                    // General
                    lblGeneralMapValue.Text = args.GeneralMap;
                    lblGeneralCanPressureValue.Text = args.GeneralCanPressure;
                });
            }
        }

        private void HandleKeyDownEvent(string controlName, int keyId, string keyName)
        {
            if (!modalOpen) {
                switch (controlName) {
                    case KeyControls.PLAYER_HEALTH:
                        btnPlayerHealth_Click(this, EventArgs.Empty);
                        break;
                    case KeyControls.PLAYER_POWER:
                        btnPlayerPower_Click(this, EventArgs.Empty);
                        break;
                    case KeyControls.PLAYER_REP:
                        btnPlayerRep_Click(this, EventArgs.Empty);
                        break;
                    case KeyControls.PLAYER_POSITION:
                        btnPlayerPosition_Click(this, EventArgs.Empty);
                        break;
                    case KeyControls.ENEMY_HEALTH:
                        btnEnemyHealth_Click(this, EventArgs.Empty);
                        break;
                    case KeyControls.ENEMY_POSITION:
                        btnEnemyPosition_Click(this, EventArgs.Empty);
                        break;
                    case KeyControls.PEDESTRIAN_POSITION:
                        btnPedestrianPosition_Click(this, EventArgs.Empty);
                        break;
                }
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
            tblEnemySelected.Enabled = true;
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

        private void cbPedestrianSelected_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            tblPedestrianSelected.Enabled = true;
            _gameMemory.PedestrianSelectedIndex = cbPedestrianSelected.SelectedIndex;
        }

        private void btnPedestrianPosition_Click(object sender, EventArgs e)
        {
            float? positionX = null, positionY = null, positionZ = null;
            float tmpOut;

            if (float.TryParse(txtPedestrianPositionX.Text, out tmpOut)) {
                positionX = tmpOut;
            }

            if (float.TryParse(txtPedestrianPositionY.Text, out tmpOut)) {
                positionY = tmpOut;
            }

            if (float.TryParse(txtPedestrianPositionZ.Text, out tmpOut)) {
                positionZ = tmpOut;
            }

            _gameMemory.SetPedestrianPosition(positionX, positionY, positionZ);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            using (SettingsForm settingsForm = new SettingsForm(_keyManager)) {
                modalOpen = true;
                settingsForm.ShowDialog(this);
            }

            modalOpen = false;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            using (AboutForm aboutForm = new AboutForm()) {
                modalOpen = true;
                aboutForm.ShowDialog(this);
            }

            modalOpen = false;
        }

        private void lbCustomPositions_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lbPlayerPositions.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches) {
                PlayerPosition playerPos = lbPlayerPositions.SelectedItem as PlayerPosition;

                txtPlayerPositionX.Text = playerPos.PositionX;
                txtPlayerPositionY.Text = playerPos.PositionY;
                txtPlayerPositionZ.Text = playerPos.PositionZ;
            }
        }

        private void btnPlayerPositions_Click(object sender, EventArgs e)
        {
            using (ManagePlayerPositionsForm managePlayerPositionsForm = new ManagePlayerPositionsForm()) {
                modalOpen = true;
                managePlayerPositionsForm.ShowDialog(this);
            }

            modalOpen = false;

            PlayerPositionCollection playerPositions = Properties.Settings.Default.PlayerPositions;
            lbPlayerPositions.DataSource = playerPositions.PlayerPositions;
        }
    }
}
