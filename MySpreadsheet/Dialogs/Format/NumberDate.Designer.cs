namespace MySpreadsheet.Dialogs.Format
{
    partial class NumberDate
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
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDate = new System.Windows.Forms.RadioButton();
            this.cbUseComma = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDecimalPlaces = new System.Windows.Forms.TextBox();
            this.rbNumber = new System.Windows.Forms.RadioButton();
            this.rbText = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(119, 160);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDate);
            this.groupBox1.Controls.Add(this.cbUseComma);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbDecimalPlaces);
            this.groupBox1.Controls.Add(this.rbNumber);
            this.groupBox1.Controls.Add(this.rbText);
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 133);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Format";
            // 
            // rbDate
            // 
            this.rbDate.AutoSize = true;
            this.rbDate.Location = new System.Drawing.Point(103, 24);
            this.rbDate.Name = "rbDate";
            this.rbDate.Size = new System.Drawing.Size(48, 17);
            this.rbDate.TabIndex = 7;
            this.rbDate.TabStop = true;
            this.rbDate.Text = "&Date";
            this.rbDate.UseVisualStyleBackColor = true;
            this.rbDate.CheckedChanged += new System.EventHandler(this.rbDate_CheckedChanged);
            // 
            // cbUseComma
            // 
            this.cbUseComma.AutoSize = true;
            this.cbUseComma.Enabled = false;
            this.cbUseComma.Location = new System.Drawing.Point(183, 96);
            this.cbUseComma.Name = "cbUseComma";
            this.cbUseComma.Size = new System.Drawing.Size(82, 17);
            this.cbUseComma.TabIndex = 6;
            this.cbUseComma.Text = "&Use comma";
            this.cbUseComma.UseVisualStyleBackColor = true;
            this.cbUseComma.CheckedChanged += new System.EventHandler(this.cbUseComma_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Decimal places";
            // 
            // tbDecimalPlaces
            // 
            this.tbDecimalPlaces.Enabled = false;
            this.tbDecimalPlaces.Location = new System.Drawing.Point(182, 70);
            this.tbDecimalPlaces.Name = "tbDecimalPlaces";
            this.tbDecimalPlaces.Size = new System.Drawing.Size(80, 20);
            this.tbDecimalPlaces.TabIndex = 3;
            this.tbDecimalPlaces.Text = "0";
            this.tbDecimalPlaces.TextChanged += new System.EventHandler(this.tbDecimalPlaces_TextChanged);
            // 
            // rbNumber
            // 
            this.rbNumber.AutoSize = true;
            this.rbNumber.Location = new System.Drawing.Point(183, 24);
            this.rbNumber.Name = "rbNumber";
            this.rbNumber.Size = new System.Drawing.Size(62, 17);
            this.rbNumber.TabIndex = 2;
            this.rbNumber.Text = "&Number";
            this.rbNumber.UseVisualStyleBackColor = true;
            this.rbNumber.CheckedChanged += new System.EventHandler(this.rbNumber_CheckedChanged);
            // 
            // rbText
            // 
            this.rbText.AutoSize = true;
            this.rbText.Checked = true;
            this.rbText.Location = new System.Drawing.Point(22, 24);
            this.rbText.Name = "rbText";
            this.rbText.Size = new System.Drawing.Size(46, 17);
            this.rbText.TabIndex = 0;
            this.rbText.TabStop = true;
            this.rbText.Text = "&Text";
            this.rbText.UseVisualStyleBackColor = true;
            this.rbText.CheckedChanged += new System.EventHandler(this.rbText_CheckedChanged);
            // 
            // NumberDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 195);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NumberDate";
            this.Text = "Number Date";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNumber;
        private System.Windows.Forms.RadioButton rbText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDecimalPlaces;
        private System.Windows.Forms.CheckBox cbUseComma;
        private System.Windows.Forms.RadioButton rbDate;
    }
}