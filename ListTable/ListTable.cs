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

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
