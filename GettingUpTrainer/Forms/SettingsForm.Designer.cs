namespace GettingUpTrainer.Forms
{
	partial class SettingsForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.listBoxSettings = new System.Windows.Forms.ListBox();
			this.tblPanelHotkeys = new System.Windows.Forms.TableLayoutPanel();
			this.btnHotkeysPedestrianPositionClear = new System.Windows.Forms.Button();
			this.btnHotkeysPedestrianPositionEdit = new System.Windows.Forms.Button();
			this.lblHotkeysPedestrianPositionValue = new System.Windows.Forms.Label();
			this.lblHotkeysPedestrianPositionName = new System.Windows.Forms.Label();
			this.lblHotkeysPedestrian = new System.Windows.Forms.Label();
			this.btnHotkeysEnemyPositionClear = new System.Windows.Forms.Button();
			this.btnHotkeysEnemyPositionEdit = new System.Windows.Forms.Button();
			this.lblHotkeysEnemyPositionValue = new System.Windows.Forms.Label();
			this.lblHotkeysEnemyPositionName = new System.Windows.Forms.Label();
			this.btnHotkeysEnemyHealthClear = new System.Windows.Forms.Button();
			this.btnHotkeysEnemyHealthEdit = new System.Windows.Forms.Button();
			this.lblHotkeysEnemyHealthValue = new System.Windows.Forms.Label();
			this.lblHotkeysEnemyHealthName = new System.Windows.Forms.Label();
			this.lblHotkeysEnemy = new System.Windows.Forms.Label();
			this.btnHotkeysPlayerPositionClear = new System.Windows.Forms.Button();
			this.btnHotkeysPlayerPositionEdit = new System.Windows.Forms.Button();
			this.lblHotkeysPlayerPositionValue = new System.Windows.Forms.Label();
			this.lblHotkeysPlayerPositionName = new System.Windows.Forms.Label();
			this.btnHotkeysPlayerRepClear = new System.Windows.Forms.Button();
			this.btnHotkeysPlayerRepEdit = new System.Windows.Forms.Button();
			this.lblHotkeysPlayerRepValue = new System.Windows.Forms.Label();
			this.lblHotkeysPlayerRepName = new System.Windows.Forms.Label();
			this.btnHotkeysPlayerPowerClear = new System.Windows.Forms.Button();
			this.btnHotkeysPlayerPowerEdit = new System.Windows.Forms.Button();
			this.lblHotkeysPlayerPowerValue = new System.Windows.Forms.Label();
			this.lblHotkeysPlayerPowerName = new System.Windows.Forms.Label();
			this.lblHotkeysPlayer = new System.Windows.Forms.Label();
			this.lblHotkeysPlayerHealthName = new System.Windows.Forms.Label();
			this.lblHotkeysPlayerHealthValue = new System.Windows.Forms.Label();
			this.btnHotkeysPlayerHealthEdit = new System.Windows.Forms.Button();
			this.btnHotkeysPlayerHealthClear = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tblPanelHotkeys.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer1.ForeColor = System.Drawing.Color.Black;
			this.splitContainer1.IsSplitterFixed = true;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.listBoxSettings);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.tblPanelHotkeys);
			this.splitContainer1.Size = new System.Drawing.Size(484, 361);
			this.splitContainer1.SplitterDistance = 100;
			this.splitContainer1.TabIndex = 1;
			// 
			// listBoxSettings
			// 
			this.listBoxSettings.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBoxSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBoxSettings.FormattingEnabled = true;
			this.listBoxSettings.ItemHeight = 20;
			this.listBoxSettings.Items.AddRange(new object[] {
            "Hotkeys"});
			this.listBoxSettings.Location = new System.Drawing.Point(0, 0);
			this.listBoxSettings.Name = "listBoxSettings";
			this.listBoxSettings.Size = new System.Drawing.Size(100, 361);
			this.listBoxSettings.TabIndex = 0;
			this.listBoxSettings.SelectedValueChanged += new System.EventHandler(this.listBoxSettings_SelectedValueChanged);
			// 
			// tblPanelHotkeys
			// 
			this.tblPanelHotkeys.AutoScroll = true;
			this.tblPanelHotkeys.AutoSize = true;
			this.tblPanelHotkeys.ColumnCount = 4;
			this.tblPanelHotkeys.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tblPanelHotkeys.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tblPanelHotkeys.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tblPanelHotkeys.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this.tblPanelHotkeys.Controls.Add(this.btnHotkeysPedestrianPositionClear, 3, 9);
			this.tblPanelHotkeys.Controls.Add(this.btnHotkeysPedestrianPositionEdit, 2, 9);
			this.tblPanelHotkeys.Controls.Add(this.lblHotkeysPedestrianPositionValue, 1, 9);
			this.tblPanelHotkeys.Controls.Add(this.lblHotkeysPedestrianPositionName, 0, 9);
			this.tblPanelHotkeys.Controls.Add(this.lblHotkeysPedestrian, 0, 8);
			this.tblPanelHotkeys.Controls.Add(this.btnHotkeysEnemyPositionClear, 3, 7);
			this.tblPanelHotkeys.Controls.Add(this.btnHotkeysEnemyPositionEdit, 2, 7);
			this.tblPanelHotkeys.Controls.Add(this.lblHotkeysEnemyPositionValue, 1, 7);
			this.tblPanelHotkeys.Controls.Add(this.lblHotkeysEnemyPositionName, 0, 7);
			this.tblPanelHotkeys.Controls.Add(this.btnHotkeysEnemyHealthClear, 3, 6);
			this.tblPanelHotkeys.Controls.Add(this.btnHotkeysEnemyHealthEdit, 2, 6);
			this.tblPanelHotkeys.Controls.Add(this.lblHotkeysEnemyHealthValue, 1, 6);
			this.tblPanelHotkeys.Controls.Add(this.lblHotkeysEnemyHealthName, 0, 6);
			this.tblPanelHotkeys.Controls.Add(this.lblHotkeysEnemy, 0, 5);
			this.tblPanelHotkeys.Controls.Add(this.btnHotkeysPlayerPositionClear, 3, 4);
			this.tblPanelHotkeys.Controls.Add(this.btnHotkeysPlayerPositionEdit, 2, 4);
			this.tblPanelHotkeys.Controls.Add(this.lblHotkeysPlayerPositionValue, 1, 4);
			this.tblPanelHotkeys.Controls.Add(this.lblHotkeysPlayerPositionName, 0, 4);
			this.tblPanelHotkeys.Controls.Add(this.btnHotkeysPlayerRepClear, 3, 3);
			this.tblPanelHotkeys.Controls.Add(this.btnHotkeysPlayerRepEdit, 2, 3);
			this.tblPanelHotkeys.Controls.Add(this.lblHotkeysPlayerRepValue, 1, 3);
			this.tblPanelHotkeys.Controls.Add(this.lblHotkeysPlayerRepName, 0, 3);
			this.tblPanelHotkeys.Controls.Add(this.btnHotkeysPlayerPowerClear, 3, 2);
			this.tblPanelHotkeys.Controls.Add(this.btnHotkeysPlayerPowerEdit, 2, 2);
			this.tblPanelHotkeys.Controls.Add(this.lblHotkeysPlayerPowerValue, 1, 2);
			this.tblPanelHotkeys.Controls.Add(this.lblHotkeysPlayerPowerName, 0, 2);
			this.tblPanelHotkeys.Controls.Add(this.lblHotkeysPlayer, 0, 0);
			this.tblPanelHotkeys.Controls.Add(this.lblHotkeysPlayerHealthName, 0, 1);
			this.tblPanelHotkeys.Controls.Add(this.lblHotkeysPlayerHealthValue, 1, 1);
			this.tblPanelHotkeys.Controls.Add(this.btnHotkeysPlayerHealthEdit, 2, 1);
			this.tblPanelHotkeys.Controls.Add(this.btnHotkeysPlayerHealthClear, 3, 1);
			this.tblPanelHotkeys.Dock = System.Windows.Forms.DockStyle.Top;
			this.tblPanelHotkeys.Location = new System.Drawing.Point(0, 0);
			this.tblPanelHotkeys.Name = "tblPanelHotkeys";
			this.tblPanelHotkeys.RowCount = 10;
			this.tblPanelHotkeys.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tblPanelHotkeys.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tblPanelHotkeys.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tblPanelHotkeys.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tblPanelHotkeys.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tblPanelHotkeys.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tblPanelHotkeys.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tblPanelHotkeys.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tblPanelHotkeys.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tblPanelHotkeys.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tblPanelHotkeys.Size = new System.Drawing.Size(380, 300);
			this.tblPanelHotkeys.TabIndex = 0;
			this.tblPanelHotkeys.Visible = false;
			// 
			// btnHotkeysPedestrianPositionClear
			// 
			this.btnHotkeysPedestrianPositionClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHotkeysPedestrianPositionClear.BackgroundImage")));
			this.btnHotkeysPedestrianPositionClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnHotkeysPedestrianPositionClear.Location = new System.Drawing.Point(351, 273);
			this.btnHotkeysPedestrianPositionClear.Name = "btnHotkeysPedestrianPositionClear";
			this.btnHotkeysPedestrianPositionClear.Size = new System.Drawing.Size(25, 23);
			this.btnHotkeysPedestrianPositionClear.TabIndex = 30;
			this.btnHotkeysPedestrianPositionClear.UseVisualStyleBackColor = true;
			this.btnHotkeysPedestrianPositionClear.Click += new System.EventHandler(this.btnHotkeysPedestrianPositionClear_Click);
			// 
			// btnHotkeysPedestrianPositionEdit
			// 
			this.btnHotkeysPedestrianPositionEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHotkeysPedestrianPositionEdit.BackgroundImage")));
			this.btnHotkeysPedestrianPositionEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnHotkeysPedestrianPositionEdit.Location = new System.Drawing.Point(321, 273);
			this.btnHotkeysPedestrianPositionEdit.Name = "btnHotkeysPedestrianPositionEdit";
			this.btnHotkeysPedestrianPositionEdit.Size = new System.Drawing.Size(24, 23);
			this.btnHotkeysPedestrianPositionEdit.TabIndex = 29;
			this.btnHotkeysPedestrianPositionEdit.UseVisualStyleBackColor = true;
			this.btnHotkeysPedestrianPositionEdit.Click += new System.EventHandler(this.btnHotkeysPedestrianPositionEdit_Click);
			// 
			// lblHotkeysPedestrianPositionValue
			// 
			this.lblHotkeysPedestrianPositionValue.AutoSize = true;
			this.lblHotkeysPedestrianPositionValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblHotkeysPedestrianPositionValue.Location = new System.Drawing.Point(162, 270);
			this.lblHotkeysPedestrianPositionValue.Name = "lblHotkeysPedestrianPositionValue";
			this.lblHotkeysPedestrianPositionValue.Size = new System.Drawing.Size(153, 30);
			this.lblHotkeysPedestrianPositionValue.TabIndex = 28;
			this.lblHotkeysPedestrianPositionValue.Text = "(none)";
			this.lblHotkeysPedestrianPositionValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblHotkeysPedestrianPositionName
			// 
			this.lblHotkeysPedestrianPositionName.AutoSize = true;
			this.lblHotkeysPedestrianPositionName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblHotkeysPedestrianPositionName.Location = new System.Drawing.Point(3, 270);
			this.lblHotkeysPedestrianPositionName.Name = "lblHotkeysPedestrianPositionName";
			this.lblHotkeysPedestrianPositionName.Size = new System.Drawing.Size(153, 30);
			this.lblHotkeysPedestrianPositionName.TabIndex = 27;
			this.lblHotkeysPedestrianPositionName.Text = "Health";
			this.lblHotkeysPedestrianPositionName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblHotkeysPedestrian
			// 
			this.lblHotkeysPedestrian.AutoSize = true;
			this.tblPanelHotkeys.SetColumnSpan(this.lblHotkeysPedestrian, 4);
			this.lblHotkeysPedestrian.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblHotkeysPedestrian.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHotkeysPedestrian.Location = new System.Drawing.Point(3, 240);
			this.lblHotkeysPedestrian.Name = "lblHotkeysPedestrian";
			this.lblHotkeysPedestrian.Size = new System.Drawing.Size(374, 30);
			this.lblHotkeysPedestrian.TabIndex = 26;
			this.lblHotkeysPedestrian.Text = "Pedestrian";
			this.lblHotkeysPedestrian.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnHotkeysEnemyPositionClear
			// 
			this.btnHotkeysEnemyPositionClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHotkeysEnemyPositionClear.BackgroundImage")));
			this.btnHotkeysEnemyPositionClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnHotkeysEnemyPositionClear.Location = new System.Drawing.Point(351, 213);
			this.btnHotkeysEnemyPositionClear.Name = "btnHotkeysEnemyPositionClear";
			this.btnHotkeysEnemyPositionClear.Size = new System.Drawing.Size(25, 23);
			this.btnHotkeysEnemyPositionClear.TabIndex = 25;
			this.btnHotkeysEnemyPositionClear.UseVisualStyleBackColor = true;
			this.btnHotkeysEnemyPositionClear.Click += new System.EventHandler(this.btnHotkeysEnemyPositionClear_Click);
			// 
			// btnHotkeysEnemyPositionEdit
			// 
			this.btnHotkeysEnemyPositionEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHotkeysEnemyPositionEdit.BackgroundImage")));
			this.btnHotkeysEnemyPositionEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnHotkeysEnemyPositionEdit.Location = new System.Drawing.Point(321, 213);
			this.btnHotkeysEnemyPositionEdit.Name = "btnHotkeysEnemyPositionEdit";
			this.btnHotkeysEnemyPositionEdit.Size = new System.Drawing.Size(24, 23);
			this.btnHotkeysEnemyPositionEdit.TabIndex = 24;
			this.btnHotkeysEnemyPositionEdit.UseVisualStyleBackColor = true;
			this.btnHotkeysEnemyPositionEdit.Click += new System.EventHandler(this.btnHotkeysEnemyPositionEdit_Click);
			// 
			// lblHotkeysEnemyPositionValue
			// 
			this.lblHotkeysEnemyPositionValue.AutoSize = true;
			this.lblHotkeysEnemyPositionValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblHotkeysEnemyPositionValue.Location = new System.Drawing.Point(162, 210);
			this.lblHotkeysEnemyPositionValue.Name = "lblHotkeysEnemyPositionValue";
			this.lblHotkeysEnemyPositionValue.Size = new System.Drawing.Size(153, 30);
			this.lblHotkeysEnemyPositionValue.TabIndex = 23;
			this.lblHotkeysEnemyPositionValue.Text = "(none)";
			this.lblHotkeysEnemyPositionValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblHotkeysEnemyPositionName
			// 
			this.lblHotkeysEnemyPositionName.AutoSize = true;
			this.lblHotkeysEnemyPositionName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblHotkeysEnemyPositionName.Location = new System.Drawing.Point(3, 210);
			this.lblHotkeysEnemyPositionName.Name = "lblHotkeysEnemyPositionName";
			this.lblHotkeysEnemyPositionName.Size = new System.Drawing.Size(153, 30);
			this.lblHotkeysEnemyPositionName.TabIndex = 22;
			this.lblHotkeysEnemyPositionName.Text = "Position";
			this.lblHotkeysEnemyPositionName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnHotkeysEnemyHealthClear
			// 
			this.btnHotkeysEnemyHealthClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHotkeysEnemyHealthClear.BackgroundImage")));
			this.btnHotkeysEnemyHealthClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnHotkeysEnemyHealthClear.Location = new System.Drawing.Point(351, 183);
			this.btnHotkeysEnemyHealthClear.Name = "btnHotkeysEnemyHealthClear";
			this.btnHotkeysEnemyHealthClear.Size = new System.Drawing.Size(25, 23);
			this.btnHotkeysEnemyHealthClear.TabIndex = 21;
			this.btnHotkeysEnemyHealthClear.UseVisualStyleBackColor = true;
			this.btnHotkeysEnemyHealthClear.Click += new System.EventHandler(this.btnHotkeysEnemyHealthClear_Click);
			// 
			// btnHotkeysEnemyHealthEdit
			// 
			this.btnHotkeysEnemyHealthEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHotkeysEnemyHealthEdit.BackgroundImage")));
			this.btnHotkeysEnemyHealthEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnHotkeysEnemyHealthEdit.Location = new System.Drawing.Point(321, 183);
			this.btnHotkeysEnemyHealthEdit.Name = "btnHotkeysEnemyHealthEdit";
			this.btnHotkeysEnemyHealthEdit.Size = new System.Drawing.Size(24, 23);
			this.btnHotkeysEnemyHealthEdit.TabIndex = 20;
			this.btnHotkeysEnemyHealthEdit.UseVisualStyleBackColor = true;
			this.btnHotkeysEnemyHealthEdit.Click += new System.EventHandler(this.btnHotkeysEnemyHealthEdit_Click);
			// 
			// lblHotkeysEnemyHealthValue
			// 
			this.lblHotkeysEnemyHealthValue.AutoSize = true;
			this.lblHotkeysEnemyHealthValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblHotkeysEnemyHealthValue.Location = new System.Drawing.Point(162, 180);
			this.lblHotkeysEnemyHealthValue.Name = "lblHotkeysEnemyHealthValue";
			this.lblHotkeysEnemyHealthValue.Size = new System.Drawing.Size(153, 30);
			this.lblHotkeysEnemyHealthValue.TabIndex = 19;
			this.lblHotkeysEnemyHealthValue.Text = "(none)";
			this.lblHotkeysEnemyHealthValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblHotkeysEnemyHealthName
			// 
			this.lblHotkeysEnemyHealthName.AutoSize = true;
			this.lblHotkeysEnemyHealthName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblHotkeysEnemyHealthName.Location = new System.Drawing.Point(3, 180);
			this.lblHotkeysEnemyHealthName.Name = "lblHotkeysEnemyHealthName";
			this.lblHotkeysEnemyHealthName.Size = new System.Drawing.Size(153, 30);
			this.lblHotkeysEnemyHealthName.TabIndex = 18;
			this.lblHotkeysEnemyHealthName.Text = "Health";
			this.lblHotkeysEnemyHealthName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblHotkeysEnemy
			// 
			this.lblHotkeysEnemy.AutoSize = true;
			this.tblPanelHotkeys.SetColumnSpan(this.lblHotkeysEnemy, 4);
			this.lblHotkeysEnemy.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblHotkeysEnemy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHotkeysEnemy.Location = new System.Drawing.Point(3, 150);
			this.lblHotkeysEnemy.Name = "lblHotkeysEnemy";
			this.lblHotkeysEnemy.Size = new System.Drawing.Size(374, 30);
			this.lblHotkeysEnemy.TabIndex = 17;
			this.lblHotkeysEnemy.Text = "Enemy";
			this.lblHotkeysEnemy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnHotkeysPlayerPositionClear
			// 
			this.btnHotkeysPlayerPositionClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHotkeysPlayerPositionClear.BackgroundImage")));
			this.btnHotkeysPlayerPositionClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnHotkeysPlayerPositionClear.Location = new System.Drawing.Point(351, 123);
			this.btnHotkeysPlayerPositionClear.Name = "btnHotkeysPlayerPositionClear";
			this.btnHotkeysPlayerPositionClear.Size = new System.Drawing.Size(25, 23);
			this.btnHotkeysPlayerPositionClear.TabIndex = 16;
			this.btnHotkeysPlayerPositionClear.UseVisualStyleBackColor = true;
			this.btnHotkeysPlayerPositionClear.Click += new System.EventHandler(this.btnHotkeysPlayerPositionClear_Click);
			// 
			// btnHotkeysPlayerPositionEdit
			// 
			this.btnHotkeysPlayerPositionEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHotkeysPlayerPositionEdit.BackgroundImage")));
			this.btnHotkeysPlayerPositionEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnHotkeysPlayerPositionEdit.Location = new System.Drawing.Point(321, 123);
			this.btnHotkeysPlayerPositionEdit.Name = "btnHotkeysPlayerPositionEdit";
			this.btnHotkeysPlayerPositionEdit.Size = new System.Drawing.Size(24, 23);
			this.btnHotkeysPlayerPositionEdit.TabIndex = 15;
			this.btnHotkeysPlayerPositionEdit.UseVisualStyleBackColor = true;
			this.btnHotkeysPlayerPositionEdit.Click += new System.EventHandler(this.btnHotkeysPlayerPositionEdit_Click);
			// 
			// lblHotkeysPlayerPositionValue
			// 
			this.lblHotkeysPlayerPositionValue.AutoSize = true;
			this.lblHotkeysPlayerPositionValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblHotkeysPlayerPositionValue.Location = new System.Drawing.Point(162, 120);
			this.lblHotkeysPlayerPositionValue.Name = "lblHotkeysPlayerPositionValue";
			this.lblHotkeysPlayerPositionValue.Size = new System.Drawing.Size(153, 30);
			this.lblHotkeysPlayerPositionValue.TabIndex = 14;
			this.lblHotkeysPlayerPositionValue.Text = "(none)";
			this.lblHotkeysPlayerPositionValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblHotkeysPlayerPositionName
			// 
			this.lblHotkeysPlayerPositionName.AutoSize = true;
			this.lblHotkeysPlayerPositionName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblHotkeysPlayerPositionName.Location = new System.Drawing.Point(3, 120);
			this.lblHotkeysPlayerPositionName.Name = "lblHotkeysPlayerPositionName";
			this.lblHotkeysPlayerPositionName.Size = new System.Drawing.Size(153, 30);
			this.lblHotkeysPlayerPositionName.TabIndex = 13;
			this.lblHotkeysPlayerPositionName.Text = "Position";
			this.lblHotkeysPlayerPositionName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnHotkeysPlayerRepClear
			// 
			this.btnHotkeysPlayerRepClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHotkeysPlayerRepClear.BackgroundImage")));
			this.btnHotkeysPlayerRepClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnHotkeysPlayerRepClear.Location = new System.Drawing.Point(351, 93);
			this.btnHotkeysPlayerRepClear.Name = "btnHotkeysPlayerRepClear";
			this.btnHotkeysPlayerRepClear.Size = new System.Drawing.Size(25, 23);
			this.btnHotkeysPlayerRepClear.TabIndex = 12;
			this.btnHotkeysPlayerRepClear.UseVisualStyleBackColor = true;
			this.btnHotkeysPlayerRepClear.Click += new System.EventHandler(this.btnHotkeysPlayerRepClear_Click);
			// 
			// btnHotkeysPlayerRepEdit
			// 
			this.btnHotkeysPlayerRepEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHotkeysPlayerRepEdit.BackgroundImage")));
			this.btnHotkeysPlayerRepEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnHotkeysPlayerRepEdit.Location = new System.Drawing.Point(321, 93);
			this.btnHotkeysPlayerRepEdit.Name = "btnHotkeysPlayerRepEdit";
			this.btnHotkeysPlayerRepEdit.Size = new System.Drawing.Size(24, 23);
			this.btnHotkeysPlayerRepEdit.TabIndex = 11;
			this.btnHotkeysPlayerRepEdit.UseVisualStyleBackColor = true;
			this.btnHotkeysPlayerRepEdit.Click += new System.EventHandler(this.btnHotkeysPlayerRepEdit_Click);
			// 
			// lblHotkeysPlayerRepValue
			// 
			this.lblHotkeysPlayerRepValue.AutoSize = true;
			this.lblHotkeysPlayerRepValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblHotkeysPlayerRepValue.Location = new System.Drawing.Point(162, 90);
			this.lblHotkeysPlayerRepValue.Name = "lblHotkeysPlayerRepValue";
			this.lblHotkeysPlayerRepValue.Size = new System.Drawing.Size(153, 30);
			this.lblHotkeysPlayerRepValue.TabIndex = 10;
			this.lblHotkeysPlayerRepValue.Text = "(none)";
			this.lblHotkeysPlayerRepValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblHotkeysPlayerRepName
			// 
			this.lblHotkeysPlayerRepName.AutoSize = true;
			this.lblHotkeysPlayerRepName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblHotkeysPlayerRepName.Location = new System.Drawing.Point(3, 90);
			this.lblHotkeysPlayerRepName.Name = "lblHotkeysPlayerRepName";
			this.lblHotkeysPlayerRepName.Size = new System.Drawing.Size(153, 30);
			this.lblHotkeysPlayerRepName.TabIndex = 9;
			this.lblHotkeysPlayerRepName.Text = "Rep";
			this.lblHotkeysPlayerRepName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnHotkeysPlayerPowerClear
			// 
			this.btnHotkeysPlayerPowerClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHotkeysPlayerPowerClear.BackgroundImage")));
			this.btnHotkeysPlayerPowerClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnHotkeysPlayerPowerClear.Location = new System.Drawing.Point(351, 63);
			this.btnHotkeysPlayerPowerClear.Name = "btnHotkeysPlayerPowerClear";
			this.btnHotkeysPlayerPowerClear.Size = new System.Drawing.Size(25, 23);
			this.btnHotkeysPlayerPowerClear.TabIndex = 8;
			this.btnHotkeysPlayerPowerClear.UseVisualStyleBackColor = true;
			this.btnHotkeysPlayerPowerClear.Click += new System.EventHandler(this.btnHotkeysPlayerPowerClear_Click);
			// 
			// btnHotkeysPlayerPowerEdit
			// 
			this.btnHotkeysPlayerPowerEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHotkeysPlayerPowerEdit.BackgroundImage")));
			this.btnHotkeysPlayerPowerEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnHotkeysPlayerPowerEdit.Location = new System.Drawing.Point(321, 63);
			this.btnHotkeysPlayerPowerEdit.Name = "btnHotkeysPlayerPowerEdit";
			this.btnHotkeysPlayerPowerEdit.Size = new System.Drawing.Size(24, 23);
			this.btnHotkeysPlayerPowerEdit.TabIndex = 7;
			this.btnHotkeysPlayerPowerEdit.UseVisualStyleBackColor = true;
			this.btnHotkeysPlayerPowerEdit.Click += new System.EventHandler(this.btnHotkeysPlayerPowerEdit_Click);
			// 
			// lblHotkeysPlayerPowerValue
			// 
			this.lblHotkeysPlayerPowerValue.AutoSize = true;
			this.lblHotkeysPlayerPowerValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblHotkeysPlayerPowerValue.Location = new System.Drawing.Point(162, 60);
			this.lblHotkeysPlayerPowerValue.Name = "lblHotkeysPlayerPowerValue";
			this.lblHotkeysPlayerPowerValue.Size = new System.Drawing.Size(153, 30);
			this.lblHotkeysPlayerPowerValue.TabIndex = 6;
			this.lblHotkeysPlayerPowerValue.Text = "(none)";
			this.lblHotkeysPlayerPowerValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblHotkeysPlayerPowerName
			// 
			this.lblHotkeysPlayerPowerName.AutoSize = true;
			this.lblHotkeysPlayerPowerName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblHotkeysPlayerPowerName.Location = new System.Drawing.Point(3, 60);
			this.lblHotkeysPlayerPowerName.Name = "lblHotkeysPlayerPowerName";
			this.lblHotkeysPlayerPowerName.Size = new System.Drawing.Size(153, 30);
			this.lblHotkeysPlayerPowerName.TabIndex = 5;
			this.lblHotkeysPlayerPowerName.Text = "Power";
			this.lblHotkeysPlayerPowerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblHotkeysPlayer
			// 
			this.lblHotkeysPlayer.AutoSize = true;
			this.tblPanelHotkeys.SetColumnSpan(this.lblHotkeysPlayer, 4);
			this.lblHotkeysPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblHotkeysPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHotkeysPlayer.Location = new System.Drawing.Point(3, 0);
			this.lblHotkeysPlayer.Name = "lblHotkeysPlayer";
			this.lblHotkeysPlayer.Size = new System.Drawing.Size(374, 30);
			this.lblHotkeysPlayer.TabIndex = 0;
			this.lblHotkeysPlayer.Text = "Player";
			this.lblHotkeysPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblHotkeysPlayerHealthName
			// 
			this.lblHotkeysPlayerHealthName.AutoSize = true;
			this.lblHotkeysPlayerHealthName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblHotkeysPlayerHealthName.Location = new System.Drawing.Point(3, 30);
			this.lblHotkeysPlayerHealthName.Name = "lblHotkeysPlayerHealthName";
			this.lblHotkeysPlayerHealthName.Size = new System.Drawing.Size(153, 30);
			this.lblHotkeysPlayerHealthName.TabIndex = 1;
			this.lblHotkeysPlayerHealthName.Text = "Health";
			this.lblHotkeysPlayerHealthName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblHotkeysPlayerHealthValue
			// 
			this.lblHotkeysPlayerHealthValue.AutoSize = true;
			this.lblHotkeysPlayerHealthValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblHotkeysPlayerHealthValue.Location = new System.Drawing.Point(162, 30);
			this.lblHotkeysPlayerHealthValue.Name = "lblHotkeysPlayerHealthValue";
			this.lblHotkeysPlayerHealthValue.Size = new System.Drawing.Size(153, 30);
			this.lblHotkeysPlayerHealthValue.TabIndex = 2;
			this.lblHotkeysPlayerHealthValue.Text = "(none)";
			this.lblHotkeysPlayerHealthValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnHotkeysPlayerHealthEdit
			// 
			this.btnHotkeysPlayerHealthEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHotkeysPlayerHealthEdit.BackgroundImage")));
			this.btnHotkeysPlayerHealthEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnHotkeysPlayerHealthEdit.Location = new System.Drawing.Point(321, 33);
			this.btnHotkeysPlayerHealthEdit.Name = "btnHotkeysPlayerHealthEdit";
			this.btnHotkeysPlayerHealthEdit.Size = new System.Drawing.Size(24, 23);
			this.btnHotkeysPlayerHealthEdit.TabIndex = 3;
			this.btnHotkeysPlayerHealthEdit.UseVisualStyleBackColor = true;
			this.btnHotkeysPlayerHealthEdit.Click += new System.EventHandler(this.btnHotkeysPlayerHealthEdit_Click);
			// 
			// btnHotkeysPlayerHealthClear
			// 
			this.btnHotkeysPlayerHealthClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHotkeysPlayerHealthClear.BackgroundImage")));
			this.btnHotkeysPlayerHealthClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnHotkeysPlayerHealthClear.Location = new System.Drawing.Point(351, 33);
			this.btnHotkeysPlayerHealthClear.Name = "btnHotkeysPlayerHealthClear";
			this.btnHotkeysPlayerHealthClear.Size = new System.Drawing.Size(25, 23);
			this.btnHotkeysPlayerHealthClear.TabIndex = 4;
			this.btnHotkeysPlayerHealthClear.UseVisualStyleBackColor = true;
			this.btnHotkeysPlayerHealthClear.Click += new System.EventHandler(this.btnHotkeysPlayerHealthClear_Click);
			// 
			// SettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(484, 361);
			this.Controls.Add(this.splitContainer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SettingsForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Settings";
			this.TopMost = true;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsForm_FormClosed);
			this.Load += new System.EventHandler(this.SettingsForm_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SettingsForm_KeyDown);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.tblPanelHotkeys.ResumeLayout(false);
			this.tblPanelHotkeys.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.ListBox listBoxSettings;
		private System.Windows.Forms.TableLayoutPanel tblPanelHotkeys;
		private System.Windows.Forms.Label lblHotkeysPlayer;
		private System.Windows.Forms.Label lblHotkeysPlayerHealthName;
		private System.Windows.Forms.Label lblHotkeysPlayerHealthValue;
		private System.Windows.Forms.Button btnHotkeysPlayerHealthEdit;
		private System.Windows.Forms.Button btnHotkeysPlayerHealthClear;
		private System.Windows.Forms.Button btnHotkeysPlayerPositionClear;
		private System.Windows.Forms.Button btnHotkeysPlayerPositionEdit;
		private System.Windows.Forms.Label lblHotkeysPlayerPositionValue;
		private System.Windows.Forms.Label lblHotkeysPlayerPositionName;
		private System.Windows.Forms.Button btnHotkeysPlayerRepClear;
		private System.Windows.Forms.Button btnHotkeysPlayerRepEdit;
		private System.Windows.Forms.Label lblHotkeysPlayerRepValue;
		private System.Windows.Forms.Label lblHotkeysPlayerRepName;
		private System.Windows.Forms.Button btnHotkeysPlayerPowerClear;
		private System.Windows.Forms.Button btnHotkeysPlayerPowerEdit;
		private System.Windows.Forms.Label lblHotkeysPlayerPowerValue;
		private System.Windows.Forms.Label lblHotkeysPlayerPowerName;
		private System.Windows.Forms.Label lblHotkeysEnemy;
		private System.Windows.Forms.Button btnHotkeysEnemyPositionClear;
		private System.Windows.Forms.Button btnHotkeysEnemyPositionEdit;
		private System.Windows.Forms.Label lblHotkeysEnemyPositionValue;
		private System.Windows.Forms.Label lblHotkeysEnemyPositionName;
		private System.Windows.Forms.Button btnHotkeysEnemyHealthClear;
		private System.Windows.Forms.Button btnHotkeysEnemyHealthEdit;
		private System.Windows.Forms.Label lblHotkeysEnemyHealthValue;
		private System.Windows.Forms.Label lblHotkeysEnemyHealthName;
		private System.Windows.Forms.Label lblHotkeysPedestrian;
		private System.Windows.Forms.Button btnHotkeysPedestrianPositionClear;
		private System.Windows.Forms.Button btnHotkeysPedestrianPositionEdit;
		private System.Windows.Forms.Label lblHotkeysPedestrianPositionValue;
		private System.Windows.Forms.Label lblHotkeysPedestrianPositionName;
	}
}