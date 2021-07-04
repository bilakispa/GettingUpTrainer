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
			this.toolStripStatusLabelEmpty = new System.Windows.Forms.ToolStripStatusLabel();
			this.btnSettings = new System.Windows.Forms.ToolStripDropDownButton();
			this.btnAbout = new System.Windows.Forms.ToolStripDropDownButton();
			this.gbEnemy = new System.Windows.Forms.GroupBox();
			this.tblEnemySelected = new System.Windows.Forms.TableLayoutPanel();
			this.lblEnemyRotationYawValue = new System.Windows.Forms.Label();
			this.lblEnemyRotationYawName = new System.Windows.Forms.Label();
			this.lblEnemyRotationDesc = new System.Windows.Forms.Label();
			this.btnEnemyPosition = new System.Windows.Forms.Button();
			this.lblSplitter7 = new System.Windows.Forms.Label();
			this.txtEnemyPositionZ = new System.Windows.Forms.TextBox();
			this.lblSplitter6 = new System.Windows.Forms.Label();
			this.txtEnemyPositionY = new System.Windows.Forms.TextBox();
			this.lblEnemyHealthDesc = new System.Windows.Forms.Label();
			this.txtEnemyPositionX = new System.Windows.Forms.TextBox();
			this.lblEnemyHealthCurrentName = new System.Windows.Forms.Label();
			this.lblEnemyPositionZValue = new System.Windows.Forms.Label();
			this.lblEnemyPositionZName = new System.Windows.Forms.Label();
			this.lblEnemyPositionYValue = new System.Windows.Forms.Label();
			this.lblEnemyHealthMaxName = new System.Windows.Forms.Label();
			this.lblEnemyPositionXValue = new System.Windows.Forms.Label();
			this.lblEnemyPositionYName = new System.Windows.Forms.Label();
			this.lblEnemyHealthCurrentValue = new System.Windows.Forms.Label();
			this.lblEnemyHealthMaxValue = new System.Windows.Forms.Label();
			this.txtEnemyHealthCurrent = new System.Windows.Forms.TextBox();
			this.txtEnemyHealthMax = new System.Windows.Forms.TextBox();
			this.lblEnemyPositionXName = new System.Windows.Forms.Label();
			this.lblEnemyPositionDesc = new System.Windows.Forms.Label();
			this.btnEnemyHealth = new System.Windows.Forms.Button();
			this.lblEnemySeparator = new System.Windows.Forms.Label();
			this.lblEnemySelected = new System.Windows.Forms.Label();
			this.cbEnemySelected = new System.Windows.Forms.ComboBox();
			this.lblEnemyCountValue = new System.Windows.Forms.Label();
			this.lblEnemyCountName = new System.Windows.Forms.Label();
			this.gbPlayer = new System.Windows.Forms.GroupBox();
			this.tblPlayer = new System.Windows.Forms.TableLayoutPanel();
			this.lblPlayerRotationYawValue = new System.Windows.Forms.Label();
			this.lblPlayerRotationYawName = new System.Windows.Forms.Label();
			this.lblSplitter5 = new System.Windows.Forms.Label();
			this.lblSplitter1 = new System.Windows.Forms.Label();
			this.lblSplitter4 = new System.Windows.Forms.Label();
			this.lblSplitter3 = new System.Windows.Forms.Label();
			this.lblPlayerDescModel = new System.Windows.Forms.Label();
			this.lblPlayerHealthCurrentName = new System.Windows.Forms.Label();
			this.lblPlayerModelNameValue = new System.Windows.Forms.Label();
			this.txtPlayerPositionZ = new System.Windows.Forms.TextBox();
			this.btnPlayerRep = new System.Windows.Forms.Button();
			this.txtPlayerPositionY = new System.Windows.Forms.TextBox();
			this.lblPlayerHealthCurrentValue = new System.Windows.Forms.Label();
			this.lblPlayerPositionZValue = new System.Windows.Forms.Label();
			this.lblPlayerPositionZName = new System.Windows.Forms.Label();
			this.lblPlayerPositionYValue = new System.Windows.Forms.Label();
			this.lblPlayerDescHealth = new System.Windows.Forms.Label();
			this.lblPlayerPositionXValue = new System.Windows.Forms.Label();
			this.lblPlayerPositionYName = new System.Windows.Forms.Label();
			this.lblPlayerHealthMaxName = new System.Windows.Forms.Label();
			this.txtPlayerRepMax = new System.Windows.Forms.TextBox();
			this.lblPlayerHealthMaxValue = new System.Windows.Forms.Label();
			this.txtPlayerRepCurrent = new System.Windows.Forms.TextBox();
			this.btnPlayerPower = new System.Windows.Forms.Button();
			this.txtPlayerHealthMax = new System.Windows.Forms.TextBox();
			this.txtPlayerHealthCurrent = new System.Windows.Forms.TextBox();
			this.lblPlayerRepMaxName = new System.Windows.Forms.Label();
			this.btnPlayerHealth = new System.Windows.Forms.Button();
			this.txtPlayerPowerMax = new System.Windows.Forms.TextBox();
			this.lblPlayerRepMaxValue = new System.Windows.Forms.Label();
			this.lblPlayerRepCurrentValue = new System.Windows.Forms.Label();
			this.lblPlayerPowerCurrentName = new System.Windows.Forms.Label();
			this.lblPlayerPowerCurrentValue = new System.Windows.Forms.Label();
			this.txtPlayerPowerCurrent = new System.Windows.Forms.TextBox();
			this.lblPlayerPowerMaxName = new System.Windows.Forms.Label();
			this.lblPlayerRepCurrentName = new System.Windows.Forms.Label();
			this.lblPlayerPowerMaxValue = new System.Windows.Forms.Label();
			this.lblPlayerDescRep = new System.Windows.Forms.Label();
			this.lblPlayerPositionXName = new System.Windows.Forms.Label();
			this.txtPlayerPositionX = new System.Windows.Forms.TextBox();
			this.lblPlayerModelNameName = new System.Windows.Forms.Label();
			this.lblPlayerDescPosition = new System.Windows.Forms.Label();
			this.btnPlayerPosition = new System.Windows.Forms.Button();
			this.lblPlayerDescPower = new System.Windows.Forms.Label();
			this.lblSplitter2 = new System.Windows.Forms.Label();
			this.lblPlayerDescRotation = new System.Windows.Forms.Label();
			this.gbPlayerPositions = new System.Windows.Forms.GroupBox();
			this.lbPlayerPositions = new System.Windows.Forms.ListBox();
			this.btnPlayerPositions = new System.Windows.Forms.Button();
			this.gbGeneral = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.lblGeneralCanPressureName = new System.Windows.Forms.Label();
			this.lblGeneralMapName = new System.Windows.Forms.Label();
			this.lblGeneralMapValue = new System.Windows.Forms.Label();
			this.lblGeneralCanPressureValue = new System.Windows.Forms.Label();
			this.gbPedestrian = new System.Windows.Forms.GroupBox();
			this.tblPedestrianSelected = new System.Windows.Forms.TableLayoutPanel();
			this.btnPedestrianPosition = new System.Windows.Forms.Button();
			this.txtPedestrianPositionZ = new System.Windows.Forms.TextBox();
			this.txtPedestrianPositionY = new System.Windows.Forms.TextBox();
			this.txtPedestrianPositionX = new System.Windows.Forms.TextBox();
			this.lblPedestrianPositionZValue = new System.Windows.Forms.Label();
			this.lblPedestrianPositionZName = new System.Windows.Forms.Label();
			this.lblPedestrianPositionYValue = new System.Windows.Forms.Label();
			this.lblPedestrianPositionXValue = new System.Windows.Forms.Label();
			this.lblPedestrianPositionYName = new System.Windows.Forms.Label();
			this.lblPedestrianPositionXName = new System.Windows.Forms.Label();
			this.lblPedestrianPositionDesc = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.lblPedestrianSelected = new System.Windows.Forms.Label();
			this.cbPedestrianSelected = new System.Windows.Forms.ComboBox();
			this.lblPedestrianCountValue = new System.Windows.Forms.Label();
			this.lblPedestrianCountName = new System.Windows.Forms.Label();
			this.statusStrip.SuspendLayout();
			this.gbEnemy.SuspendLayout();
			this.tblEnemySelected.SuspendLayout();
			this.gbPlayer.SuspendLayout();
			this.tblPlayer.SuspendLayout();
			this.gbPlayerPositions.SuspendLayout();
			this.gbGeneral.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.gbPedestrian.SuspendLayout();
			this.tblPedestrianSelected.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip
			// 
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblAppStatusLabel,
            this.lblAppStatusValue,
            this.toolStripStatusLabelEmpty,
            this.btnSettings,
            this.btnAbout});
			this.statusStrip.Location = new System.Drawing.Point(0, 489);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(784, 22);
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
			// toolStripStatusLabelEmpty
			// 
			this.toolStripStatusLabelEmpty.Name = "toolStripStatusLabelEmpty";
			this.toolStripStatusLabelEmpty.Size = new System.Drawing.Size(414, 17);
			this.toolStripStatusLabelEmpty.Spring = true;
			// 
			// btnSettings
			// 
			this.btnSettings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.btnSettings.Image = global::GettingUpTrainer.Properties.Resources.icon_settings;
			this.btnSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnSettings.Name = "btnSettings";
			this.btnSettings.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnSettings.ShowDropDownArrow = false;
			this.btnSettings.Size = new System.Drawing.Size(69, 20);
			this.btnSettings.Text = "Settings";
			this.btnSettings.ToolTipText = "Settings";
			this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
			// 
			// btnAbout
			// 
			this.btnAbout.Image = global::GettingUpTrainer.Properties.Resources.icon_about;
			this.btnAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnAbout.Name = "btnAbout";
			this.btnAbout.ShowDropDownArrow = false;
			this.btnAbout.Size = new System.Drawing.Size(60, 20);
			this.btnAbout.Text = "About";
			this.btnAbout.ToolTipText = "About";
			this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
			// 
			// gbEnemy
			// 
			this.gbEnemy.Controls.Add(this.tblEnemySelected);
			this.gbEnemy.Controls.Add(this.lblEnemySeparator);
			this.gbEnemy.Controls.Add(this.lblEnemySelected);
			this.gbEnemy.Controls.Add(this.cbEnemySelected);
			this.gbEnemy.Controls.Add(this.lblEnemyCountValue);
			this.gbEnemy.Controls.Add(this.lblEnemyCountName);
			this.gbEnemy.Enabled = false;
			this.gbEnemy.Location = new System.Drawing.Point(397, 3);
			this.gbEnemy.Name = "gbEnemy";
			this.gbEnemy.Size = new System.Drawing.Size(381, 230);
			this.gbEnemy.TabIndex = 3;
			this.gbEnemy.TabStop = false;
			this.gbEnemy.Text = "Enemy";
			// 
			// tblEnemySelected
			// 
			this.tblEnemySelected.ColumnCount = 5;
			this.tblEnemySelected.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
			this.tblEnemySelected.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
			this.tblEnemySelected.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
			this.tblEnemySelected.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tblEnemySelected.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
			this.tblEnemySelected.Controls.Add(this.lblEnemyRotationYawValue, 2, 7);
			this.tblEnemySelected.Controls.Add(this.lblEnemyRotationYawName, 1, 7);
			this.tblEnemySelected.Controls.Add(this.lblEnemyRotationDesc, 0, 7);
			this.tblEnemySelected.Controls.Add(this.btnEnemyPosition, 4, 3);
			this.tblEnemySelected.Controls.Add(this.lblSplitter7, 0, 6);
			this.tblEnemySelected.Controls.Add(this.txtEnemyPositionZ, 3, 5);
			this.tblEnemySelected.Controls.Add(this.lblSplitter6, 0, 2);
			this.tblEnemySelected.Controls.Add(this.txtEnemyPositionY, 3, 4);
			this.tblEnemySelected.Controls.Add(this.lblEnemyHealthDesc, 0, 0);
			this.tblEnemySelected.Controls.Add(this.txtEnemyPositionX, 3, 3);
			this.tblEnemySelected.Controls.Add(this.lblEnemyHealthCurrentName, 1, 0);
			this.tblEnemySelected.Controls.Add(this.lblEnemyPositionZValue, 2, 5);
			this.tblEnemySelected.Controls.Add(this.lblEnemyPositionZName, 1, 5);
			this.tblEnemySelected.Controls.Add(this.lblEnemyPositionYValue, 2, 4);
			this.tblEnemySelected.Controls.Add(this.lblEnemyHealthMaxName, 1, 1);
			this.tblEnemySelected.Controls.Add(this.lblEnemyPositionXValue, 2, 3);
			this.tblEnemySelected.Controls.Add(this.lblEnemyPositionYName, 1, 4);
			this.tblEnemySelected.Controls.Add(this.lblEnemyHealthCurrentValue, 2, 0);
			this.tblEnemySelected.Controls.Add(this.lblEnemyHealthMaxValue, 2, 1);
			this.tblEnemySelected.Controls.Add(this.txtEnemyHealthCurrent, 3, 0);
			this.tblEnemySelected.Controls.Add(this.txtEnemyHealthMax, 3, 1);
			this.tblEnemySelected.Controls.Add(this.lblEnemyPositionXName, 1, 3);
			this.tblEnemySelected.Controls.Add(this.lblEnemyPositionDesc, 0, 3);
			this.tblEnemySelected.Controls.Add(this.btnEnemyHealth, 4, 0);
			this.tblEnemySelected.Location = new System.Drawing.Point(5, 52);
			this.tblEnemySelected.Name = "tblEnemySelected";
			this.tblEnemySelected.RowCount = 8;
			this.tblEnemySelected.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
			this.tblEnemySelected.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
			this.tblEnemySelected.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6F));
			this.tblEnemySelected.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
			this.tblEnemySelected.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
			this.tblEnemySelected.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
			this.tblEnemySelected.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6F));
			this.tblEnemySelected.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
			this.tblEnemySelected.Size = new System.Drawing.Size(370, 172);
			this.tblEnemySelected.TabIndex = 13;
			// 
			// lblEnemyRotationYawValue
			// 
			this.lblEnemyRotationYawValue.Location = new System.Drawing.Point(113, 142);
			this.lblEnemyRotationYawValue.Name = "lblEnemyRotationYawValue";
			this.lblEnemyRotationYawValue.Size = new System.Drawing.Size(100, 26);
			this.lblEnemyRotationYawValue.TabIndex = 34;
			this.lblEnemyRotationYawValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblEnemyRotationYawName
			// 
			this.lblEnemyRotationYawName.Location = new System.Drawing.Point(68, 142);
			this.lblEnemyRotationYawName.Name = "lblEnemyRotationYawName";
			this.lblEnemyRotationYawName.Size = new System.Drawing.Size(39, 26);
			this.lblEnemyRotationYawName.TabIndex = 8;
			this.lblEnemyRotationYawName.Text = "Yaw:";
			this.lblEnemyRotationYawName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblEnemyRotationDesc
			// 
			this.lblEnemyRotationDesc.Location = new System.Drawing.Point(3, 142);
			this.lblEnemyRotationDesc.Name = "lblEnemyRotationDesc";
			this.lblEnemyRotationDesc.Size = new System.Drawing.Size(59, 26);
			this.lblEnemyRotationDesc.TabIndex = 8;
			this.lblEnemyRotationDesc.Text = "Rotation";
			this.lblEnemyRotationDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnEnemyPosition
			// 
			this.btnEnemyPosition.Location = new System.Drawing.Point(319, 61);
			this.btnEnemyPosition.Name = "btnEnemyPosition";
			this.tblEnemySelected.SetRowSpan(this.btnEnemyPosition, 3);
			this.btnEnemyPosition.Size = new System.Drawing.Size(49, 72);
			this.btnEnemyPosition.TabIndex = 23;
			this.btnEnemyPosition.Text = "Set";
			this.btnEnemyPosition.UseVisualStyleBackColor = true;
			this.btnEnemyPosition.Click += new System.EventHandler(this.btnEnemyPosition_Click);
			// 
			// lblSplitter7
			// 
			this.lblSplitter7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.tblEnemySelected.SetColumnSpan(this.lblSplitter7, 5);
			this.lblSplitter7.Location = new System.Drawing.Point(3, 138);
			this.lblSplitter7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.lblSplitter7.Name = "lblSplitter7";
			this.lblSplitter7.Size = new System.Drawing.Size(367, 2);
			this.lblSplitter7.TabIndex = 33;
			// 
			// txtEnemyPositionZ
			// 
			this.txtEnemyPositionZ.Location = new System.Drawing.Point(219, 113);
			this.txtEnemyPositionZ.Name = "txtEnemyPositionZ";
			this.txtEnemyPositionZ.Size = new System.Drawing.Size(94, 20);
			this.txtEnemyPositionZ.TabIndex = 20;
			// 
			// lblSplitter6
			// 
			this.lblSplitter6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.tblEnemySelected.SetColumnSpan(this.lblSplitter6, 5);
			this.lblSplitter6.Location = new System.Drawing.Point(3, 54);
			this.lblSplitter6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.lblSplitter6.Name = "lblSplitter6";
			this.lblSplitter6.Size = new System.Drawing.Size(367, 2);
			this.lblSplitter6.TabIndex = 32;
			// 
			// txtEnemyPositionY
			// 
			this.txtEnemyPositionY.Location = new System.Drawing.Point(219, 87);
			this.txtEnemyPositionY.Name = "txtEnemyPositionY";
			this.txtEnemyPositionY.Size = new System.Drawing.Size(94, 20);
			this.txtEnemyPositionY.TabIndex = 21;
			// 
			// lblEnemyHealthDesc
			// 
			this.lblEnemyHealthDesc.Location = new System.Drawing.Point(3, 0);
			this.lblEnemyHealthDesc.Name = "lblEnemyHealthDesc";
			this.tblEnemySelected.SetRowSpan(this.lblEnemyHealthDesc, 2);
			this.lblEnemyHealthDesc.Size = new System.Drawing.Size(59, 52);
			this.lblEnemyHealthDesc.TabIndex = 4;
			this.lblEnemyHealthDesc.Text = "Health";
			this.lblEnemyHealthDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtEnemyPositionX
			// 
			this.txtEnemyPositionX.Location = new System.Drawing.Point(219, 61);
			this.txtEnemyPositionX.Name = "txtEnemyPositionX";
			this.txtEnemyPositionX.Size = new System.Drawing.Size(94, 20);
			this.txtEnemyPositionX.TabIndex = 22;
			// 
			// lblEnemyHealthCurrentName
			// 
			this.lblEnemyHealthCurrentName.Location = new System.Drawing.Point(68, 0);
			this.lblEnemyHealthCurrentName.Name = "lblEnemyHealthCurrentName";
			this.lblEnemyHealthCurrentName.Size = new System.Drawing.Size(39, 26);
			this.lblEnemyHealthCurrentName.TabIndex = 8;
			this.lblEnemyHealthCurrentName.Text = "Cur:";
			this.lblEnemyHealthCurrentName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblEnemyPositionZValue
			// 
			this.lblEnemyPositionZValue.Location = new System.Drawing.Point(113, 110);
			this.lblEnemyPositionZValue.Name = "lblEnemyPositionZValue";
			this.lblEnemyPositionZValue.Size = new System.Drawing.Size(100, 26);
			this.lblEnemyPositionZValue.TabIndex = 16;
			this.lblEnemyPositionZValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblEnemyPositionZName
			// 
			this.lblEnemyPositionZName.Location = new System.Drawing.Point(68, 110);
			this.lblEnemyPositionZName.Name = "lblEnemyPositionZName";
			this.lblEnemyPositionZName.Size = new System.Drawing.Size(39, 26);
			this.lblEnemyPositionZName.TabIndex = 14;
			this.lblEnemyPositionZName.Text = "Z:";
			this.lblEnemyPositionZName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblEnemyPositionYValue
			// 
			this.lblEnemyPositionYValue.Location = new System.Drawing.Point(113, 84);
			this.lblEnemyPositionYValue.Name = "lblEnemyPositionYValue";
			this.lblEnemyPositionYValue.Size = new System.Drawing.Size(100, 26);
			this.lblEnemyPositionYValue.TabIndex = 17;
			this.lblEnemyPositionYValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblEnemyHealthMaxName
			// 
			this.lblEnemyHealthMaxName.Location = new System.Drawing.Point(68, 26);
			this.lblEnemyHealthMaxName.Name = "lblEnemyHealthMaxName";
			this.lblEnemyHealthMaxName.Size = new System.Drawing.Size(39, 26);
			this.lblEnemyHealthMaxName.TabIndex = 5;
			this.lblEnemyHealthMaxName.Text = "Max:";
			this.lblEnemyHealthMaxName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblEnemyPositionXValue
			// 
			this.lblEnemyPositionXValue.Location = new System.Drawing.Point(113, 58);
			this.lblEnemyPositionXValue.Name = "lblEnemyPositionXValue";
			this.lblEnemyPositionXValue.Size = new System.Drawing.Size(100, 26);
			this.lblEnemyPositionXValue.TabIndex = 18;
			this.lblEnemyPositionXValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblEnemyPositionYName
			// 
			this.lblEnemyPositionYName.Location = new System.Drawing.Point(68, 84);
			this.lblEnemyPositionYName.Name = "lblEnemyPositionYName";
			this.lblEnemyPositionYName.Size = new System.Drawing.Size(39, 26);
			this.lblEnemyPositionYName.TabIndex = 15;
			this.lblEnemyPositionYName.Text = "Y:";
			this.lblEnemyPositionYName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblEnemyHealthCurrentValue
			// 
			this.lblEnemyHealthCurrentValue.Location = new System.Drawing.Point(113, 0);
			this.lblEnemyHealthCurrentValue.Name = "lblEnemyHealthCurrentValue";
			this.lblEnemyHealthCurrentValue.Size = new System.Drawing.Size(100, 26);
			this.lblEnemyHealthCurrentValue.TabIndex = 7;
			this.lblEnemyHealthCurrentValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblEnemyHealthMaxValue
			// 
			this.lblEnemyHealthMaxValue.Location = new System.Drawing.Point(113, 26);
			this.lblEnemyHealthMaxValue.Name = "lblEnemyHealthMaxValue";
			this.lblEnemyHealthMaxValue.Size = new System.Drawing.Size(100, 26);
			this.lblEnemyHealthMaxValue.TabIndex = 6;
			this.lblEnemyHealthMaxValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtEnemyHealthCurrent
			// 
			this.txtEnemyHealthCurrent.Location = new System.Drawing.Point(219, 3);
			this.txtEnemyHealthCurrent.Name = "txtEnemyHealthCurrent";
			this.txtEnemyHealthCurrent.Size = new System.Drawing.Size(94, 20);
			this.txtEnemyHealthCurrent.TabIndex = 10;
			// 
			// txtEnemyHealthMax
			// 
			this.txtEnemyHealthMax.Location = new System.Drawing.Point(219, 29);
			this.txtEnemyHealthMax.Name = "txtEnemyHealthMax";
			this.txtEnemyHealthMax.Size = new System.Drawing.Size(94, 20);
			this.txtEnemyHealthMax.TabIndex = 9;
			// 
			// lblEnemyPositionXName
			// 
			this.lblEnemyPositionXName.Location = new System.Drawing.Point(68, 58);
			this.lblEnemyPositionXName.Name = "lblEnemyPositionXName";
			this.lblEnemyPositionXName.Size = new System.Drawing.Size(39, 26);
			this.lblEnemyPositionXName.TabIndex = 19;
			this.lblEnemyPositionXName.Text = "X:";
			this.lblEnemyPositionXName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblEnemyPositionDesc
			// 
			this.lblEnemyPositionDesc.Location = new System.Drawing.Point(3, 58);
			this.lblEnemyPositionDesc.Name = "lblEnemyPositionDesc";
			this.tblEnemySelected.SetRowSpan(this.lblEnemyPositionDesc, 3);
			this.lblEnemyPositionDesc.Size = new System.Drawing.Size(59, 76);
			this.lblEnemyPositionDesc.TabIndex = 13;
			this.lblEnemyPositionDesc.Text = "Position";
			this.lblEnemyPositionDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnEnemyHealth
			// 
			this.btnEnemyHealth.Location = new System.Drawing.Point(319, 3);
			this.btnEnemyHealth.Name = "btnEnemyHealth";
			this.tblEnemySelected.SetRowSpan(this.btnEnemyHealth, 2);
			this.btnEnemyHealth.Size = new System.Drawing.Size(49, 46);
			this.btnEnemyHealth.TabIndex = 11;
			this.btnEnemyHealth.Text = "Set";
			this.btnEnemyHealth.UseVisualStyleBackColor = true;
			this.btnEnemyHealth.Click += new System.EventHandler(this.btnEnemyHealth_Click);
			// 
			// lblEnemySeparator
			// 
			this.lblEnemySeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblEnemySeparator.Location = new System.Drawing.Point(8, 47);
			this.lblEnemySeparator.Name = "lblEnemySeparator";
			this.lblEnemySeparator.Size = new System.Drawing.Size(367, 2);
			this.lblEnemySeparator.TabIndex = 12;
			// 
			// lblEnemySelected
			// 
			this.lblEnemySelected.AutoSize = true;
			this.lblEnemySelected.Location = new System.Drawing.Point(8, 21);
			this.lblEnemySelected.Name = "lblEnemySelected";
			this.lblEnemySelected.Size = new System.Drawing.Size(52, 13);
			this.lblEnemySelected.TabIndex = 3;
			this.lblEnemySelected.Text = "Selected:";
			// 
			// cbEnemySelected
			// 
			this.cbEnemySelected.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbEnemySelected.FormattingEnabled = true;
			this.cbEnemySelected.Location = new System.Drawing.Point(72, 19);
			this.cbEnemySelected.Name = "cbEnemySelected";
			this.cbEnemySelected.Size = new System.Drawing.Size(217, 21);
			this.cbEnemySelected.TabIndex = 2;
			this.cbEnemySelected.SelectedIndexChanged += new System.EventHandler(this.cbEnemySelected_SelectedIndexChanged);
			// 
			// lblEnemyCountValue
			// 
			this.lblEnemyCountValue.Location = new System.Drawing.Point(339, 22);
			this.lblEnemyCountValue.Name = "lblEnemyCountValue";
			this.lblEnemyCountValue.Size = new System.Drawing.Size(31, 13);
			this.lblEnemyCountValue.TabIndex = 1;
			// 
			// lblEnemyCountName
			// 
			this.lblEnemyCountName.AutoSize = true;
			this.lblEnemyCountName.Location = new System.Drawing.Point(295, 22);
			this.lblEnemyCountName.Name = "lblEnemyCountName";
			this.lblEnemyCountName.Size = new System.Drawing.Size(38, 13);
			this.lblEnemyCountName.TabIndex = 0;
			this.lblEnemyCountName.Text = "Count:";
			// 
			// gbPlayer
			// 
			this.gbPlayer.Controls.Add(this.tblPlayer);
			this.gbPlayer.Enabled = false;
			this.gbPlayer.Location = new System.Drawing.Point(10, 3);
			this.gbPlayer.Name = "gbPlayer";
			this.gbPlayer.Size = new System.Drawing.Size(381, 340);
			this.gbPlayer.TabIndex = 4;
			this.gbPlayer.TabStop = false;
			this.gbPlayer.Text = "Player";
			// 
			// tblPlayer
			// 
			this.tblPlayer.ColumnCount = 5;
			this.tblPlayer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
			this.tblPlayer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
			this.tblPlayer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
			this.tblPlayer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tblPlayer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
			this.tblPlayer.Controls.Add(this.lblPlayerRotationYawValue, 2, 15);
			this.tblPlayer.Controls.Add(this.lblPlayerRotationYawName, 1, 15);
			this.tblPlayer.Controls.Add(this.lblSplitter5, 0, 14);
			this.tblPlayer.Controls.Add(this.lblSplitter1, 0, 1);
			this.tblPlayer.Controls.Add(this.lblSplitter4, 0, 10);
			this.tblPlayer.Controls.Add(this.lblSplitter3, 0, 7);
			this.tblPlayer.Controls.Add(this.lblPlayerDescModel, 0, 0);
			this.tblPlayer.Controls.Add(this.lblPlayerHealthCurrentName, 1, 2);
			this.tblPlayer.Controls.Add(this.lblPlayerModelNameValue, 2, 0);
			this.tblPlayer.Controls.Add(this.txtPlayerPositionZ, 3, 13);
			this.tblPlayer.Controls.Add(this.btnPlayerRep, 4, 8);
			this.tblPlayer.Controls.Add(this.txtPlayerPositionY, 3, 12);
			this.tblPlayer.Controls.Add(this.lblPlayerHealthCurrentValue, 2, 2);
			this.tblPlayer.Controls.Add(this.lblPlayerPositionZValue, 2, 13);
			this.tblPlayer.Controls.Add(this.lblPlayerPositionZName, 1, 13);
			this.tblPlayer.Controls.Add(this.lblPlayerPositionYValue, 2, 12);
			this.tblPlayer.Controls.Add(this.lblPlayerDescHealth, 0, 2);
			this.tblPlayer.Controls.Add(this.lblPlayerPositionXValue, 2, 11);
			this.tblPlayer.Controls.Add(this.lblPlayerPositionYName, 1, 12);
			this.tblPlayer.Controls.Add(this.lblPlayerHealthMaxName, 1, 3);
			this.tblPlayer.Controls.Add(this.txtPlayerRepMax, 3, 9);
			this.tblPlayer.Controls.Add(this.lblPlayerHealthMaxValue, 2, 3);
			this.tblPlayer.Controls.Add(this.txtPlayerRepCurrent, 3, 8);
			this.tblPlayer.Controls.Add(this.btnPlayerPower, 4, 5);
			this.tblPlayer.Controls.Add(this.txtPlayerHealthMax, 3, 3);
			this.tblPlayer.Controls.Add(this.txtPlayerHealthCurrent, 3, 2);
			this.tblPlayer.Controls.Add(this.lblPlayerRepMaxName, 1, 9);
			this.tblPlayer.Controls.Add(this.btnPlayerHealth, 4, 2);
			this.tblPlayer.Controls.Add(this.txtPlayerPowerMax, 3, 6);
			this.tblPlayer.Controls.Add(this.lblPlayerRepMaxValue, 2, 9);
			this.tblPlayer.Controls.Add(this.lblPlayerRepCurrentValue, 2, 8);
			this.tblPlayer.Controls.Add(this.lblPlayerPowerCurrentName, 1, 5);
			this.tblPlayer.Controls.Add(this.lblPlayerPowerCurrentValue, 2, 5);
			this.tblPlayer.Controls.Add(this.txtPlayerPowerCurrent, 3, 5);
			this.tblPlayer.Controls.Add(this.lblPlayerPowerMaxName, 1, 6);
			this.tblPlayer.Controls.Add(this.lblPlayerRepCurrentName, 1, 8);
			this.tblPlayer.Controls.Add(this.lblPlayerPowerMaxValue, 2, 6);
			this.tblPlayer.Controls.Add(this.lblPlayerDescRep, 0, 8);
			this.tblPlayer.Controls.Add(this.lblPlayerPositionXName, 1, 11);
			this.tblPlayer.Controls.Add(this.txtPlayerPositionX, 3, 11);
			this.tblPlayer.Controls.Add(this.lblPlayerModelNameName, 1, 0);
			this.tblPlayer.Controls.Add(this.lblPlayerDescPosition, 0, 11);
			this.tblPlayer.Controls.Add(this.btnPlayerPosition, 4, 11);
			this.tblPlayer.Controls.Add(this.lblPlayerDescPower, 0, 5);
			this.tblPlayer.Controls.Add(this.lblSplitter2, 0, 4);
			this.tblPlayer.Controls.Add(this.lblPlayerDescRotation, 0, 15);
			this.tblPlayer.Location = new System.Drawing.Point(6, 15);
			this.tblPlayer.Name = "tblPlayer";
			this.tblPlayer.RowCount = 16;
			this.tblPlayer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
			this.tblPlayer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6F));
			this.tblPlayer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
			this.tblPlayer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
			this.tblPlayer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6F));
			this.tblPlayer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
			this.tblPlayer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
			this.tblPlayer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6F));
			this.tblPlayer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
			this.tblPlayer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
			this.tblPlayer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6F));
			this.tblPlayer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
			this.tblPlayer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
			this.tblPlayer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
			this.tblPlayer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6F));
			this.tblPlayer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
			this.tblPlayer.Size = new System.Drawing.Size(370, 320);
			this.tblPlayer.TabIndex = 28;
			// 
			// lblPlayerRotationYawValue
			// 
			this.lblPlayerRotationYawValue.Location = new System.Drawing.Point(113, 290);
			this.lblPlayerRotationYawValue.Name = "lblPlayerRotationYawValue";
			this.lblPlayerRotationYawValue.Size = new System.Drawing.Size(100, 26);
			this.lblPlayerRotationYawValue.TabIndex = 5;
			this.lblPlayerRotationYawValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPlayerRotationYawName
			// 
			this.lblPlayerRotationYawName.Location = new System.Drawing.Point(68, 290);
			this.lblPlayerRotationYawName.Name = "lblPlayerRotationYawName";
			this.lblPlayerRotationYawName.Size = new System.Drawing.Size(39, 26);
			this.lblPlayerRotationYawName.TabIndex = 5;
			this.lblPlayerRotationYawName.Text = "Yaw:";
			this.lblPlayerRotationYawName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblSplitter5
			// 
			this.lblSplitter5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.tblPlayer.SetColumnSpan(this.lblSplitter5, 5);
			this.lblSplitter5.Location = new System.Drawing.Point(3, 286);
			this.lblSplitter5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.lblSplitter5.Name = "lblSplitter5";
			this.lblSplitter5.Size = new System.Drawing.Size(367, 2);
			this.lblSplitter5.TabIndex = 31;
			// 
			// lblSplitter1
			// 
			this.lblSplitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.tblPlayer.SetColumnSpan(this.lblSplitter1, 5);
			this.lblSplitter1.Location = new System.Drawing.Point(3, 28);
			this.lblSplitter1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.lblSplitter1.Name = "lblSplitter1";
			this.lblSplitter1.Size = new System.Drawing.Size(367, 2);
			this.lblSplitter1.TabIndex = 31;
			// 
			// lblSplitter4
			// 
			this.lblSplitter4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.tblPlayer.SetColumnSpan(this.lblSplitter4, 5);
			this.lblSplitter4.Location = new System.Drawing.Point(3, 202);
			this.lblSplitter4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.lblSplitter4.Name = "lblSplitter4";
			this.lblSplitter4.Size = new System.Drawing.Size(367, 2);
			this.lblSplitter4.TabIndex = 30;
			// 
			// lblSplitter3
			// 
			this.lblSplitter3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.tblPlayer.SetColumnSpan(this.lblSplitter3, 5);
			this.lblSplitter3.Location = new System.Drawing.Point(3, 144);
			this.lblSplitter3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.lblSplitter3.Name = "lblSplitter3";
			this.lblSplitter3.Size = new System.Drawing.Size(367, 2);
			this.lblSplitter3.TabIndex = 30;
			// 
			// lblPlayerDescModel
			// 
			this.lblPlayerDescModel.Location = new System.Drawing.Point(3, 0);
			this.lblPlayerDescModel.Name = "lblPlayerDescModel";
			this.lblPlayerDescModel.Size = new System.Drawing.Size(59, 25);
			this.lblPlayerDescModel.TabIndex = 28;
			this.lblPlayerDescModel.Text = "Model";
			this.lblPlayerDescModel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPlayerHealthCurrentName
			// 
			this.lblPlayerHealthCurrentName.Location = new System.Drawing.Point(68, 32);
			this.lblPlayerHealthCurrentName.Name = "lblPlayerHealthCurrentName";
			this.lblPlayerHealthCurrentName.Size = new System.Drawing.Size(39, 26);
			this.lblPlayerHealthCurrentName.TabIndex = 1;
			this.lblPlayerHealthCurrentName.Text = "Cur:";
			this.lblPlayerHealthCurrentName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPlayerModelNameValue
			// 
			this.lblPlayerModelNameValue.AutoEllipsis = true;
			this.tblPlayer.SetColumnSpan(this.lblPlayerModelNameValue, 2);
			this.lblPlayerModelNameValue.Location = new System.Drawing.Point(113, 0);
			this.lblPlayerModelNameValue.Name = "lblPlayerModelNameValue";
			this.lblPlayerModelNameValue.Size = new System.Drawing.Size(200, 26);
			this.lblPlayerModelNameValue.TabIndex = 27;
			this.lblPlayerModelNameValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtPlayerPositionZ
			// 
			this.txtPlayerPositionZ.Location = new System.Drawing.Point(219, 261);
			this.txtPlayerPositionZ.Name = "txtPlayerPositionZ";
			this.txtPlayerPositionZ.Size = new System.Drawing.Size(94, 20);
			this.txtPlayerPositionZ.TabIndex = 2;
			// 
			// btnPlayerRep
			// 
			this.btnPlayerRep.Location = new System.Drawing.Point(319, 151);
			this.btnPlayerRep.Name = "btnPlayerRep";
			this.tblPlayer.SetRowSpan(this.btnPlayerRep, 2);
			this.btnPlayerRep.Size = new System.Drawing.Size(49, 46);
			this.btnPlayerRep.TabIndex = 3;
			this.btnPlayerRep.Text = "Set";
			this.btnPlayerRep.UseVisualStyleBackColor = true;
			this.btnPlayerRep.Click += new System.EventHandler(this.btnPlayerRep_Click);
			// 
			// txtPlayerPositionY
			// 
			this.txtPlayerPositionY.Location = new System.Drawing.Point(219, 235);
			this.txtPlayerPositionY.Name = "txtPlayerPositionY";
			this.txtPlayerPositionY.Size = new System.Drawing.Size(94, 20);
			this.txtPlayerPositionY.TabIndex = 2;
			// 
			// lblPlayerHealthCurrentValue
			// 
			this.lblPlayerHealthCurrentValue.Location = new System.Drawing.Point(113, 32);
			this.lblPlayerHealthCurrentValue.Name = "lblPlayerHealthCurrentValue";
			this.lblPlayerHealthCurrentValue.Size = new System.Drawing.Size(100, 26);
			this.lblPlayerHealthCurrentValue.TabIndex = 1;
			this.lblPlayerHealthCurrentValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPlayerPositionZValue
			// 
			this.lblPlayerPositionZValue.Location = new System.Drawing.Point(113, 258);
			this.lblPlayerPositionZValue.Name = "lblPlayerPositionZValue";
			this.lblPlayerPositionZValue.Size = new System.Drawing.Size(100, 26);
			this.lblPlayerPositionZValue.TabIndex = 1;
			this.lblPlayerPositionZValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPlayerPositionZName
			// 
			this.lblPlayerPositionZName.Location = new System.Drawing.Point(68, 258);
			this.lblPlayerPositionZName.Name = "lblPlayerPositionZName";
			this.lblPlayerPositionZName.Size = new System.Drawing.Size(39, 26);
			this.lblPlayerPositionZName.TabIndex = 1;
			this.lblPlayerPositionZName.Text = "Z:";
			this.lblPlayerPositionZName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPlayerPositionYValue
			// 
			this.lblPlayerPositionYValue.Location = new System.Drawing.Point(113, 232);
			this.lblPlayerPositionYValue.Name = "lblPlayerPositionYValue";
			this.lblPlayerPositionYValue.Size = new System.Drawing.Size(100, 26);
			this.lblPlayerPositionYValue.TabIndex = 1;
			this.lblPlayerPositionYValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPlayerDescHealth
			// 
			this.lblPlayerDescHealth.Location = new System.Drawing.Point(3, 32);
			this.lblPlayerDescHealth.Name = "lblPlayerDescHealth";
			this.tblPlayer.SetRowSpan(this.lblPlayerDescHealth, 2);
			this.lblPlayerDescHealth.Size = new System.Drawing.Size(59, 52);
			this.lblPlayerDescHealth.TabIndex = 0;
			this.lblPlayerDescHealth.Text = "Health";
			this.lblPlayerDescHealth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPlayerPositionXValue
			// 
			this.lblPlayerPositionXValue.Location = new System.Drawing.Point(113, 206);
			this.lblPlayerPositionXValue.Name = "lblPlayerPositionXValue";
			this.lblPlayerPositionXValue.Size = new System.Drawing.Size(100, 26);
			this.lblPlayerPositionXValue.TabIndex = 1;
			this.lblPlayerPositionXValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPlayerPositionYName
			// 
			this.lblPlayerPositionYName.Location = new System.Drawing.Point(68, 232);
			this.lblPlayerPositionYName.Name = "lblPlayerPositionYName";
			this.lblPlayerPositionYName.Size = new System.Drawing.Size(39, 26);
			this.lblPlayerPositionYName.TabIndex = 1;
			this.lblPlayerPositionYName.Text = "Y:";
			this.lblPlayerPositionYName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPlayerHealthMaxName
			// 
			this.lblPlayerHealthMaxName.Location = new System.Drawing.Point(68, 58);
			this.lblPlayerHealthMaxName.Name = "lblPlayerHealthMaxName";
			this.lblPlayerHealthMaxName.Size = new System.Drawing.Size(39, 26);
			this.lblPlayerHealthMaxName.TabIndex = 1;
			this.lblPlayerHealthMaxName.Text = "Max:";
			this.lblPlayerHealthMaxName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtPlayerRepMax
			// 
			this.txtPlayerRepMax.Location = new System.Drawing.Point(219, 177);
			this.txtPlayerRepMax.Name = "txtPlayerRepMax";
			this.txtPlayerRepMax.Size = new System.Drawing.Size(94, 20);
			this.txtPlayerRepMax.TabIndex = 2;
			// 
			// lblPlayerHealthMaxValue
			// 
			this.lblPlayerHealthMaxValue.Location = new System.Drawing.Point(113, 58);
			this.lblPlayerHealthMaxValue.Name = "lblPlayerHealthMaxValue";
			this.lblPlayerHealthMaxValue.Size = new System.Drawing.Size(100, 26);
			this.lblPlayerHealthMaxValue.TabIndex = 1;
			this.lblPlayerHealthMaxValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtPlayerRepCurrent
			// 
			this.txtPlayerRepCurrent.Location = new System.Drawing.Point(219, 151);
			this.txtPlayerRepCurrent.Name = "txtPlayerRepCurrent";
			this.txtPlayerRepCurrent.Size = new System.Drawing.Size(94, 20);
			this.txtPlayerRepCurrent.TabIndex = 2;
			// 
			// btnPlayerPower
			// 
			this.btnPlayerPower.Location = new System.Drawing.Point(319, 93);
			this.btnPlayerPower.Name = "btnPlayerPower";
			this.tblPlayer.SetRowSpan(this.btnPlayerPower, 2);
			this.btnPlayerPower.Size = new System.Drawing.Size(49, 46);
			this.btnPlayerPower.TabIndex = 3;
			this.btnPlayerPower.Text = "Set";
			this.btnPlayerPower.UseVisualStyleBackColor = true;
			this.btnPlayerPower.Click += new System.EventHandler(this.btnPlayerPower_Click);
			// 
			// txtPlayerHealthMax
			// 
			this.txtPlayerHealthMax.Location = new System.Drawing.Point(219, 61);
			this.txtPlayerHealthMax.Name = "txtPlayerHealthMax";
			this.txtPlayerHealthMax.Size = new System.Drawing.Size(94, 20);
			this.txtPlayerHealthMax.TabIndex = 2;
			// 
			// txtPlayerHealthCurrent
			// 
			this.txtPlayerHealthCurrent.Location = new System.Drawing.Point(219, 35);
			this.txtPlayerHealthCurrent.Name = "txtPlayerHealthCurrent";
			this.txtPlayerHealthCurrent.Size = new System.Drawing.Size(94, 20);
			this.txtPlayerHealthCurrent.TabIndex = 2;
			// 
			// lblPlayerRepMaxName
			// 
			this.lblPlayerRepMaxName.Location = new System.Drawing.Point(68, 174);
			this.lblPlayerRepMaxName.Name = "lblPlayerRepMaxName";
			this.lblPlayerRepMaxName.Size = new System.Drawing.Size(39, 26);
			this.lblPlayerRepMaxName.TabIndex = 1;
			this.lblPlayerRepMaxName.Text = "Max:";
			this.lblPlayerRepMaxName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnPlayerHealth
			// 
			this.btnPlayerHealth.Location = new System.Drawing.Point(319, 35);
			this.btnPlayerHealth.Name = "btnPlayerHealth";
			this.tblPlayer.SetRowSpan(this.btnPlayerHealth, 2);
			this.btnPlayerHealth.Size = new System.Drawing.Size(49, 46);
			this.btnPlayerHealth.TabIndex = 3;
			this.btnPlayerHealth.Text = "Set";
			this.btnPlayerHealth.UseVisualStyleBackColor = true;
			this.btnPlayerHealth.Click += new System.EventHandler(this.btnPlayerHealth_Click);
			// 
			// txtPlayerPowerMax
			// 
			this.txtPlayerPowerMax.Location = new System.Drawing.Point(219, 119);
			this.txtPlayerPowerMax.Name = "txtPlayerPowerMax";
			this.txtPlayerPowerMax.Size = new System.Drawing.Size(94, 20);
			this.txtPlayerPowerMax.TabIndex = 2;
			// 
			// lblPlayerRepMaxValue
			// 
			this.lblPlayerRepMaxValue.Location = new System.Drawing.Point(113, 174);
			this.lblPlayerRepMaxValue.Name = "lblPlayerRepMaxValue";
			this.lblPlayerRepMaxValue.Size = new System.Drawing.Size(100, 26);
			this.lblPlayerRepMaxValue.TabIndex = 1;
			this.lblPlayerRepMaxValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPlayerRepCurrentValue
			// 
			this.lblPlayerRepCurrentValue.Location = new System.Drawing.Point(113, 148);
			this.lblPlayerRepCurrentValue.Name = "lblPlayerRepCurrentValue";
			this.lblPlayerRepCurrentValue.Size = new System.Drawing.Size(100, 26);
			this.lblPlayerRepCurrentValue.TabIndex = 1;
			this.lblPlayerRepCurrentValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPlayerPowerCurrentName
			// 
			this.lblPlayerPowerCurrentName.Location = new System.Drawing.Point(68, 90);
			this.lblPlayerPowerCurrentName.Name = "lblPlayerPowerCurrentName";
			this.lblPlayerPowerCurrentName.Size = new System.Drawing.Size(39, 26);
			this.lblPlayerPowerCurrentName.TabIndex = 1;
			this.lblPlayerPowerCurrentName.Text = "Cur:";
			this.lblPlayerPowerCurrentName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPlayerPowerCurrentValue
			// 
			this.lblPlayerPowerCurrentValue.Location = new System.Drawing.Point(113, 90);
			this.lblPlayerPowerCurrentValue.Name = "lblPlayerPowerCurrentValue";
			this.lblPlayerPowerCurrentValue.Size = new System.Drawing.Size(100, 26);
			this.lblPlayerPowerCurrentValue.TabIndex = 1;
			this.lblPlayerPowerCurrentValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtPlayerPowerCurrent
			// 
			this.txtPlayerPowerCurrent.Location = new System.Drawing.Point(219, 93);
			this.txtPlayerPowerCurrent.Name = "txtPlayerPowerCurrent";
			this.txtPlayerPowerCurrent.Size = new System.Drawing.Size(94, 20);
			this.txtPlayerPowerCurrent.TabIndex = 2;
			// 
			// lblPlayerPowerMaxName
			// 
			this.lblPlayerPowerMaxName.Location = new System.Drawing.Point(68, 116);
			this.lblPlayerPowerMaxName.Name = "lblPlayerPowerMaxName";
			this.lblPlayerPowerMaxName.Size = new System.Drawing.Size(39, 26);
			this.lblPlayerPowerMaxName.TabIndex = 1;
			this.lblPlayerPowerMaxName.Text = "Max:";
			this.lblPlayerPowerMaxName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPlayerRepCurrentName
			// 
			this.lblPlayerRepCurrentName.Location = new System.Drawing.Point(68, 148);
			this.lblPlayerRepCurrentName.Name = "lblPlayerRepCurrentName";
			this.lblPlayerRepCurrentName.Size = new System.Drawing.Size(39, 26);
			this.lblPlayerRepCurrentName.TabIndex = 1;
			this.lblPlayerRepCurrentName.Text = "Cur:";
			this.lblPlayerRepCurrentName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPlayerPowerMaxValue
			// 
			this.lblPlayerPowerMaxValue.Location = new System.Drawing.Point(113, 116);
			this.lblPlayerPowerMaxValue.Name = "lblPlayerPowerMaxValue";
			this.lblPlayerPowerMaxValue.Size = new System.Drawing.Size(100, 26);
			this.lblPlayerPowerMaxValue.TabIndex = 1;
			this.lblPlayerPowerMaxValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPlayerDescRep
			// 
			this.lblPlayerDescRep.Location = new System.Drawing.Point(3, 148);
			this.lblPlayerDescRep.Name = "lblPlayerDescRep";
			this.tblPlayer.SetRowSpan(this.lblPlayerDescRep, 2);
			this.lblPlayerDescRep.Size = new System.Drawing.Size(59, 52);
			this.lblPlayerDescRep.TabIndex = 0;
			this.lblPlayerDescRep.Text = "Rep";
			this.lblPlayerDescRep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPlayerPositionXName
			// 
			this.lblPlayerPositionXName.Location = new System.Drawing.Point(68, 206);
			this.lblPlayerPositionXName.Name = "lblPlayerPositionXName";
			this.lblPlayerPositionXName.Size = new System.Drawing.Size(39, 26);
			this.lblPlayerPositionXName.TabIndex = 1;
			this.lblPlayerPositionXName.Text = "X:";
			this.lblPlayerPositionXName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtPlayerPositionX
			// 
			this.txtPlayerPositionX.Location = new System.Drawing.Point(219, 209);
			this.txtPlayerPositionX.Name = "txtPlayerPositionX";
			this.txtPlayerPositionX.Size = new System.Drawing.Size(94, 20);
			this.txtPlayerPositionX.TabIndex = 2;
			// 
			// lblPlayerModelNameName
			// 
			this.lblPlayerModelNameName.Location = new System.Drawing.Point(68, 0);
			this.lblPlayerModelNameName.Name = "lblPlayerModelNameName";
			this.lblPlayerModelNameName.Size = new System.Drawing.Size(39, 25);
			this.lblPlayerModelNameName.TabIndex = 26;
			this.lblPlayerModelNameName.Text = "Name:";
			this.lblPlayerModelNameName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPlayerDescPosition
			// 
			this.lblPlayerDescPosition.Location = new System.Drawing.Point(3, 206);
			this.lblPlayerDescPosition.Name = "lblPlayerDescPosition";
			this.tblPlayer.SetRowSpan(this.lblPlayerDescPosition, 3);
			this.lblPlayerDescPosition.Size = new System.Drawing.Size(59, 78);
			this.lblPlayerDescPosition.TabIndex = 0;
			this.lblPlayerDescPosition.Text = "Position";
			this.lblPlayerDescPosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnPlayerPosition
			// 
			this.btnPlayerPosition.Location = new System.Drawing.Point(319, 209);
			this.btnPlayerPosition.Name = "btnPlayerPosition";
			this.tblPlayer.SetRowSpan(this.btnPlayerPosition, 3);
			this.btnPlayerPosition.Size = new System.Drawing.Size(49, 72);
			this.btnPlayerPosition.TabIndex = 3;
			this.btnPlayerPosition.Text = "Set";
			this.btnPlayerPosition.UseVisualStyleBackColor = true;
			this.btnPlayerPosition.Click += new System.EventHandler(this.btnPlayerPosition_Click);
			// 
			// lblPlayerDescPower
			// 
			this.lblPlayerDescPower.Location = new System.Drawing.Point(3, 90);
			this.lblPlayerDescPower.Name = "lblPlayerDescPower";
			this.tblPlayer.SetRowSpan(this.lblPlayerDescPower, 2);
			this.lblPlayerDescPower.Size = new System.Drawing.Size(59, 52);
			this.lblPlayerDescPower.TabIndex = 0;
			this.lblPlayerDescPower.Text = "Power";
			this.lblPlayerDescPower.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblSplitter2
			// 
			this.lblSplitter2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.tblPlayer.SetColumnSpan(this.lblSplitter2, 5);
			this.lblSplitter2.Location = new System.Drawing.Point(3, 86);
			this.lblSplitter2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.lblSplitter2.Name = "lblSplitter2";
			this.lblSplitter2.Size = new System.Drawing.Size(367, 2);
			this.lblSplitter2.TabIndex = 29;
			// 
			// lblPlayerDescRotation
			// 
			this.lblPlayerDescRotation.Location = new System.Drawing.Point(3, 290);
			this.lblPlayerDescRotation.Name = "lblPlayerDescRotation";
			this.lblPlayerDescRotation.Size = new System.Drawing.Size(59, 26);
			this.lblPlayerDescRotation.TabIndex = 5;
			this.lblPlayerDescRotation.Text = "Rotation";
			this.lblPlayerDescRotation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// gbPlayerPositions
			// 
			this.gbPlayerPositions.Controls.Add(this.lbPlayerPositions);
			this.gbPlayerPositions.Enabled = false;
			this.gbPlayerPositions.Location = new System.Drawing.Point(13, 350);
			this.gbPlayerPositions.Name = "gbPlayerPositions";
			this.gbPlayerPositions.Size = new System.Drawing.Size(378, 134);
			this.gbPlayerPositions.TabIndex = 5;
			this.gbPlayerPositions.TabStop = false;
			this.gbPlayerPositions.Text = "Player Positions";
			// 
			// lbPlayerPositions
			// 
			this.lbPlayerPositions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbPlayerPositions.FormattingEnabled = true;
			this.lbPlayerPositions.ItemHeight = 15;
			this.lbPlayerPositions.Location = new System.Drawing.Point(6, 19);
			this.lbPlayerPositions.Name = "lbPlayerPositions";
			this.lbPlayerPositions.Size = new System.Drawing.Size(366, 109);
			this.lbPlayerPositions.TabIndex = 6;
			this.lbPlayerPositions.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbCustomPositions_MouseDoubleClick);
			// 
			// btnPlayerPositions
			// 
			this.btnPlayerPositions.Enabled = false;
			this.btnPlayerPositions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPlayerPositions.Location = new System.Drawing.Point(311, 345);
			this.btnPlayerPositions.Margin = new System.Windows.Forms.Padding(1);
			this.btnPlayerPositions.Name = "btnPlayerPositions";
			this.btnPlayerPositions.Size = new System.Drawing.Size(75, 22);
			this.btnPlayerPositions.TabIndex = 7;
			this.btnPlayerPositions.Text = "Manage List";
			this.btnPlayerPositions.UseVisualStyleBackColor = true;
			this.btnPlayerPositions.Click += new System.EventHandler(this.btnPlayerPositions_Click);
			// 
			// gbGeneral
			// 
			this.gbGeneral.Controls.Add(this.tableLayoutPanel1);
			this.gbGeneral.Enabled = false;
			this.gbGeneral.Location = new System.Drawing.Point(397, 385);
			this.gbGeneral.Name = "gbGeneral";
			this.gbGeneral.Size = new System.Drawing.Size(381, 71);
			this.gbGeneral.TabIndex = 8;
			this.gbGeneral.TabStop = false;
			this.gbGeneral.Text = "General";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 5;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
			this.tableLayoutPanel1.Controls.Add(this.lblGeneralCanPressureName, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.lblGeneralMapName, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.lblGeneralMapValue, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.lblGeneralCanPressureValue, 2, 1);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 14);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(370, 53);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// lblGeneralCanPressureName
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.lblGeneralCanPressureName, 2);
			this.lblGeneralCanPressureName.Location = new System.Drawing.Point(3, 26);
			this.lblGeneralCanPressureName.Name = "lblGeneralCanPressureName";
			this.lblGeneralCanPressureName.Size = new System.Drawing.Size(104, 26);
			this.lblGeneralCanPressureName.TabIndex = 29;
			this.lblGeneralCanPressureName.Text = "Can Pressure:";
			this.lblGeneralCanPressureName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblGeneralMapName
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.lblGeneralMapName, 2);
			this.lblGeneralMapName.Location = new System.Drawing.Point(3, 0);
			this.lblGeneralMapName.Name = "lblGeneralMapName";
			this.lblGeneralMapName.Size = new System.Drawing.Size(104, 26);
			this.lblGeneralMapName.TabIndex = 9;
			this.lblGeneralMapName.Text = "Map:";
			this.lblGeneralMapName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblGeneralMapValue
			// 
			this.lblGeneralMapValue.AutoEllipsis = true;
			this.tableLayoutPanel1.SetColumnSpan(this.lblGeneralMapValue, 3);
			this.lblGeneralMapValue.Location = new System.Drawing.Point(113, 0);
			this.lblGeneralMapValue.Name = "lblGeneralMapValue";
			this.lblGeneralMapValue.Size = new System.Drawing.Size(255, 26);
			this.lblGeneralMapValue.TabIndex = 28;
			this.lblGeneralMapValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblGeneralCanPressureValue
			// 
			this.lblGeneralCanPressureValue.AutoEllipsis = true;
			this.tableLayoutPanel1.SetColumnSpan(this.lblGeneralCanPressureValue, 3);
			this.lblGeneralCanPressureValue.Location = new System.Drawing.Point(113, 26);
			this.lblGeneralCanPressureValue.Name = "lblGeneralCanPressureValue";
			this.lblGeneralCanPressureValue.Size = new System.Drawing.Size(255, 26);
			this.lblGeneralCanPressureValue.TabIndex = 30;
			this.lblGeneralCanPressureValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// gbPedestrian
			// 
			this.gbPedestrian.Controls.Add(this.tblPedestrianSelected);
			this.gbPedestrian.Controls.Add(this.label18);
			this.gbPedestrian.Controls.Add(this.lblPedestrianSelected);
			this.gbPedestrian.Controls.Add(this.cbPedestrianSelected);
			this.gbPedestrian.Controls.Add(this.lblPedestrianCountValue);
			this.gbPedestrian.Controls.Add(this.lblPedestrianCountName);
			this.gbPedestrian.Enabled = false;
			this.gbPedestrian.Location = new System.Drawing.Point(397, 239);
			this.gbPedestrian.Name = "gbPedestrian";
			this.gbPedestrian.Size = new System.Drawing.Size(381, 140);
			this.gbPedestrian.TabIndex = 9;
			this.gbPedestrian.TabStop = false;
			this.gbPedestrian.Text = "Pedestrian";
			// 
			// tblPedestrianSelected
			// 
			this.tblPedestrianSelected.ColumnCount = 5;
			this.tblPedestrianSelected.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
			this.tblPedestrianSelected.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
			this.tblPedestrianSelected.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
			this.tblPedestrianSelected.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tblPedestrianSelected.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
			this.tblPedestrianSelected.Controls.Add(this.btnPedestrianPosition, 4, 0);
			this.tblPedestrianSelected.Controls.Add(this.txtPedestrianPositionZ, 3, 2);
			this.tblPedestrianSelected.Controls.Add(this.txtPedestrianPositionY, 3, 1);
			this.tblPedestrianSelected.Controls.Add(this.txtPedestrianPositionX, 3, 0);
			this.tblPedestrianSelected.Controls.Add(this.lblPedestrianPositionZValue, 2, 2);
			this.tblPedestrianSelected.Controls.Add(this.lblPedestrianPositionZName, 1, 2);
			this.tblPedestrianSelected.Controls.Add(this.lblPedestrianPositionYValue, 2, 1);
			this.tblPedestrianSelected.Controls.Add(this.lblPedestrianPositionXValue, 2, 0);
			this.tblPedestrianSelected.Controls.Add(this.lblPedestrianPositionYName, 1, 1);
			this.tblPedestrianSelected.Controls.Add(this.lblPedestrianPositionXName, 1, 0);
			this.tblPedestrianSelected.Controls.Add(this.lblPedestrianPositionDesc, 0, 0);
			this.tblPedestrianSelected.Location = new System.Drawing.Point(5, 52);
			this.tblPedestrianSelected.Name = "tblPedestrianSelected";
			this.tblPedestrianSelected.RowCount = 3;
			this.tblPedestrianSelected.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
			this.tblPedestrianSelected.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
			this.tblPedestrianSelected.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
			this.tblPedestrianSelected.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tblPedestrianSelected.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tblPedestrianSelected.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tblPedestrianSelected.Size = new System.Drawing.Size(370, 81);
			this.tblPedestrianSelected.TabIndex = 13;
			// 
			// btnPedestrianPosition
			// 
			this.btnPedestrianPosition.Location = new System.Drawing.Point(319, 3);
			this.btnPedestrianPosition.Name = "btnPedestrianPosition";
			this.tblPedestrianSelected.SetRowSpan(this.btnPedestrianPosition, 3);
			this.btnPedestrianPosition.Size = new System.Drawing.Size(49, 72);
			this.btnPedestrianPosition.TabIndex = 23;
			this.btnPedestrianPosition.Text = "Set";
			this.btnPedestrianPosition.UseVisualStyleBackColor = true;
			this.btnPedestrianPosition.Click += new System.EventHandler(this.btnPedestrianPosition_Click);
			// 
			// txtPedestrianPositionZ
			// 
			this.txtPedestrianPositionZ.Location = new System.Drawing.Point(219, 55);
			this.txtPedestrianPositionZ.Name = "txtPedestrianPositionZ";
			this.txtPedestrianPositionZ.Size = new System.Drawing.Size(94, 20);
			this.txtPedestrianPositionZ.TabIndex = 20;
			// 
			// txtPedestrianPositionY
			// 
			this.txtPedestrianPositionY.Location = new System.Drawing.Point(219, 29);
			this.txtPedestrianPositionY.Name = "txtPedestrianPositionY";
			this.txtPedestrianPositionY.Size = new System.Drawing.Size(94, 20);
			this.txtPedestrianPositionY.TabIndex = 21;
			// 
			// txtPedestrianPositionX
			// 
			this.txtPedestrianPositionX.Location = new System.Drawing.Point(219, 3);
			this.txtPedestrianPositionX.Name = "txtPedestrianPositionX";
			this.txtPedestrianPositionX.Size = new System.Drawing.Size(94, 20);
			this.txtPedestrianPositionX.TabIndex = 22;
			// 
			// lblPedestrianPositionZValue
			// 
			this.lblPedestrianPositionZValue.Location = new System.Drawing.Point(113, 52);
			this.lblPedestrianPositionZValue.Name = "lblPedestrianPositionZValue";
			this.lblPedestrianPositionZValue.Size = new System.Drawing.Size(100, 26);
			this.lblPedestrianPositionZValue.TabIndex = 16;
			this.lblPedestrianPositionZValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPedestrianPositionZName
			// 
			this.lblPedestrianPositionZName.Location = new System.Drawing.Point(68, 52);
			this.lblPedestrianPositionZName.Name = "lblPedestrianPositionZName";
			this.lblPedestrianPositionZName.Size = new System.Drawing.Size(39, 26);
			this.lblPedestrianPositionZName.TabIndex = 14;
			this.lblPedestrianPositionZName.Text = "Z:";
			this.lblPedestrianPositionZName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPedestrianPositionYValue
			// 
			this.lblPedestrianPositionYValue.Location = new System.Drawing.Point(113, 26);
			this.lblPedestrianPositionYValue.Name = "lblPedestrianPositionYValue";
			this.lblPedestrianPositionYValue.Size = new System.Drawing.Size(100, 26);
			this.lblPedestrianPositionYValue.TabIndex = 17;
			this.lblPedestrianPositionYValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPedestrianPositionXValue
			// 
			this.lblPedestrianPositionXValue.Location = new System.Drawing.Point(113, 0);
			this.lblPedestrianPositionXValue.Name = "lblPedestrianPositionXValue";
			this.lblPedestrianPositionXValue.Size = new System.Drawing.Size(100, 26);
			this.lblPedestrianPositionXValue.TabIndex = 18;
			this.lblPedestrianPositionXValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPedestrianPositionYName
			// 
			this.lblPedestrianPositionYName.Location = new System.Drawing.Point(68, 26);
			this.lblPedestrianPositionYName.Name = "lblPedestrianPositionYName";
			this.lblPedestrianPositionYName.Size = new System.Drawing.Size(39, 26);
			this.lblPedestrianPositionYName.TabIndex = 15;
			this.lblPedestrianPositionYName.Text = "Y:";
			this.lblPedestrianPositionYName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPedestrianPositionXName
			// 
			this.lblPedestrianPositionXName.Location = new System.Drawing.Point(68, 0);
			this.lblPedestrianPositionXName.Name = "lblPedestrianPositionXName";
			this.lblPedestrianPositionXName.Size = new System.Drawing.Size(39, 26);
			this.lblPedestrianPositionXName.TabIndex = 19;
			this.lblPedestrianPositionXName.Text = "X:";
			this.lblPedestrianPositionXName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPedestrianPositionDesc
			// 
			this.lblPedestrianPositionDesc.Location = new System.Drawing.Point(3, 0);
			this.lblPedestrianPositionDesc.Name = "lblPedestrianPositionDesc";
			this.tblPedestrianSelected.SetRowSpan(this.lblPedestrianPositionDesc, 3);
			this.lblPedestrianPositionDesc.Size = new System.Drawing.Size(59, 76);
			this.lblPedestrianPositionDesc.TabIndex = 13;
			this.lblPedestrianPositionDesc.Text = "Position";
			this.lblPedestrianPositionDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label18
			// 
			this.label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label18.Location = new System.Drawing.Point(8, 47);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(367, 2);
			this.label18.TabIndex = 12;
			// 
			// lblPedestrianSelected
			// 
			this.lblPedestrianSelected.AutoSize = true;
			this.lblPedestrianSelected.Location = new System.Drawing.Point(8, 21);
			this.lblPedestrianSelected.Name = "lblPedestrianSelected";
			this.lblPedestrianSelected.Size = new System.Drawing.Size(52, 13);
			this.lblPedestrianSelected.TabIndex = 3;
			this.lblPedestrianSelected.Text = "Selected:";
			// 
			// cbPedestrianSelected
			// 
			this.cbPedestrianSelected.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbPedestrianSelected.FormattingEnabled = true;
			this.cbPedestrianSelected.Location = new System.Drawing.Point(72, 19);
			this.cbPedestrianSelected.Name = "cbPedestrianSelected";
			this.cbPedestrianSelected.Size = new System.Drawing.Size(217, 21);
			this.cbPedestrianSelected.TabIndex = 2;
			this.cbPedestrianSelected.SelectedIndexChanged += new System.EventHandler(this.cbPedestrianSelected_SelectedIndexChanged_1);
			// 
			// lblPedestrianCountValue
			// 
			this.lblPedestrianCountValue.Location = new System.Drawing.Point(339, 22);
			this.lblPedestrianCountValue.Name = "lblPedestrianCountValue";
			this.lblPedestrianCountValue.Size = new System.Drawing.Size(31, 13);
			this.lblPedestrianCountValue.TabIndex = 1;
			// 
			// lblPedestrianCountName
			// 
			this.lblPedestrianCountName.AutoSize = true;
			this.lblPedestrianCountName.Location = new System.Drawing.Point(295, 22);
			this.lblPedestrianCountName.Name = "lblPedestrianCountName";
			this.lblPedestrianCountName.Size = new System.Drawing.Size(38, 13);
			this.lblPedestrianCountName.TabIndex = 0;
			this.lblPedestrianCountName.Text = "Count:";
			// 
			// UserInterfaceForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 511);
			this.Controls.Add(this.gbPedestrian);
			this.Controls.Add(this.gbGeneral);
			this.Controls.Add(this.btnPlayerPositions);
			this.Controls.Add(this.gbPlayerPositions);
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
			this.tblEnemySelected.ResumeLayout(false);
			this.tblEnemySelected.PerformLayout();
			this.gbPlayer.ResumeLayout(false);
			this.tblPlayer.ResumeLayout(false);
			this.tblPlayer.PerformLayout();
			this.gbPlayerPositions.ResumeLayout(false);
			this.gbGeneral.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.gbPedestrian.ResumeLayout(false);
			this.gbPedestrian.PerformLayout();
			this.tblPedestrianSelected.ResumeLayout(false);
			this.tblPedestrianSelected.PerformLayout();
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
		private Label lblEnemyHealthMaxName;
		private Label lblEnemyHealthMaxValue;
		private Label lblEnemyHealthCurrentValue;
		private Label lblEnemyHealthCurrentName;
		private Label lblEnemyHealthDesc;
		private Label lblEnemySeparator;
		private Button btnEnemyPosition;
		private TextBox txtEnemyPositionZ;
		private TextBox txtEnemyPositionY;
		private TextBox txtEnemyPositionX;
		private Label lblEnemyPositionZName;
		private Label lblEnemyPositionYName;
		private Label lblEnemyPositionZValue;
		private Label lblEnemyPositionYValue;
		private Label lblEnemyPositionXValue;
		private Label lblEnemyPositionXName;
		private Label lblEnemyPositionDesc;
		private GroupBox gbPlayer;
		private Label lblPlayerModelNameValue;
		private Label lblPlayerModelNameName;
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
		private Label lblPlayerPositionZName;
		private Label lblPlayerPositionYName;
		private TextBox txtPlayerHealthMax;
		private TextBox txtPlayerPowerCurrent;
		private Label lblPlayerRepMaxName;
		private Label lblPlayerPositionZValue;
		private Label lblPlayerPositionYValue;
		private TextBox txtPlayerHealthCurrent;
		private Label lblPlayerPowerMaxName;
		private Label lblPlayerPositionXValue;
		private Label lblPlayerRepMaxValue;
		private Label lblPlayerHealthMaxName;
		private Label lblPlayerRepCurrentValue;
		private Label lblPlayerPositionXName;
		private Label lblPlayerPowerMaxValue;
		private Label lblPlayerPowerCurrentValue;
		private Label lblPlayerRepCurrentName;
		private Label lblPlayerDescPosition;
		private Label lblPlayerHealthMaxValue;
		private Label lblPlayerPowerCurrentName;
		private Label lblPlayerDescRep;
		private Label lblPlayerHealthCurrentValue;
		private Label lblPlayerDescPower;
		private Label lblPlayerHealthCurrentName;
		private Label lblPlayerDescHealth;
		private ToolStripStatusLabel toolStripStatusLabelEmpty;
		private ToolStripDropDownButton btnAbout;
		private ToolStripDropDownButton btnSettings;
		private Label lblPlayerDescRotation;
		private TableLayoutPanel tblPlayer;
		private Label lblPlayerDescModel;
		private Label lblSplitter2;
		private Label lblSplitter3;
		private Label lblSplitter4;
		private Label lblSplitter5;
		private Label lblSplitter1;
		private Label lblPlayerRotationYawValue;
		private Label lblPlayerRotationYawName;
		private GroupBox gbPlayerPositions;
		private ListBox lbPlayerPositions;
		private Button btnPlayerPositions;
		private TableLayoutPanel tblEnemySelected;
		private Label lblSplitter6;
		private Label lblSplitter7;
		private Label lblEnemyRotationYawValue;
		private Label lblEnemyRotationYawName;
		private Label lblEnemyRotationDesc;
		private GroupBox gbGeneral;
		private TableLayoutPanel tableLayoutPanel1;
		private Label lblGeneralMapName;
		private Label lblGeneralMapValue;
		private Label lblGeneralCanPressureName;
		private Label lblGeneralCanPressureValue;
		private GroupBox gbPedestrian;
		private TableLayoutPanel tblPedestrianSelected;
		private Button btnPedestrianPosition;
		private TextBox txtPedestrianPositionZ;
		private TextBox txtPedestrianPositionY;
		private TextBox txtPedestrianPositionX;
		private Label lblPedestrianPositionZValue;
		private Label lblPedestrianPositionZName;
		private Label lblPedestrianPositionYValue;
		private Label lblPedestrianPositionXValue;
		private Label lblPedestrianPositionYName;
		private Label lblPedestrianPositionXName;
		private Label lblPedestrianPositionDesc;
		private Label label18;
		private Label lblPedestrianSelected;
		private ComboBox cbPedestrianSelected;
		private Label lblPedestrianCountValue;
		private Label lblPedestrianCountName;
	}
}