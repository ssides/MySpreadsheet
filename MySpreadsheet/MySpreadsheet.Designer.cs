namespace MySpreadsheet
{
    partial class MySpreadsheet
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workbook = new unvell.ReoGrid.ReoGridControl();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertDateAsNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertDateToNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem1,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "&New Workbook";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.NewWorksheetToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "&Open Sheet";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem1.Text = "&Save Sheet";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.SaveSheetToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Save Sheet &As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cellToolStripMenuItem,
            this.colorToolStripMenuItem,
            this.numberToolStripMenuItem,
            this.bordersToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.formatToolStripMenuItem.Text = "F&ormat";
            // 
            // cellToolStripMenuItem
            // 
            this.cellToolStripMenuItem.Name = "cellToolStripMenuItem";
            this.cellToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cellToolStripMenuItem.Text = "&Font";
            this.cellToolStripMenuItem.Click += new System.EventHandler(this.FormatCellToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colorToolStripMenuItem.Text = "&Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.ColorToolStripMenuItem_Click);
            // 
            // numberToolStripMenuItem
            // 
            this.numberToolStripMenuItem.Name = "numberToolStripMenuItem";
            this.numberToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.numberToolStripMenuItem.Text = "&Number/Date";
            this.numberToolStripMenuItem.Click += new System.EventHandler(this.NumberToolStripMenuItem_Click);
            // 
            // bordersToolStripMenuItem
            // 
            this.bordersToolStripMenuItem.Name = "bordersToolStripMenuItem";
            this.bordersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bordersToolStripMenuItem.Text = "&Borders";
            this.bordersToolStripMenuItem.Click += new System.EventHandler(this.bordersToolStripMenuItem_Click);
            // 
            // workbook
            // 
            this.workbook.BackColor = System.Drawing.Color.White;
            this.workbook.ColumnHeaderContextMenuStrip = null;
            this.workbook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workbook.LeadHeaderContextMenuStrip = null;
            this.workbook.Location = new System.Drawing.Point(0, 24);
            this.workbook.Name = "workbook";
            this.workbook.RowHeaderContextMenuStrip = null;
            this.workbook.Script = null;
            this.workbook.SheetTabContextMenuStrip = null;
            this.workbook.SheetTabNewButtonVisible = true;
            this.workbook.SheetTabVisible = true;
            this.workbook.SheetTabWidth = 160;
            this.workbook.ShowScrollEndSpacing = true;
            this.workbook.Size = new System.Drawing.Size(800, 426);
            this.workbook.TabIndex = 1;
            this.workbook.Text = "MySpreadsheet";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // dateToolStripMenuItem
            // 
            this.dateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertDateAsNumberToolStripMenuItem,
            this.convertDateToNumberToolStripMenuItem});
            this.dateToolStripMenuItem.Name = "dateToolStripMenuItem";
            this.dateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dateToolStripMenuItem.Text = "&Date";
            // 
            // insertDateAsNumberToolStripMenuItem
            // 
            this.insertDateAsNumberToolStripMenuItem.Name = "insertDateAsNumberToolStripMenuItem";
            this.insertDateAsNumberToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.insertDateAsNumberToolStripMenuItem.Text = "Insert &Today\'s Date";
            this.insertDateAsNumberToolStripMenuItem.Click += new System.EventHandler(this.insertDateAsNumberToolStripMenuItem_Click);
            // 
            // convertDateToNumberToolStripMenuItem
            // 
            this.convertDateToNumberToolStripMenuItem.Name = "convertDateToNumberToolStripMenuItem";
            this.convertDateToNumberToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.convertDateToNumberToolStripMenuItem.Text = "&Convert Date to Number";
            this.convertDateToNumberToolStripMenuItem.Click += new System.EventHandler(this.convertDateToNumberToolStripMenuItem_Click);
            // 
            // MySpreadsheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.workbook);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MySpreadsheet";
            this.Text = "MySpreadsheet";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private unvell.ReoGrid.ReoGridControl workbook;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertDateAsNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertDateToNumberToolStripMenuItem;
    }
}

