using GettingUpTrainer.Properties;
using SharpDX.Direct2D1;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GettingUpTrainer
{
	partial class UserInterfaceForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInterfaceForm));
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.lblAppStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.lblAppStatusValue = new System.Windows.Forms.ToolStripStatusLabel();
			this.gbEnemy = new System.Windows.Forms.GroupBox();
			this.pnlEnemySelected = new System.Windows.Forms.Panel();
			this.btnEnemyPosition = new System.Windows.Forms.Button();
			this.lblEnemyHealthDesc = new System.Windows.Forms.Label();
			this.txtEnemyPositionZ = new System.Windows.Forms.TextBox();
			this.lblEnemyNameHealthCurrent = new System.Windows.Forms.Label();
			this.txtEnemyPositionY = new System.Windows.Forms.TextBox();
			this.lblEnemyValueHealthCurrent = new System.Windows.Forms.Label();
			this.txtEnemyPositionX = new System.Windows.Forms.TextBox();
			this.lblEnemyValueHealthMax = new System.Windows.Forms.Label();
			this.lblEnemyNamePositionZ = new System.Windows.Forms.Label();
			this.lblEnemyNameHealthMax = new System.Windows.Forms.Label();
			this.lblEnemyNamePositionY = new System.Windows.Forms.Label();
			this.txtEnemyHealthCurrent = new System.Windows.Forms.TextBox();
			this.lblEnemyValuePositionZ = new System.Windows.Forms.Label();
			this.txtEnemyHealthMax = new System.Windows.Forms.TextBox();
			this.lblEnemyValuePositionY = new System.Windows.Forms.Label();
			this.btnEnemyHealth = new System.Windows.Forms.Button();
			this.lblEnemyValuePositionX = new System.Windows.Forms.Label();
			this.lblEnemyPositionDesc = new System.Windows.Forms.Label();
			this.lblEnemyNamePositionX = new System.Windows.Forms.Label();
			this.lblEnemySeparator = new System.Windows.Forms.Label();
			this.lblEnemySelected = new System.Windows.Forms.Label();
			this.cbEnemySelected = new System.Windows.Forms.ComboBox();
			this.lblEnemyCountValue = new System.Windows.Forms.Label();
			this.lblEnemyCountName = new System.Windows.Forms.Label();
			this.gbPlayer = new System.Windows.Forms.GroupBox();
			this.lblPlayerValueModelName = new System.Windows.Forms.Label();
			this.lblPlayerNameModelName = new System.Windows.Forms.Label();
			this.btnPlayerPosition = new System.Windows.Forms.Button();
			this.btnPlayerRep = new System.Windows.Forms.Button();
			this.btnPlayerPower = new System.Windows.Forms.Button();
			this.btnPlayerHealth = new System.Windows.Forms.Button();
			this.txtPlayerPositionZ = new System.Windows.Forms.TextBox();
			this.txtPlayerPositionY = new System.Windows.Forms.TextBox();
			this.txtPlayerPositionX = new System.Windows.Forms.TextBox();
			this.txtPlayerRepMax = new System.Windows.Forms.TextBox();
			this.txtPlayerPowerMax = new System.Windows.Forms.TextBox();
			this.txtPlayerRepCurrent = new System.Windows.Forms.TextBox();
			this.lblPlayerNamePositionZ = new System.Windows.Forms.Label();
			this.lblPlayerNamePositionY = new System.Windows.Forms.Label();
			this.txtPlayerHealthMax = new System.Windows.Forms.TextBox();
			this.txtPlayerPowerCurrent = new System.Windows.Forms.TextBox();
			this.lblPlayerNameRepMax = new System.Windows.Forms.Label();
			this.lblPlayerValuePositionZ = new System.Windows.Forms.Label();
			this.lblPlayerValuePositionY = new System.Windows.Forms.Label();
			this.txtPlayerHealthCurrent = new System.Windows.Forms.TextBox();
			this.lblPlayerNamePowerMax = new System.Windows.Forms.Label();
			this.lblPlayerValuePositionX = new System.Windows.Forms.Label();
			this.lblPlayerValueRepMax = new System.Windows.Forms.Label();
			this.lblPlayerNameHealthMax = new System.Windows.Forms.Label();
			this.lblPlayerValueRepCurrent = new System.Windows.Forms.Label();
			this.lblPlayerNamePositionX = new System.Windows.Forms.Label();
			this.lblPlayerValuePowerMax = new System.Windows.Forms.Label();
			this.lblPlayerValuePowerCurrent = new System.Windows.Forms.Label();
			this.lblPlayerNameRepCurrent = new System.Windows.Forms.Label();
			this.lblPlayerDescPosition = new System.Windows.Forms.Label();
			this.lblPlayerValueHealthMax = new System.Windows.Forms.Label();
			this.lblPlayerNamePowerCurrent = new System.Windows.Forms.Label();
			this.lblPlayerDescRep = new System.Windows.Forms.Label();
			this.lblPlayerValueHealthCurrent = new System.Windows.Forms.Label();
			this.lblPlayerDescPower = new System.Windows.Forms.Label();
			this.lblPlayerNameHealthCurrent = new System.Windows.Forms.Label();
			this.lblPlayerDescHealth = new System.Windows.Forms.Label();
			this.statusStrip.SuspendLayout();
			this.gbEnemy.SuspendLayout();
			this.pnlEnemySelected.SuspendLayout();
			this.gbPlayer.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip
			// 
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblAppStatusLabel,
            this.lblAppStatusValue});
			this.statusStrip.Location = new System.Drawing.Point(0, 490);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(389, 22);
			this.statusStrip.SizingGrip = false;
			this.statusStrip.TabIndex = 0;
			this.statusStrip.Text = "statusStrip";
			// 
			// lblAppStatusLabel
			// 
			this.lblAppStatusLabel.Name = "lblAppStatusLabel";
			this.lblAppStatusLabel.Size = new System.Drawing.Size(42, 17);
			this.lblAppStatusLabel.Text = "Status:";
			// 
			// lblAppStatusValue
			// 
			this.lblAppStatusValue.Name = "lblAppStatusValue";
			this.lblAppStatusValue.Size = new System.Drawing.Size(153, 17);
			this.lblAppStatusValue.Text = global::GettingUpTrainer.Properties.Resources.WaitingForGettingUpExe;
			// 
			// gbEnemy
			// 
			this.gbEnemy.Controls.Add(this.pnlEnemySelected);
			this.gbEnemy.Controls.Add(this.lblEnemySeparator);
			this.gbEnemy.Controls.Add(this.lblEnemySelected);
			this.gbEnemy.Controls.Add(this.cbEnemySelected);
			this.gbEnemy.Controls.Add(this.lblEnemyCountValue);
			this.gbEnemy.Controls.Add(this.lblEnemyCountName);
			this.gbEnemy.Enabled = false;
			this.gbEnemy.Location = new System.Drawing.Point(10, 294);
			this.gbEnemy.Name = "gbEnemy";
			this.gbEnemy.Size = new System.Drawing.Size(370, 190);
			this.gbEnemy.TabIndex = 3;
			this.gbEnemy.TabStop = false;
			this.gbEnemy.Text = "Enemy";
			// 
			// pnlEnemySelected
			// 
			this.pnlEnemySelected.Controls.Add(this.btnEnemyPosition);
			this.pnlEnemySelected.Controls.Add(this.lblEnemyHealthDesc);
			this.pnlEnemySelected.Controls.Add(this.txtEnemyPositionZ);
			this.pnlEnemySelected.Controls.Add(this.lblEnemyNameHealthCurrent);
			this.pnlEnemySelected.Controls.Add(this.txtEnemyPositionY);
			this.pnlEnemySelected.Controls.Add(this.lblEnemyValueHealthCurrent);
			this.pnlEnemySelected.Controls.Add(this.txtEnemyPositionX);
			this.pnlEnemySelected.Controls.Add(this.lblEnemyValueHealthMax);
			this.pnlEnemySelected.Controls.Add(this.lblEnemyNamePositionZ);
			this.pnlEnemySelected.Controls.Add(this.lblEnemyNameHealthMax);
			this.pnlEnemySelected.Controls.Add(this.lblEnemyNamePositionY);
			this.pnlEnemySelected.Controls.Add(this.txtEnemyHealthCurrent);
			this.pnlEnemySelected.Controls.Add(this.lblEnemyValuePositionZ);
			this.pnlEnemySelected.Controls.Add(this.txtEnemyHealthMax);
			this.pnlEnemySelected.Controls.Add(this.lblEnemyValuePositionY);
			this.pnlEnemySelected.Controls.Add(this.btnEnemyHealth);
			this.pnlEnemySelected.Controls.Add(this.lblEnemyValuePositionX);
			this.pnlEnemySelected.Controls.Add(this.lblEnemyPositionDesc);
			this.pnlEnemySelected.Controls.Add(this.lblEnemyNamePositionX);
			this.pnlEnemySelected.Enabled = false;
			this.pnlEnemySelected.Location = new System.Drawing.Point(1, 52);
			this.pnlEnemySelected.Name = "pnlEnemySelected";
			this.pnlEnemySelected.Size = new System.Drawing.Size(366, 133);
			this.pnlEnemySelected.TabIndex = 5;
			// 
			// btnEnemyPosition
			// 
			this.btnEnemyPosition.Location = new System.Drawing.Point(315, 56);
			this.btnEnemyPosition.Name = "btnEnemyPosition";
			this.btnEnemyPosition.Size = new System.Drawing.Size(50, 72);
			this.btnEnemyPosition.TabIndex = 23;
			this.btnEnemyPosition.Text = "Set";
			this.btnEnemyPosition.UseVisualStyleBackColor = true;
			this.btnEnemyPosition.Click += new System.EventHandler(this.btnEnemyPosition_Click);
			// 
			// lblEnemyHealthDesc
			// 
			this.lblEnemyHealthDesc.Location = new System.Drawing.Point(6, 0);
			this.lblEnemyHealthDesc.Name = "lblEnemyHealthDesc";
			this.lblEnemyHealthDesc.Size = new System.Drawing.Size(50, 52);
			this.lblEnemyHealthDesc.TabIndex = 4;
			this.lblEnemyHealthDesc.Text = "Health";
			this.lblEnemyHealthDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtEnemyPositionZ
			// 
			this.txtEnemyPositionZ.Location = new System.Drawing.Point(208, 108);
			this.txtEnemyPositionZ.Name = "txtEnemyPositionZ";
			this.txtEnemyPositionZ.Size = new System.Drawing.Size(100, 20);
			this.txtEnemyPositionZ.TabIndex = 20;
			// 
			// lblEnemyNameHealthCurrent
			// 
			this.lblEnemyNameHealthCurrent.Location = new System.Drawing.Point(56, 0);
			this.lblEnemyNameHealthCurrent.Name = "lblEnemyNameHealthCurrent";
			this.lblEnemyNameHealthCurrent.Size = new System.Drawing.Size(40, 26);
			this.lblEnemyNameHealthCurrent.TabIndex = 8;
			this.lblEnemyNameHealthCurrent.Text = "Cur:";
			this.lblEnemyNameHealthCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtEnemyPositionY
			// 
			this.txtEnemyPositionY.Location = new System.Drawing.Point(208, 82);
			this.txtEnemyPositionY.Name = "txtEnemyPositionY";
			this.txtEnemyPositionY.Size = new System.Drawing.Size(100, 20);
			this.txtEnemyPositionY.TabIndex = 21;
			// 
			// lblEnemyValueHealthCurrent
			// 
			this.lblEnemyValueHealthCurrent.Location = new System.Drawing.Point(102, 1);
			this.lblEnemyValueHealthCurrent.Name = "lblEnemyValueHealthCurrent";
			this.lblEnemyValueHealthCurrent.Size = new System.Drawing.Size(100, 26);
			this.lblEnemyValueHealthCurrent.TabIndex = 7;
			this.lblEnemyValueHealthCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtEnemyPositionX
			// 
			this.txtEnemyPositionX.Location = new System.Drawing.Point(208, 56);
			this.txtEnemyPositionX.Name = "txtEnemyPositionX";
			this.txtEnemyPositionX.Size = new System.Drawing.Size(100, 20);
			this.txtEnemyPositionX.TabIndex = 22;
			// 
			// lblEnemyValueHealthMax
			// 
			this.lblEnemyValueHealthMax.Location = new System.Drawing.Point(102, 26);
			this.lblEnemyValueHealthMax.Name = "lblEnemyValueHealthMax";
			this.lblEnemyValueHealthMax.Size = new System.Drawing.Size(100, 26);
			this.lblEnemyValueHealthMax.TabIndex = 6;
			this.lblEnemyValueHealthMax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblEnemyNamePositionZ
			// 
			this.lblEnemyNamePositionZ.Location = new System.Drawing.Point(56, 104);
			this.lblEnemyNamePositionZ.Name = "lblEnemyNamePositionZ";
			this.lblEnemyNamePositionZ.Size = new System.Drawing.Size(40, 26);
			this.lblEnemyNamePositionZ.TabIndex = 14;
			this.lblEnemyNamePositionZ.Text = "Z:";
			this.lblEnemyNamePositionZ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblEnemyNameHealthMax
			// 
			this.lblEnemyNameHealthMax.Location = new System.Drawing.Point(56, 25);
			this.lblEnemyNameHealthMax.Name = "lblEnemyNameHealthMax";
			this.lblEnemyNameHealthMax.Size = new System.Drawing.Size(40, 26);
			this.lblEnemyNameHealthMax.TabIndex = 5;
			this.lblEnemyNameHealthMax.Text = "Max:";
			this.lblEnemyNameHealthMax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblEnemyNamePositionY
			// 
			this.lblEnemyNamePositionY.Location = new System.Drawing.Point(56, 78);
			this.lblEnemyNamePositionY.Name = "lblEnemyNamePositionY";
			this.lblEnemyNamePositionY.Size = new System.Drawing.Size(40, 26);
			this.lblEnemyNamePositionY.TabIndex = 15;
			this.lblEnemyNamePositionY.Text = "Y:";
			this.lblEnemyNamePositionY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtEnemyHealthCurrent
			// 
			this.txtEnemyHealthCurrent.Location = new System.Drawing.Point(208, 4);
			this.txtEnemyHealthCurrent.Name = "txtEnemyHealthCurrent";
			this.txtEnemyHealthCurrent.Size = new System.Drawing.Size(100, 20);
			this.txtEnemyHealthCurrent.TabIndex = 10;
			// 
			// lblEnemyValuePositionZ
			// 
			this.lblEnemyValuePositionZ.Location = new System.Drawing.Point(102, 104);
			this.lblEnemyValuePositionZ.Name = "lblEnemyValuePositionZ";
			this.lblEnemyValuePositionZ.Size = new System.Drawing.Size(100, 26);
			this.lblEnemyValuePositionZ.TabIndex = 16;
			this.lblEnemyValuePositionZ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtEnemyHealthMax
			// 
			this.txtEnemyHealthMax.Location = new System.Drawing.Point(208, 30);
			this.txtEnemyHealthMax.Name = "txtEnemyHealthMax";
			this.txtEnemyHealthMax.Size = new System.Drawing.Size(100, 20);
			this.txtEnemyHealthMax.TabIndex = 9;
			// 
			// lblEnemyValuePositionY
			// 
			this.lblEnemyValuePositionY.Location = new System.Drawing.Point(102, 78);
			this.lblEnemyValuePositionY.Name = "lblEnemyValuePositionY";
			this.lblEnemyValuePositionY.Size = new System.Drawing.Size(100, 26);
			this.lblEnemyValuePositionY.TabIndex = 17;
			this.lblEnemyValuePositionY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnEnemyHealth
			// 
			this.btnEnemyHealth.Location = new System.Drawing.Point(315, 4);
			this.btnEnemyHealth.Name = "btnEnemyHealth";
			this.btnEnemyHealth.Size = new System.Drawing.Size(50, 46);
			this.btnEnemyHealth.TabIndex = 11;
			this.btnEnemyHealth.Text = "Set";
			this.btnEnemyHealth.UseVisualStyleBackColor = true;
			this.btnEnemyHealth.Click += new System.EventHandler(this.btnEnemyHealth_Click);
			// 
			// lblEnemyValuePositionX
			// 
			this.lblEnemyValuePositionX.Location = new System.Drawing.Point(102, 52);
			this.lblEnemyValuePositionX.Name = "lblEnemyValuePositionX";
			this.lblEnemyValuePositionX.Size = new System.Drawing.Size(100, 26);
			this.lblEnemyValuePositionX.TabIndex = 18;
			this.lblEnemyValuePositionX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblEnemyPositionDesc
			// 
			this.lblEnemyPositionDesc.Location = new System.Drawing.Point(6, 52);
			this.lblEnemyPositionDesc.Name = "lblEnemyPositionDesc";
			this.lblEnemyPositionDesc.Size = new System.Drawing.Size(50, 76);
			this.lblEnemyPositionDesc.TabIndex = 13;
			this.lblEnemyPositionDesc.Text = "Position";
			this.lblEnemyPositionDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblEnemyNamePositionX
			// 
			this.lblEnemyNamePositionX.Location = new System.Drawing.Point(56, 52);
			this.lblEnemyNamePositionX.Name = "lblEnemyNamePositionX";
			this.lblEnemyNamePositionX.Size = new System.Drawing.Size(40, 26);
			this.lblEnemyNamePositionX.TabIndex = 19;
			this.lblEnemyNamePositionX.Text = "X:";
			this.lblEnemyNamePositionX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblEnemySeparator
			// 
			this.lblEnemySeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblEnemySeparator.Location = new System.Drawing.Point(9, 47);
			this.lblEnemySeparator.Name = "lblEnemySeparator";
			this.lblEnemySeparator.Size = new System.Drawing.Size(356, 2);
			this.lblEnemySeparator.TabIndex = 12;
			// 
			// lblEnemySelected
			// 
			this.lblEnemySelected.AutoSize = true;
			this.lblEnemySelected.Location = new System.Drawing.Point(6, 22);
			this.lblEnemySelected.Name = "lblEnemySelected";
			this.lblEnemySelected.Size = new System.Drawing.Size(52, 13);
			this.lblEnemySelected.TabIndex = 3;
			this.lblEnemySelected.Text = "Selected:";
			// 
			// cbEnemySelected
			// 
			this.cbEnemySelected.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbEnemySelected.FormattingEnabled = true;
			this.cbEnemySelected.Location = new System.Drawing.Point(64, 19);
			this.cbEnemySelected.Name = "cbEnemySelected";
			this.cbEnemySelected.Size = new System.Drawing.Size(217, 21);
			this.cbEnemySelected.TabIndex = 2;
			this.cbEnemySelected.SelectedIndexChanged += new System.EventHandler(this.cbEnemySelected_SelectedIndexChanged);
			// 
			// lblEnemyCountValue
			// 
			this.lblEnemyCountValue.Location = new System.Drawing.Point(331, 22);
			this.lblEnemyCountValue.Name = "lblEnemyCountValue";
			this.lblEnemyCountValue.Size = new System.Drawing.Size(31, 13);
			this.lblEnemyCountValue.TabIndex = 1;
			// 
			// lblEnemyCountName
			// 
			this.lblEnemyCountName.AutoSize = true;
			this.lblEnemyCountName.Location = new System.Drawing.Point(287, 22);
			this.lblEnemyCountName.Name = "lblEnemyCountName";
			this.lblEnemyCountName.Size = new System.Drawing.Size(38, 13);
			this.lblEnemyCountName.TabIndex = 0;
			this.lblEnemyCountName.Text = "Count:";
			// 
			// gbPlayer
			// 
			this.gbPlayer.Controls.Add(this.lblPlayerValueModelName);
			this.gbPlayer.Controls.Add(this.lblPlayerNameModelName);
			this.gbPlayer.Controls.Add(this.btnPlayerPosition);
			this.gbPlayer.Controls.Add(this.btnPlayerRep);
			this.gbPlayer.Controls.Add(this.btnPlayerPower);
			this.gbPlayer.Controls.Add(this.btnPlayerHealth);
			this.gbPlayer.Controls.Add(this.txtPlayerPositionZ);
			this.gbPlayer.Controls.Add(this.txtPlayerPositionY);
			this.gbPlayer.Controls.Add(this.txtPlayerPositionX);
			this.gbPlayer.Controls.Add(this.txtPlayerRepMax);
			this.gbPlayer.Controls.Add(this.txtPlayerPowerMax);
			this.gbPlayer.Controls.Add(this.txtPlayerRepCurrent);
			this.gbPlayer.Controls.Add(this.lblPlayerNamePositionZ);
			this.gbPlayer.Controls.Add(this.lblPlayerNamePositionY);
			this.gbPlayer.Controls.Add(this.txtPlayerHealthMax);
			this.gbPlayer.Controls.Add(this.txtPlayerPowerCurrent);
			this.gbPlayer.Controls.Add(this.lblPlayerNameRepMax);
			this.gbPlayer.Controls.Add(this.lblPlayerValuePositionZ);
			this.gbPlayer.Controls.Add(this.lblPlayerValuePositionY);
			this.gbPlayer.Controls.Add(this.txtPlayerHealthCurrent);
			this.gbPlayer.Controls.Add(this.lblPlayerNamePowerMax);
			this.gbPlayer.Controls.Add(this.lblPlayerValuePositionX);
			this.gbPlayer.Controls.Add(this.lblPlayerValueRepMax);
			this.gbPlayer.Controls.Add(this.lblPlayerNameHealthMax);
			this.gbPlayer.Controls.Add(this.lblPlayerValueRepCurrent);
			this.gbPlayer.Controls.Add(this.lblPlayerNamePositionX);
			this.gbPlayer.Controls.Add(this.lblPlayerValuePowerMax);
			this.gbPlayer.Controls.Add(this.lblPlayerValuePowerCurrent);
			this.gbPlayer.Controls.Add(this.lblPlayerNameRepCurrent);
			this.gbPlayer.Controls.Add(this.lblPlayerDescPosition);
			this.gbPlayer.Controls.Add(this.lblPlayerValueHealthMax);
			this.gbPlayer.Controls.Add(this.lblPlayerNamePowerCurrent);
			this.gbPlayer.Controls.Add(this.lblPlayerDescRep);
			this.gbPlayer.Controls.Add(this.lblPlayerValueHealthCurrent);
			this.gbPlayer.Controls.Add(this.lblPlayerDescPower);
			this.gbPlayer.Controls.Add(this.lblPlayerNameHealthCurrent);
			this.gbPlayer.Controls.Add(this.lblPlayerDescHealth);
			this.gbPlayer.Enabled = false;
			this.gbPlayer.Location = new System.Drawing.Point(10, 3);
			this.gbPlayer.Name = "gbPlayer";
			this.gbPlayer.Size = new System.Drawing.Size(370, 285);
			this.gbPlayer.TabIndex = 4;
			this.gbPlayer.TabStop = false;
			this.gbPlayer.Text = "Player";
			// 
			// lblPlayerValueModelName
			// 
			this.lblPlayerValueModelName.AutoEllipsis = true;
			this.lblPlayerValueModelName.Location = new System.Drawing.Point(103, 16);
			this.lblPlayerValueModelName.Name = "lblPlayerValueModelName";
			this.lblPlayerValueModelName.Size = new System.Drawing.Size(263, 25);
			this.lblPlayerValueModelName.TabIndex = 27;
			this.lblPlayerValueModelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPlayerNameModelName
			// 
			this.lblPlayerNameModelName.Location = new System.Drawing.Point(8, 16);
			this.lblPlayerNameModelName.Name = "lblPlayerNameModelName";
			this.lblPlayerNameModelName.Size = new System.Drawing.Size(90, 25);
			this.lblPlayerNameModelName.TabIndex = 26;
			this.lblPlayerNameModelName.Text = "Model Name:";
			this.lblPlayerNameModelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnPlayerPosition
			// 
			this.btnPlayerPosition.Location = new System.Drawing.Point(313, 206);
			this.btnPlayerPosition.Name = "btnPlayerPosition";
			this.btnPlayerPosition.Size = new System.Drawing.Size(49, 72);
			this.btnPlayerPosition.TabIndex = 3;
			this.btnPlayerPosition.Text = "Set [F12]";
			this.btnPlayerPosition.UseVisualStyleBackColor = true;
			this.btnPlayerPosition.Click += new System.EventHandler(this.btnPlayerPosition_Click);
			// 
			// btnPlayerRep
			// 
			this.btnPlayerRep.Location = new System.Drawing.Point(313, 154);
			this.btnPlayerRep.Name = "btnPlayerRep";
			this.btnPlayerRep.Size = new System.Drawing.Size(49, 46);
			this.btnPlayerRep.TabIndex = 3;
			this.btnPlayerRep.Text = "Set [F11]";
			this.btnPlayerRep.UseVisualStyleBackColor = true;
			this.btnPlayerRep.Click += new System.EventHandler(this.btnPlayerRep_Click);
			// 
			// btnPlayerPower
			// 
			this.btnPlayerPower.Location = new System.Drawing.Point(313, 97);
			this.btnPlayerPower.Name = "btnPlayerPower";
			this.btnPlayerPower.Size = new System.Drawing.Size(49, 46);
			this.btnPlayerPower.TabIndex = 3;
			this.btnPlayerPower.Text = "Set [F10]";
			this.btnPlayerPower.UseVisualStyleBackColor = true;
			this.btnPlayerPower.Click += new System.EventHandler(this.btnPlayerPower_Click);
			// 
			// btnPlayerHealth
			// 
			this.btnPlayerHealth.Location = new System.Drawing.Point(313, 47);
			this.btnPlayerHealth.Name = "btnPlayerHealth";
			this.btnPlayerHealth.Size = new System.Drawing.Size(49, 46);
			this.btnPlayerHealth.TabIndex = 3;
			this.btnPlayerHealth.Text = "Set [F9]";
			this.btnPlayerHealth.UseVisualStyleBackColor = true;
			this.btnPlayerHealth.Click += new System.EventHandler(this.btnPlayerHealth_Click);
			// 
			// txtPlayerPositionZ
			// 
			this.txtPlayerPositionZ.Location = new System.Drawing.Point(206, 258);
			this.txtPlayerPositionZ.Name = "txtPlayerPositionZ";
			this.txtPlayerPositionZ.Size = new System.Drawing.Size(100, 20);
			this.txtPlayerPositionZ.TabIndex = 2;
			// 
			// txtPlayerPositionY
			// 
			this.txtPlayerPositionY.Location = new System.Drawing.Point(206, 232);
			this.txtPlayerPositionY.Name = "txtPlayerPositionY";
			this.txtPlayerPositionY.Size = new System.Drawing.Size(100, 20);
			this.txtPlayerPositionY.TabIndex = 2;
			// 
			// txtPlayerPositionX
			// 
			this.txtPlayerPositionX.Location = new System.Drawing.Point(206, 206);
			this.txtPlayerPositionX.Name = "txtPlayerPositionX";
			this.txtPlayerPositionX.Size = new System.Drawing.Size(100, 20);
			this.txtPlayerPositionX.TabIndex = 2;
			// 
			// txtPlayerRepMax
			// 
			this.txtPlayerRepMax.Location = new System.Drawing.Point(206, 180);
			this.txtPlayerRepMax.Name = "txtPlayerRepMax";
			this.txtPlayerRepMax.Size = new System.Drawing.Size(100, 20);
			this.txtPlayerRepMax.TabIndex = 2;
			// 
			// txtPlayerPowerMax
			// 
			this.txtPlayerPowerMax.Location = new System.Drawing.Point(206, 123);
			this.txtPlayerPowerMax.Name = "txtPlayerPowerMax";
			this.txtPlayerPowerMax.Size = new System.Drawing.Size(100, 20);
			this.txtPlayerPowerMax.TabIndex = 2;
			// 
			// txtPlayerRepCurrent
			// 
			this.txtPlayerRepCurrent.Location = new System.Drawing.Point(206, 154);
			this.txtPlayerRepCurrent.Name = "txtPlayerRepCurrent";
			this.txtPlayerRepCurrent.Size = new System.Drawing.Size(100, 20);
			this.txtPlayerRepCurrent.TabIndex = 2;
			// 
			// lblPlayerNamePositionZ
			// 
			this.lblPlayerNamePositionZ.Location = new System.Drawing.Point(58, 254);
			this.lblPlayerNamePositionZ.Name = "lblPlayerNamePositionZ";
			this.lblPlayerNamePositionZ.Size = new System.Drawing.Size(36, 26);
			this.lblPlayerNamePositionZ.TabIndex = 1;
			this.lblPlayerNamePositionZ.Text = "Z:";
			this.lblPlayerNamePositionZ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPlayerNamePositionY
			// 
			this.lblPlayerNamePositionY.Location = new System.Drawing.Point(58, 228);
			this.lblPlayerNamePositionY.Name = "lblPlayerNamePositionY";
			this.lblPlayerNamePositionY.Size = new System.Drawing.Size(36, 26);
			this.lblPlayerNamePositionY.TabIndex = 1;
			this.lblPlayerNamePositionY.Text = "Y:";
			this.lblPlayerNamePositionY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtPlayerHealthMax
			// 
			this.txtPlayerHealthMax.Location = new System.Drawing.Point(206, 73);
			this.txtPlayerHealthMax.Name = "txtPlayerHealthMax";
			this.txtPlayerHealthMax.Size = new System.Drawing.Size(100, 20);
			this.txtPlayerHealthMax.TabIndex = 2;
			// 
			// txtPlayerPowerCurrent
			// 
			this.txtPlayerPowerCurrent.Location = new System.Drawing.Point(206, 97);
			this.txtPlayerPowerCurrent.Name = "txtPlayerPowerCurrent";
			this.txtPlayerPowerCurrent.Size = new System.Drawing.Size(100, 20);
			this.txtPlayerPowerCurrent.TabIndex = 2;
			// 
			// lblPlayerNameRepMax
			// 
			this.lblPlayerNameRepMax.Location = new System.Drawing.Point(58, 176);
			this.lblPlayerNameRepMax.Name = "lblPlayerNameRepMax";
			this.lblPlayerNameRepMax.Size = new System.Drawing.Size(36, 26);
			this.lblPlayerNameRepMax.TabIndex = 1;
			this.lblPlayerNameRepMax.Text = "Max:";
			this.lblPlayerNameRepMax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPlayerValuePositionZ
			// 
			this.lblPlayerValuePositionZ.Location = new System.Drawing.Point(102, 254);
			this.lblPlayerValuePositionZ.Name = "lblPlayerValuePositionZ";
			this.lblPlayerValuePositionZ.Size = new System.Drawing.Size(98, 26);
			this.lblPlayerValuePositionZ.TabIndex = 1;
			this.lblPlayerValuePositionZ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPlayerValuePositionY
			// 
			this.lblPlayerValuePositionY.Location = new System.Drawing.Point(103, 228);
			this.lblPlayerValuePositionY.Name = "lblPlayerValuePositionY";
			this.lblPlayerValuePositionY.Size = new System.Drawing.Size(97, 26);
			this.lblPlayerValuePositionY.TabIndex = 1;
			this.lblPlayerValuePositionY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtPlayerHealthCurrent
			// 
			this.txtPlayerHealthCurrent.Location = new System.Drawing.Point(206, 47);
			this.txtPlayerHealthCurrent.Name = "txtPlayerHealthCurrent";
			this.txtPlayerHealthCurrent.Size = new System.Drawing.Size(100, 20);
			this.txtPlayerHealthCurrent.TabIndex = 2;
			// 
			// lblPlayerNamePowerMax
			// 
			this.lblPlayerNamePowerMax.Location = new System.Drawing.Point(58, 119);
			this.lblPlayerNamePowerMax.Name = "lblPlayerNamePowerMax";
			this.lblPlayerNamePowerMax.Size = new System.Drawing.Size(36, 26);
			this.lblPlayerNamePowerMax.TabIndex = 1;
			this.lblPlayerNamePowerMax.Text = "Max:";
			this.lblPlayerNamePowerMax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPlayerValuePositionX
			// 
			this.lblPlayerValuePositionX.Location = new System.Drawing.Point(105, 202);
			this.lblPlayerValuePositionX.Name = "lblPlayerValuePositionX";
			this.lblPlayerValuePositionX.Size = new System.Drawing.Size(95, 26);
			this.lblPlayerValuePositionX.TabIndex = 1;
			this.lblPlayerValuePositionX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPlayerValueRepMax
			// 
			this.lblPlayerValueRepMax.Location = new System.Drawing.Point(105, 176);
			this.lblPlayerValueRepMax.Name = "lblPlayerValueRepMax";
			this.lblPlayerValueRepMax.Size = new System.Drawing.Size(95, 26);
			this.lblPlayerValueRepMax.TabIndex = 1;
			this.lblPlayerValueRepMax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPlayerNameHealthMax
			// 
			this.lblPlayerNameHealthMax.Location = new System.Drawing.Point(58, 68);
			this.lblPlayerNameHealthMax.Name = "lblPlayerNameHealthMax";
			this.lblPlayerNameHealthMax.Size = new System.Drawing.Size(36, 26);
			this.lblPlayerNameHealthMax.TabIndex = 1;
			this.lblPlayerNameHealthMax.Text = "Max:";
			this.lblPlayerNameHealthMax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPlayerValueRepCurrent
			// 
			this.lblPlayerValueRepCurrent.Location = new System.Drawing.Point(105, 150);
			this.lblPlayerValueRepCurrent.Name = "lblPlayerValueRepCurrent";
			this.lblPlayerValueRepCurrent.Size = new System.Drawing.Size(95, 26);
			this.lblPlayerValueRepCurrent.TabIndex = 1;
			this.lblPlayerValueRepCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPlayerNamePositionX
			// 
			this.lblPlayerNamePositionX.Location = new System.Drawing.Point(58, 202);
			this.lblPlayerNamePositionX.Name = "lblPlayerNamePositionX";
			this.lblPlayerNamePositionX.Size = new System.Drawing.Size(36, 26);
			this.lblPlayerNamePositionX.TabIndex = 1;
			this.lblPlayerNamePositionX.Text = "X:";
			this.lblPlayerNamePositionX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPlayerValuePowerMax
			// 
			this.lblPlayerValuePowerMax.Location = new System.Drawing.Point(105, 119);
			this.lblPlayerValuePowerMax.Name = "lblPlayerValuePowerMax";
			this.lblPlayerValuePowerMax.Size = new System.Drawing.Size(95, 26);
			this.lblPlayerValuePowerMax.TabIndex = 1;
			this.lblPlayerValuePowerMax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPlayerValuePowerCurrent
			// 
			this.lblPlayerValuePowerCurrent.Location = new System.Drawing.Point(105, 93);
			this.lblPlayerValuePowerCurrent.Name = "lblPlayerValuePowerCurrent";
			this.lblPlayerValuePowerCurrent.Size = new System.Drawing.Size(95, 26);
			this.lblPlayerValuePowerCurrent.TabIndex = 1;
			this.lblPlayerValuePowerCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPlayerNameRepCurrent
			// 
			this.lblPlayerNameRepCurrent.Location = new System.Drawing.Point(58, 150);
			this.lblPlayerNameRepCurrent.Name = "lblPlayerNameRepCurrent";
			this.lblPlayerNameRepCurrent.Size = new System.Drawing.Size(36, 26);
			this.lblPlayerNameRepCurrent.TabIndex = 1;
			this.lblPlayerNameRepCurrent.Text = "Cur:";
			this.lblPlayerNameRepCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPlayerDescPosition
			// 
			this.lblPlayerDescPosition.Location = new System.Drawing.Point(8, 202);
			this.lblPlayerDescPosition.Name = "lblPlayerDescPosition";
			this.lblPlayerDescPosition.Size = new System.Drawing.Size(50, 76);
			this.lblPlayerDescPosition.TabIndex = 0;
			this.lblPlayerDescPosition.Text = "Position";
			this.lblPlayerDescPosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPlayerValueHealthMax
			// 
			this.lblPlayerValueHealthMax.Location = new System.Drawing.Point(105, 69);
			this.lblPlayerValueHealthMax.Name = "lblPlayerValueHealthMax";
			this.lblPlayerValueHealthMax.Size = new System.Drawing.Size(95, 26);
			this.lblPlayerValueHealthMax.TabIndex = 1;
			this.lblPlayerValueHealthMax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPlayerNamePowerCurrent
			// 
			this.lblPlayerNamePowerCurrent.Location = new System.Drawing.Point(58, 93);
			this.lblPlayerNamePowerCurrent.Name = "lblPlayerNamePowerCurrent";
			this.lblPlayerNamePowerCurrent.Size = new System.Drawing.Size(36, 26);
			this.lblPlayerNamePowerCurrent.TabIndex = 1;
			this.lblPlayerNamePowerCurrent.Text = "Cur:";
			this.lblPlayerNamePowerCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPlayerDescRep
			// 
			this.lblPlayerDescRep.Location = new System.Drawing.Point(8, 150);
			this.lblPlayerDescRep.Name = "lblPlayerDescRep";
			this.lblPlayerDescRep.Size = new System.Drawing.Size(50, 52);
			this.lblPlayerDescRep.TabIndex = 0;
			this.lblPlayerDescRep.Text = "Rep";
			this.lblPlayerDescRep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPlayerValueHealthCurrent
			// 
			this.lblPlayerValueHealthCurrent.Location = new System.Drawing.Point(105, 44);
			this.lblPlayerValueHealthCurrent.Name = "lblPlayerValueHealthCurrent";
			this.lblPlayerValueHealthCurrent.Size = new System.Drawing.Size(95, 26);
			this.lblPlayerValueHealthCurrent.TabIndex = 1;
			this.lblPlayerValueHealthCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPlayerDescPower
			// 
			this.lblPlayerDescPower.Location = new System.Drawing.Point(8, 93);
			this.lblPlayerDescPower.Name = "lblPlayerDescPower";
			this.lblPlayerDescPower.Size = new System.Drawing.Size(50, 52);
			this.lblPlayerDescPower.TabIndex = 0;
			this.lblPlayerDescPower.Text = "Power";
			this.lblPlayerDescPower.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPlayerNameHealthCurrent
			// 
			this.lblPlayerNameHealthCurrent.Location = new System.Drawing.Point(58, 43);
			this.lblPlayerNameHealthCurrent.Name = "lblPlayerNameHealthCurrent";
			this.lblPlayerNameHealthCurrent.Size = new System.Drawing.Size(36, 26);
			this.lblPlayerNameHealthCurrent.TabIndex = 1;
			this.lblPlayerNameHealthCurrent.Text = "Cur:";
			this.lblPlayerNameHealthCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPlayerDescHealth
			// 
			this.lblPlayerDescHealth.Location = new System.Drawing.Point(8, 41);
			this.lblPlayerDescHealth.Name = "lblPlayerDescHealth";
			this.lblPlayerDescHealth.Size = new System.Drawing.Size(50, 52);
			this.lblPlayerDescHealth.TabIndex = 0;
			this.lblPlayerDescHealth.Text = "Health";
			this.lblPlayerDescHealth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// UserInterfaceForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(389, 512);
			this.Controls.Add(this.gbPlayer);
			this.Controls.Add(this.gbEnemy);
			this.Controls.Add(this.statusStrip);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "UserInterfaceForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Getting Up Trainer";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserInterface_FormClosing);
			this.Load += new System.EventHandler(this.UserInterface_Load);
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.gbEnemy.ResumeLayout(false);
			this.gbEnemy.PerformLayout();
			this.pnlEnemySelected.ResumeLayout(false);
			this.pnlEnemySelected.PerformLayout();
			this.gbPlayer.ResumeLayout(false);
			this.gbPlayer.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel lblAppStatusLabel;
		private System.Windows.Forms.ToolStripStatusLabel lblAppStatusValue;
		private GroupBox gbEnemy;
		private Label lblEnemySelected;
		private ComboBox cbEnemySelected;
		private Label lblEnemyCountValue;
		private Label lblEnemyCountName;
		private Button btnEnemyHealth;
		private TextBox txtEnemyHealthMax;
		private TextBox txtEnemyHealthCurrent;
		private Label lblEnemyNameHealthMax;
		private Label lblEnemyValueHealthMax;
		private Label lblEnemyValueHealthCurrent;
		private Label lblEnemyNameHealthCurrent;
		private Label lblEnemyHealthDesc;
		private Label lblEnemySeparator;
		private Button btnEnemyPosition;
		private TextBox txtEnemyPositionZ;
		private TextBox txtEnemyPositionY;
		private TextBox txtEnemyPositionX;
		private Label lblEnemyNamePositionZ;
		private Label lblEnemyNamePositionY;
		private Label lblEnemyValuePositionZ;
		private Label lblEnemyValuePositionY;
		private Label lblEnemyValuePositionX;
		private Label lblEnemyNamePositionX;
		private Label lblEnemyPositionDesc;
		private GroupBox gbPlayer;
		private Label lblPlayerValueModelName;
		private Label lblPlayerNameModelName;
		private Button btnPlayerPosition;
		private Button btnPlayerRep;
		private Button btnPlayerPower;
		private Button btnPlayerHealth;
		private TextBox txtPlayerPositionZ;
		private TextBox txtPlayerPositionY;
		private TextBox txtPlayerPositionX;
		private TextBox txtPlayerRepMax;
		private TextBox txtPlayerPowerMax;
		private TextBox txtPlayerRepCurrent;
		private Label lblPlayerNamePositionZ;
		private Label lblPlayerNamePositionY;
		private TextBox txtPlayerHealthMax;
		private TextBox txtPlayerPowerCurrent;
		private Label lblPlayerNameRepMax;
		private Label lblPlayerValuePositionZ;
		private Label lblPlayerValuePositionY;
		private TextBox txtPlayerHealthCurrent;
		private Label lblPlayerNamePowerMax;
		private Label lblPlayerValuePositionX;
		private Label lblPlayerValueRepMax;
		private Label lblPlayerNameHealthMax;
		private Label lblPlayerValueRepCurrent;
		private Label lblPlayerNamePositionX;
		private Label lblPlayerValuePowerMax;
		private Label lblPlayerValuePowerCurrent;
		private Label lblPlayerNameRepCurrent;
		private Label lblPlayerDescPosition;
		private Label lblPlayerValueHealthMax;
		private Label lblPlayerNamePowerCurrent;
		private Label lblPlayerDescRep;
		private Label lblPlayerValueHealthCurrent;
		private Label lblPlayerDescPower;
		private Label lblPlayerNameHealthCurrent;
		private Label lblPlayerDescHealth;
		private Panel pnlEnemySelected;
	}
}