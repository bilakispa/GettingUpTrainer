﻿namespace GettingUpTrainer.Forms
{
	partial class OverlayForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OverlayForm));
			this.SuspendLayout();
			// 
			// OverlayForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(120, 0);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "OverlayForm";
			this.Text = "OverlayForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OverlayForm_FormClosing);
			this.Load += new System.EventHandler(this.OverlayForm_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.OverlayForm_Paint);
			this.ResumeLayout(false);

		}

		#endregion
	}
}