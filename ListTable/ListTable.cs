using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;
using System.Security.Cryptography;
using System.Runtime.InteropServices;


namespace ListTable
{
	public partial class formListTable : Form
	{
		public formListTable()
		{
			InitializeComponent();
		}

		private string TableFile, ListFile, SaveFile;

		private void loadToolStripMenuItem_Click(object sender, EventArgs e)
		{
			openFileDialogList.ShowDialog();
			ListFile = openFileDialogList.FileName;
			SaveFile = openFileDialogList.FileName;
			if (openFileDialogList.FileName != "")
			{
				using (StreamReader reader = new StreamReader(ListFile))
				{
					textBoxList.Text = reader.ReadToEnd();
				}
			}
		}

		private void loadTableToolStripMenuItem_Click(object sender, EventArgs e)
		{
			openFileDialogTable.ShowDialog();
			TableFile = openFileDialogTable.FileName;
			SaveFile = openFileDialogTable.FileName;

			DataSet ds = new DataSet();
			if (openFileDialogTable.FileName != "")
			{
				ds.ReadXml(TableFile);
				DataTable dt = ds.Tables[0];
				dataGridViewTable.DataSource = dt;
			}
		}

		private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			textBoxList.Text = "";
			textBoxHeaders.Text = "";
			dataGridViewTable.DataSource = null;
			dataGridViewTable.Rows.Clear();
			dataGridViewTable.Columns.Clear();
			dataGridViewTable.Refresh();
		}

		private void saveListToolStripMenuItem_Click(object sender, EventArgs e)
		{
			saveFileDialogList.ShowDialog();
			using (StreamWriter writer = new StreamWriter(saveFileDialogList.FileName))
			{
				foreach (string line in textBoxList.Lines)
				{
					writer.WriteLine(line);
				}
			}
		}

		private void formListTable_Load(object sender, EventArgs e)
		{

		}

		private void loadToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			openFileDialogTable.ShowDialog();
			TableFile = openFileDialogTable.FileName;
			SaveFile = openFileDialogTable.FileName;

			DataSet ds = new DataSet();
			if (openFileDialogTable.FileName != "")
			{
				ds.ReadXml(TableFile);
				DataTable dt = ds.Tables[0];
				dataGridViewTable.DataSource = dt;
			}
		}

		private void loadToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			openFileDialogList.ShowDialog();
			ListFile = openFileDialogList.FileName;
			SaveFile = openFileDialogList.FileName;
			if (openFileDialogList.FileName != "")
			{
				using (StreamReader reader = new StreamReader(ListFile))
				{
					textBoxList.Text = reader.ReadToEnd();
				}
			}
		}

		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DataSet ds = new DataSet("root");
			DataTable dt = ds.Tables.Add();
			dataGridViewTable.DataSource = dt;
			dataGridViewTable.AllowUserToAddRows = true;
			dataGridViewTable.AllowUserToDeleteRows = true;
		}

		private void insertColumnToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string input = Interaction.InputBox("Type the name of the column header.", "New Column", "");
			dataGridViewTable.Columns.Add(input, input);
		}

		private void saveTableToolStripMenuItem_Click(object sender, EventArgs e)
		{

			saveFileDialogTable.ShowDialog();
			DataTable dt = (DataTable)dataGridViewTable.DataSource;
			dt = dt.Copy();
			DataSet ds = new DataSet("root");
			ds.Tables.Add(dt);
			ds.WriteXml(saveFileDialogTable.FileName);

		}

		private void textBoxHeaders_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (textBoxHeaders.Text.Length > 0)
				if (e.KeyChar == (char)Keys.Enter)
					convertListToTable();
		}

		private void copyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Clipboard.SetDataObject(dataGridViewTable.GetClipboardContent(), true);
		}

		private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			dataGridViewTable.SelectAll();
		}

		private void deleteRowToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (dataGridViewTable.CurrentRow != null)
				dataGridViewTable.Rows.RemoveAt(dataGridViewTable.CurrentRow.Index);
		}

		private void dataGridViewTable_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
		{
			try
			{
				DataGridViewCell currentcell = dataGridViewTable.CurrentCell;
				DataGridViewCell cellatindex = dataGridViewTable.Rows[e.RowIndex].Cells[e.ColumnIndex];
				if (dataGridViewTable.SelectedCells.Count <= 1 | !dataGridViewTable.SelectedCells.Contains(cellatindex))
					if (e.Button == MouseButtons.Right)
						dataGridViewTable.CurrentCell = cellatindex;
			}
			catch (Exception ex)
			{
				Console.WriteLine("[ERROR] {0}", ex.Message);
			}
		}

		private void textBoxHeaders_MouseHover(object sender, EventArgs e)
		{
			toolTipInfo.SetToolTip(sender as Control, string.Format("; (semi-colon) = seperate list items"));
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void convertListToTable()
		{
			dataGridViewTable.DataSource = null;

			DataSet ds = new DataSet("root");
			DataTable dt = ds.Tables.Add("table" + (ds.Tables.Count + 1));
			DataColumn dc = null;

			// create columns 
			foreach (string header in textBoxHeaders.Text.Split(';'))
			{
				string header_clean = header.Trim().ToUpper();
				dc = new DataColumn(header_clean);
				dt.Columns.Add(dc);
			}

			DataRow dr = null;
			foreach (string line in textBoxList.Lines)
			{
				DataColumn primary = dt.Columns[0];

				// check to see if the current line matches the primary column
				if (line.StartsWith(primary.Caption, StringComparison.CurrentCultureIgnoreCase))
				{
					Console.WriteLine("{0}: {1}", "Primary Column", primary.Caption);
					dr = dt.NewRow();
					dt.Rows.Add(dr);
				}
					
				// get the cell value for the current row[column]
				for (int i = 0; i <= dt.Columns.Count - 1; i++)
				{
					string columnname = dt.Columns[i].Caption.Trim();
					if (line.Trim().StartsWith(columnname, StringComparison.CurrentCultureIgnoreCase))
					{
						string value = line.Replace(columnname, "").Trim();
						if (dr != null)
						{
							if (dr[i].ToString().Length > 0)
								value += "; " + dr[i].ToString();
							dr[i] = value;
						}
							
					}
				}
			}

			dataGridViewTable.DataSource = dt;
		}
	}
}
