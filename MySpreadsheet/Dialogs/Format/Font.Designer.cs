namespace MySpreadsheet.Dialogs.Format
{
    partial class Font
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
            this.cbBold = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.lbFontName = new System.Windows.Forms.ListBox();
            this.lbFontSize = new System.Windows.Forms.ListBox();
            this.cbItalic = new System.Windows.Forms.CheckBox();
            this.cbStrikethrough = new System.Windows.Forms.CheckBox();
            this.cbUnderline = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cbBold
            // 
            this.cbBold.AutoSize = true;
            this.cbBold.Location = new System.Drawing.Point(12, 12);
            this.cbBold.Name = "cbBold";
            this.cbBold.Size = new System.Drawing.Size(47, 17);
            this.cbBold.TabIndex = 0;
            this.cbBold.Text = "Bold";
            this.cbBold.UseVisualStyleBackColor = true;
            this.cbBold.CheckedChanged += new System.EventHandler(this.cbBold_CheckedChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(220, 152);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lbFontName
            // 
            this.lbFontName.FormattingEnabled = true;
            this.lbFontName.Items.AddRange(new object[] {
            "Arial",
            "Batang",
            "Book Antiqua",
            "Calibri",
            "Courier New",
            "Palatino Linotype",
            "Tahoma",
            "Times New Roman"});
            this.lbFontName.Location = new System.Drawing.Point(132, 12);
            this.lbFontName.Name = "lbFontName";
            this.lbFontName.Size = new System.Drawing.Size(163, 56);
            this.lbFontName.TabIndex = 2;
            this.lbFontName.SelectedValueChanged += new System.EventHandler(this.lbFontName_SelectedValueChanged);
            // 
            // lbFontSize
            // 
            this.lbFontSize.FormattingEnabled = true;
            this.lbFontSize.Items.AddRange(new object[] {
            "5",
            "8",
            "10.25",
            "12",
            "14",
            "16",
            "18",
            "22",
            "25",
            "30",
            "40"});
            this.lbFontSize.Location = new System.Drawing.Point(132, 74);
            this.lbFontSize.Name = "lbFontSize";
            this.lbFontSize.Size = new System.Drawing.Size(163, 56);
            this.lbFontSize.TabIndex = 3;
            this.lbFontSize.SelectedValueChanged += new System.EventHandler(this.lbFontSize_SelectedValueChanged);
            // 
            // cbItalic
            // 
            this.cbItalic.AutoSize = true;
            this.cbItalic.Location = new System.Drawing.Point(12, 29);
            this.cbItalic.Name = "cbItalic";
            this.cbItalic.Size = new System.Drawing.Size(48, 17);
            this.cbItalic.TabIndex = 4;
            this.cbItalic.Text = "Italic";
            this.cbItalic.UseVisualStyleBackColor = true;
            this.cbItalic.CheckedChanged += new System.EventHandler(this.cbItalic_CheckedChanged);
            // 
            // cbStrikethrough
            // 
            this.cbStrikethrough.AutoSize = true;
            this.cbStrikethrough.Location = new System.Drawing.Point(12, 62);
            this.cbStrikethrough.Name = "cbStrikethrough";
            this.cbStrikethrough.Size = new System.Drawing.Size(89, 17);
            this.cbStrikethrough.TabIndex = 5;
            this.cbStrikethrough.Text = "Strikethrough";
            this.cbStrikethrough.UseVisualStyleBackColor = true;
            this.cbStrikethrough.CheckedChanged += new System.EventHandler(this.cbStrikethrough_CheckedChanged);
            // 
            // cbUnderline
            // 
            this.cbUnderline.AutoSize = true;
            this.cbUnderline.Location = new System.Drawing.Point(12, 45);
            this.cbUnderline.Name = "cbUnderline";
            this.cbUnderline.Size = new System.Drawing.Size(71, 17);
            this.cbUnderline.TabIndex = 6;
            this.cbUnderline.Text = "Underline";
            this.cbUnderline.UseVisualStyleBackColor = true;
            this.cbUnderline.CheckedChanged += new System.EventHandler(this.cbUnderline_CheckedChanged);
            // 
            // Font
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 190);
            this.Controls.Add(this.cbUnderline);
            this.Controls.Add(this.cbStrikethrough);
            this.Controls.Add(this.cbItalic);
            this.Controls.Add(this.lbFontSize);
            this.Controls.Add(this.lbFontName);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbBold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Font";
            this.Text = "Font";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbBold;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ListBox lbFontName;
        private System.Windows.Forms.ListBox lbFontSize;
        private System.Windows.Forms.CheckBox cbItalic;
        private System.Windows.Forms.CheckBox cbStrikethrough;
        private System.Windows.Forms.CheckBox cbUnderline;
    }
}