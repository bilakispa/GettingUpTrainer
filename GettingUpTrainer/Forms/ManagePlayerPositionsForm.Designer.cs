namespace GettingUpTrainer.Forms
{
	partial class ManagePlayerPositionsForm
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
			this.components = new System.ComponentModel.Container();
			this.dataGridViewPlayerPositions = new System.Windows.Forms.DataGridView();
			this.playerPositionBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.positionXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.positionYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.positionZDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayerPositions)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.playerPositionBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewPlayerPositions
			// 
			this.dataGridViewPlayerPositions.AllowUserToResizeColumns = false;
			this.dataGridViewPlayerPositions.AllowUserToResizeRows = false;
			this.dataGridViewPlayerPositions.AutoGenerateColumns = false;
			this.dataGridViewPlayerPositions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewPlayerPositions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.positionXDataGridViewTextBoxColumn,
            this.positionYDataGridViewTextBoxColumn,
            this.positionZDataGridViewTextBoxColumn});
			this.dataGridViewPlayerPositions.DataSource = this.playerPositionBindingSource;
			this.dataGridViewPlayerPositions.Location = new System.Drawing.Point(12, 12);
			this.dataGridViewPlayerPositions.Name = "dataGridViewPlayerPositions";
			this.dataGridViewPlayerPositions.Size = new System.Drawing.Size(460, 237);
			this.dataGridViewPlayerPositions.TabIndex = 1;
			this.dataGridViewPlayerPositions.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPlayerPositions_CellEndEdit);
			this.dataGridViewPlayerPositions.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridViewPlayerPositions_CellValidating);
			// 
			// playerPositionBindingSource
			// 
			this.playerPositionBindingSource.DataSource = typeof(GettingUpTrainer.PlayerPosition);
			// 
			// Column1
			// 
			this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column1.DataPropertyName = "Name";
			this.Column1.HeaderText = "Name";
			this.Column1.MaxInputLength = 50;
			this.Column1.Name = "Column1";
			// 
			// positionXDataGridViewTextBoxColumn
			// 
			this.positionXDataGridViewTextBoxColumn.DataPropertyName = "PositionX";
			this.positionXDataGridViewTextBoxColumn.HeaderText = "X";
			this.positionXDataGridViewTextBoxColumn.MaxInputLength = 20;
			this.positionXDataGridViewTextBoxColumn.Name = "positionXDataGridViewTextBoxColumn";
			this.positionXDataGridViewTextBoxColumn.Width = 70;
			// 
			// positionYDataGridViewTextBoxColumn
			// 
			this.positionYDataGridViewTextBoxColumn.DataPropertyName = "PositionY";
			this.positionYDataGridViewTextBoxColumn.HeaderText = "Y";
			this.positionYDataGridViewTextBoxColumn.MaxInputLength = 20;
			this.positionYDataGridViewTextBoxColumn.Name = "positionYDataGridViewTextBoxColumn";
			this.positionYDataGridViewTextBoxColumn.Width = 70;
			// 
			// positionZDataGridViewTextBoxColumn
			// 
			this.positionZDataGridViewTextBoxColumn.DataPropertyName = "PositionZ";
			this.positionZDataGridViewTextBoxColumn.HeaderText = "Z";
			this.positionZDataGridViewTextBoxColumn.MaxInputLength = 20;
			this.positionZDataGridViewTextBoxColumn.Name = "positionZDataGridViewTextBoxColumn";
			this.positionZDataGridViewTextBoxColumn.Width = 70;
			// 
			// ManagePlayerPositionsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 261);
			this.Controls.Add(this.dataGridViewPlayerPositions);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ManagePlayerPositionsForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Manage Player Positions";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManagePlayerPositionsForm_FormClosed);
			this.Load += new System.EventHandler(this.ManagePlayerPositionsForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayerPositions)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.playerPositionBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.DataGridView dataGridViewPlayerPositions;
		private System.Windows.Forms.BindingSource playerPositionBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn positionXDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn positionYDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn positionZDataGridViewTextBoxColumn;
	}
}