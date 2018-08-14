namespace ListTable
{
    partial class formListTable
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
            if (disposing && (components != null))
            {
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
			this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
			this.statusStripBottom = new System.Windows.Forms.StatusStrip();
			this.textBoxHeaders = new System.Windows.Forms.TextBox();
			this.tabControlListTable = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.dataGridViewTable = new System.Windows.Forms.DataGridView();
			this.contextMenuStripTable = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.insertColumnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.textBoxList = new System.Windows.Forms.TextBox();
			this.menuStripTop = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openFileDialogList = new System.Windows.Forms.OpenFileDialog();
			this.openFileDialogTable = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialogList = new System.Windows.Forms.SaveFileDialog();
			this.saveFileDialogTable = new System.Windows.Forms.SaveFileDialog();
			this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
			this.tableLayoutPanelMain.SuspendLayout();
			this.tabControlListTable.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).BeginInit();
			this.contextMenuStripTable.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.menuStripTop.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanelMain
			// 
			this.tableLayoutPanelMain.ColumnCount = 1;
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelMain.Controls.Add(this.statusStripBottom, 0, 3);
			this.tableLayoutPanelMain.Controls.Add(this.textBoxHeaders, 0, 2);
			this.tableLayoutPanelMain.Controls.Add(this.tabControlListTable, 0, 1);
			this.tableLayoutPanelMain.Controls.Add(this.menuStripTop, 0, 0);
			this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
			this.tableLayoutPanelMain.RowCount = 4;
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
			this.tableLayoutPanelMain.Size = new System.Drawing.Size(1021, 690);
			this.tableLayoutPanelMain.TabIndex = 0;
			// 
			// statusStripBottom
			// 
			this.statusStripBottom.Location = new System.Drawing.Point(0, 668);
			this.statusStripBottom.Name = "statusStripBottom";
			this.statusStripBottom.Size = new System.Drawing.Size(1021, 22);
			this.statusStripBottom.TabIndex = 5;
			this.statusStripBottom.Text = "statusStrip1";
			// 
			// textBoxHeaders
			// 
			this.textBoxHeaders.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxHeaders.Location = new System.Drawing.Point(3, 644);
			this.textBoxHeaders.Name = "textBoxHeaders";
			this.textBoxHeaders.Size = new System.Drawing.Size(1015, 20);
			this.textBoxHeaders.TabIndex = 1;
			this.textBoxHeaders.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHeaders_KeyPress);
			this.textBoxHeaders.MouseHover += new System.EventHandler(this.textBoxHeaders_MouseHover);
			// 
			// tabControlListTable
			// 
			this.tabControlListTable.Controls.Add(this.tabPage1);
			this.tabControlListTable.Controls.Add(this.tabPage2);
			this.tabControlListTable.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControlListTable.Location = new System.Drawing.Point(3, 26);
			this.tabControlListTable.Name = "tabControlListTable";
			this.tabControlListTable.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.tabControlListTable.SelectedIndex = 0;
			this.tabControlListTable.Size = new System.Drawing.Size(1015, 612);
			this.tabControlListTable.TabIndex = 2;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.dataGridViewTable);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1007, 586);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Table";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// dataGridViewTable
			// 
			this.dataGridViewTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewTable.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
			this.dataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewTable.ContextMenuStrip = this.contextMenuStripTable;
			this.dataGridViewTable.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewTable.Location = new System.Drawing.Point(3, 3);
			this.dataGridViewTable.Name = "dataGridViewTable";
			this.dataGridViewTable.Size = new System.Drawing.Size(1001, 580);
			this.dataGridViewTable.TabIndex = 0;
			this.dataGridViewTable.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewTable_CellMouseDown);
			// 
			// contextMenuStripTable
			// 
			this.contextMenuStripTable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.selectAllToolStripMenuItem,
            this.toolStripSeparator3,
            this.insertColumnToolStripMenuItem,
            this.deleteRowToolStripMenuItem});
			this.contextMenuStripTable.Name = "contextMenuStripTable";
			this.contextMenuStripTable.Size = new System.Drawing.Size(150, 98);
			// 
			// copyToolStripMenuItem
			// 
			this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
			this.copyToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
			this.copyToolStripMenuItem.Text = "Copy";
			this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
			// 
			// selectAllToolStripMenuItem
			// 
			this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
			this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
			this.selectAllToolStripMenuItem.Text = "Select All";
			this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(146, 6);
			// 
			// insertColumnToolStripMenuItem
			// 
			this.insertColumnToolStripMenuItem.Name = "insertColumnToolStripMenuItem";
			this.insertColumnToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
			this.insertColumnToolStripMenuItem.Text = "Insert Column";
			this.insertColumnToolStripMenuItem.Click += new System.EventHandler(this.insertColumnToolStripMenuItem_Click);
			// 
			// deleteRowToolStripMenuItem
			// 
			this.deleteRowToolStripMenuItem.Name = "deleteRowToolStripMenuItem";
			this.deleteRowToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
			this.deleteRowToolStripMenuItem.Text = "Delete Row";
			this.deleteRowToolStripMenuItem.Click += new System.EventHandler(this.deleteRowToolStripMenuItem_Click);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.textBoxList);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1007, 586);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "List";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// textBoxList
			// 
			this.textBoxList.AcceptsTab = true;
			this.textBoxList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxList.Location = new System.Drawing.Point(3, 3);
			this.textBoxList.Multiline = true;
			this.textBoxList.Name = "textBoxList";
			this.textBoxList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBoxList.Size = new System.Drawing.Size(1001, 580);
			this.textBoxList.TabIndex = 0;
			// 
			// menuStripTop
			// 
			this.menuStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStripTop.Location = new System.Drawing.Point(0, 0);
			this.menuStripTop.Name = "menuStripTop";
			this.menuStripTop.Size = new System.Drawing.Size(1021, 23);
			this.menuStripTop.TabIndex = 3;
			this.menuStripTop.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveListToolStripMenuItem,
            this.saveTableToolStripMenuItem,
            this.toolStripSeparator1,
            this.loadToolStripMenuItem,
            this.loadTableToolStripMenuItem,
            this.toolStripSeparator2,
            this.clearAllToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// saveListToolStripMenuItem
			// 
			this.saveListToolStripMenuItem.Name = "saveListToolStripMenuItem";
			this.saveListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.saveListToolStripMenuItem.Text = "Save List As...";
			this.saveListToolStripMenuItem.Click += new System.EventHandler(this.saveListToolStripMenuItem_Click);
			// 
			// saveTableToolStripMenuItem
			// 
			this.saveTableToolStripMenuItem.Name = "saveTableToolStripMenuItem";
			this.saveTableToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.saveTableToolStripMenuItem.Text = "Save Table As...";
			this.saveTableToolStripMenuItem.Click += new System.EventHandler(this.saveTableToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
			// 
			// loadToolStripMenuItem
			// 
			this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
			this.loadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.loadToolStripMenuItem.Text = "Load List...";
			this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
			// 
			// loadTableToolStripMenuItem
			// 
			this.loadTableToolStripMenuItem.Name = "loadTableToolStripMenuItem";
			this.loadTableToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.loadTableToolStripMenuItem.Text = "Load Table...";
			this.loadTableToolStripMenuItem.Click += new System.EventHandler(this.loadTableToolStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
			// 
			// clearAllToolStripMenuItem
			// 
			this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
			this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.clearAllToolStripMenuItem.Text = "Clear All";
			this.clearAllToolStripMenuItem.Click += new System.EventHandler(this.clearAllToolStripMenuItem_Click);
			// 
			// openFileDialogList
			// 
			this.openFileDialogList.Filter = "Text File|*.txt";
			// 
			// openFileDialogTable
			// 
			this.openFileDialogTable.Filter = "Xml File|*.xml|Dataset File|*.xsd";
			// 
			// saveFileDialogList
			// 
			this.saveFileDialogList.Filter = "Text File|*.txt";
			// 
			// saveFileDialogTable
			// 
			this.saveFileDialogTable.Filter = "Xml File|*.xml|Dataset File|*.xsd";
			// 
			// formListTable
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1021, 690);
			this.Controls.Add(this.tableLayoutPanelMain);
			this.MainMenuStrip = this.menuStripTop;
			this.MinimumSize = new System.Drawing.Size(617, 437);
			this.Name = "formListTable";
			this.Text = "List Table";
			this.tableLayoutPanelMain.ResumeLayout(false);
			this.tableLayoutPanelMain.PerformLayout();
			this.tabControlListTable.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).EndInit();
			this.contextMenuStripTable.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.menuStripTop.ResumeLayout(false);
			this.menuStripTop.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.TextBox textBoxHeaders;
        private System.Windows.Forms.TabControl tabControlListTable;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewTable;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxList;
        private System.Windows.Forms.MenuStrip menuStripTop;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStripBottom;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem loadTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialogList;
        private System.Windows.Forms.OpenFileDialog openFileDialogTable;
        private System.Windows.Forms.SaveFileDialog saveFileDialogList;
        private System.Windows.Forms.SaveFileDialog saveFileDialogTable;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTable;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertColumnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteRowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolTip toolTipInfo;
	}
}

