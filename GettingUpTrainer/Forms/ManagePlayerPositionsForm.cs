using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GettingUpTrainer.Forms
{
	public partial class ManagePlayerPositionsForm : Form
	{
		public ManagePlayerPositionsForm()
		{
			InitializeComponent();
		}

		private void ManagePlayerPositionsForm_Load(object sender, EventArgs e)
		{
			// Load player positions from settings
			PlayerPositionCollection playerPositions = Properties.Settings.Default.PlayerPositions;

			if (playerPositions != null) {
				foreach (PlayerPosition playerPosition in playerPositions.PlayerPositions) {
					playerPositionBindingSource.Add(playerPosition);
				}
			}
		}

		private void ManagePlayerPositionsForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			// Save player positions to settings
			PlayerPositionCollection playerPositions = new PlayerPositionCollection();

			foreach(DataGridViewRow row in dataGridViewPlayerPositions.Rows) {
				if (row.DataBoundItem != null) {
					playerPositions.PlayerPositions.Add((PlayerPosition)row.DataBoundItem);
				}
			}

			Properties.Settings.Default.PlayerPositions = playerPositions;
			Properties.Settings.Default.Save();
		}

		private void dataGridViewPlayerPositions_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			string headerText = dataGridViewPlayerPositions.Columns[e.ColumnIndex].HeaderText;

			if (headerText.Equals("Name")) { // Matches with the Name column which is string
				return;
			}

			float output;

			if (!float.TryParse(e.FormattedValue.ToString(), out output)) {
				dataGridViewPlayerPositions.Rows[e.RowIndex].ErrorText = "Value must be a floating point number";
				e.Cancel = true;
			}
		}

		private void dataGridViewPlayerPositions_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			dataGridViewPlayerPositions.Rows[e.RowIndex].ErrorText = string.Empty;
		}
	}
}
