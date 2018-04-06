using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            

        }

        private void loadTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialogTable.ShowDialog();
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxList.Text = "";
            textBoxHeaders.Text = "";
            dataGridViewTable.DataSource = null;
        }
    }
}
