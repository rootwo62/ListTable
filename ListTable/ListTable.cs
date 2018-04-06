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

namespace ListTable
{
    public partial class formListTable : Form
    {
        public formListTable()
        {
            InitializeComponent();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialogList.ShowDialog();

            using (StreamReader reader = new StreamReader(openFileDialogList.FileName))
            {
                textBoxList.Text = reader.ReadToEnd();
            }
        }

        private void loadTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialogTable.ShowDialog();
            DataSet ds = new DataSet();
            ds.ReadXml(openFileDialogTable.FileName);
            DataTable dt = ds.Tables[1];
            dataGridViewTable.DataSource = dt ;
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

        private void saveTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialogTable.ShowDialog();
            DataTable dt = (DataTable)dataGridViewTable.DataSource;
            dt.WriteXml(saveFileDialogTable.FileName);
        }
    }
}
