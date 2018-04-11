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
            this.insertColumnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxList = new System.Windows.Forms.TextBox();
            this.menuStripTop = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialogList = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogTable = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogList = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialogTable = new System.Windows.Forms.SaveFileDialog();
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
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(601, 398);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // statusStripBottom
            // 
            this.statusStripBottom.Location = new System.Drawing.Point(0, 376);
            this.statusStripBottom.Name = "statusStripBottom";
            this.statusStripBottom.Size = new System.Drawing.Size(601, 22);
            this.statusStripBottom.TabIndex = 5;
            this.statusStripBottom.Text = "statusStrip1";
            // 
            // textBoxHeaders
            // 
            this.textBoxHeaders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxHeaders.Location = new System.Drawing.Point(3, 352);
            this.textBoxHeaders.Name = "textBoxHeaders";
            this.textBoxHeaders.Size = new System.Drawing.Size(595, 20);
            this.textBoxHeaders.TabIndex = 1;
            this.textBoxHeaders.TextChanged += new System.EventHandler(this.textBoxHeaders_TextChanged);
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
            this.tabControlListTable.Size = new System.Drawing.Size(595, 320);
            this.tabControlListTable.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewTable);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(587, 294);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Table";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTable
            // 
            this.dataGridViewTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTable.ContextMenuStrip = this.contextMenuStripTable;
            this.dataGridViewTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTable.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewTable.Name = "dataGridViewTable";
            this.dataGridViewTable.Size = new System.Drawing.Size(581, 288);
            this.dataGridViewTable.TabIndex = 0;
            // 
            // contextMenuStripTable
            // 
            this.contextMenuStripTable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.insertColumnToolStripMenuItem,
            this.deleteRowToolStripMenuItem,
            this.selectAllToolStripMenuItem});
            this.contextMenuStripTable.Name = "contextMenuStripTable";
            this.contextMenuStripTable.Size = new System.Drawing.Size(150, 92);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.copyToolStripMenuItem.Text = "Copy";
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
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBoxList);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(587, 294);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "List";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxList
            // 
            this.textBoxList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxList.Location = new System.Drawing.Point(3, 3);
            this.textBoxList.Multiline = true;
            this.textBoxList.Name = "textBoxList";
            this.textBoxList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxList.Size = new System.Drawing.Size(581, 288);
            this.textBoxList.TabIndex = 0;
            this.textBoxList.TextChanged += new System.EventHandler(this.textBoxList_TextChanged);
            // 
            // menuStripTop
            // 
            this.menuStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.tableToolStripMenuItem,
            this.listToolStripMenuItem});
            this.menuStripTop.Location = new System.Drawing.Point(0, 0);
            this.menuStripTop.Name = "menuStripTop";
            this.menuStripTop.Size = new System.Drawing.Size(601, 23);
            this.menuStripTop.TabIndex = 3;
            this.menuStripTop.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
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
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveListToolStripMenuItem
            // 
            this.saveListToolStripMenuItem.Name = "saveListToolStripMenuItem";
            this.saveListToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.saveListToolStripMenuItem.Text = "Save List As...";
            this.saveListToolStripMenuItem.Click += new System.EventHandler(this.saveListToolStripMenuItem_Click);
            // 
            // saveTableToolStripMenuItem
            // 
            this.saveTableToolStripMenuItem.Name = "saveTableToolStripMenuItem";
            this.saveTableToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.saveTableToolStripMenuItem.Text = "Save Table As...";
            this.saveTableToolStripMenuItem.Click += new System.EventHandler(this.saveTableToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(151, 6);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.loadToolStripMenuItem.Text = "Load List...";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // loadTableToolStripMenuItem
            // 
            this.loadTableToolStripMenuItem.Name = "loadTableToolStripMenuItem";
            this.loadTableToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.loadTableToolStripMenuItem.Text = "Load Table...";
            this.loadTableToolStripMenuItem.Click += new System.EventHandler(this.loadTableToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(151, 6);
            // 
            // clearAllToolStripMenuItem
            // 
            this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.clearAllToolStripMenuItem.Text = "Clear All";
            this.clearAllToolStripMenuItem.Click += new System.EventHandler(this.clearAllToolStripMenuItem_Click);
            // 
            // tableToolStripMenuItem
            // 
            this.tableToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.loadToolStripMenuItem1});
            this.tableToolStripMenuItem.Name = "tableToolStripMenuItem";
            this.tableToolStripMenuItem.Size = new System.Drawing.Size(47, 19);
            this.tableToolStripMenuItem.Text = "Table";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem1
            // 
            this.loadToolStripMenuItem1.Name = "loadToolStripMenuItem1";
            this.loadToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem1.Text = "Load";
            this.loadToolStripMenuItem1.Click += new System.EventHandler(this.loadToolStripMenuItem1_Click);
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem1,
            this.loadToolStripMenuItem2});
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.listToolStripMenuItem.Text = "List";
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            this.newToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.newToolStripMenuItem1.Text = "New";
            // 
            // loadToolStripMenuItem2
            // 
            this.loadToolStripMenuItem2.Name = "loadToolStripMenuItem2";
            this.loadToolStripMenuItem2.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem2.Text = "Load";
            this.loadToolStripMenuItem2.Click += new System.EventHandler(this.loadToolStripMenuItem2_Click);
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
            this.ClientSize = new System.Drawing.Size(601, 398);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.MainMenuStrip = this.menuStripTop;
            this.MinimumSize = new System.Drawing.Size(617, 437);
            this.Name = "formListTable";
            this.Text = "List Table";
            this.Load += new System.EventHandler(this.formListTable_Load);
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
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTable;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertColumnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteRowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
    }
}

