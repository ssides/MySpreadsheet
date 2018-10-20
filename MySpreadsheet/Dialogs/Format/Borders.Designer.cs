namespace MySpreadsheet.Dialogs.Format
{
    partial class Borders
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
            this.cbTop = new System.Windows.Forms.CheckBox();
            this.cbLeft = new System.Windows.Forms.CheckBox();
            this.cbRight = new System.Windows.Forms.CheckBox();
            this.cbBottom = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.borderColorLightGray = new System.Windows.Forms.Panel();
            this.borderColorDarkGray = new System.Windows.Forms.Panel();
            this.borderColorYellow = new System.Windows.Forms.Panel();
            this.borderColorGreen = new System.Windows.Forms.Panel();
            this.borderColorOrange = new System.Windows.Forms.Panel();
            this.borderColorTeal = new System.Windows.Forms.Panel();
            this.borderColorBlack = new System.Windows.Forms.Panel();
            this.borderColorRed = new System.Windows.Forms.Panel();
            this.borderColorSelected = new System.Windows.Forms.Panel();
            this.lbLineStyle = new System.Windows.Forms.ListBox();
            this.label = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(339, 205);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cbTop
            // 
            this.cbTop.AutoSize = true;
            this.cbTop.Location = new System.Drawing.Point(89, 13);
            this.cbTop.Name = "cbTop";
            this.cbTop.Size = new System.Drawing.Size(45, 17);
            this.cbTop.TabIndex = 1;
            this.cbTop.Text = "Top";
            this.cbTop.UseVisualStyleBackColor = true;
            // 
            // cbLeft
            // 
            this.cbLeft.AutoSize = true;
            this.cbLeft.Location = new System.Drawing.Point(31, 46);
            this.cbLeft.Name = "cbLeft";
            this.cbLeft.Size = new System.Drawing.Size(44, 17);
            this.cbLeft.TabIndex = 2;
            this.cbLeft.Text = "Left";
            this.cbLeft.UseVisualStyleBackColor = true;
            // 
            // cbRight
            // 
            this.cbRight.AutoSize = true;
            this.cbRight.Location = new System.Drawing.Point(137, 46);
            this.cbRight.Name = "cbRight";
            this.cbRight.Size = new System.Drawing.Size(51, 17);
            this.cbRight.TabIndex = 3;
            this.cbRight.Text = "Right";
            this.cbRight.UseVisualStyleBackColor = true;
            // 
            // cbBottom
            // 
            this.cbBottom.AutoSize = true;
            this.cbBottom.Location = new System.Drawing.Point(89, 74);
            this.cbBottom.Name = "cbBottom";
            this.cbBottom.Size = new System.Drawing.Size(59, 17);
            this.cbBottom.TabIndex = 4;
            this.cbBottom.Text = "Bottom";
            this.cbBottom.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.borderColorLightGray);
            this.groupBox1.Controls.Add(this.borderColorDarkGray);
            this.groupBox1.Controls.Add(this.borderColorYellow);
            this.groupBox1.Controls.Add(this.borderColorGreen);
            this.groupBox1.Controls.Add(this.borderColorOrange);
            this.groupBox1.Controls.Add(this.borderColorTeal);
            this.groupBox1.Controls.Add(this.borderColorBlack);
            this.groupBox1.Controls.Add(this.borderColorRed);
            this.groupBox1.Controls.Add(this.borderColorSelected);
            this.groupBox1.Location = new System.Drawing.Point(215, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 79);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color";
            // 
            // borderColorLightGray
            // 
            this.borderColorLightGray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.borderColorLightGray.Location = new System.Drawing.Point(135, 19);
            this.borderColorLightGray.Name = "borderColorLightGray";
            this.borderColorLightGray.Size = new System.Drawing.Size(20, 20);
            this.borderColorLightGray.TabIndex = 6;
            this.borderColorLightGray.Click += new System.EventHandler(this.borderColorLightGray_Click);
            // 
            // borderColorDarkGray
            // 
            this.borderColorDarkGray.BackColor = System.Drawing.Color.Gray;
            this.borderColorDarkGray.Location = new System.Drawing.Point(135, 45);
            this.borderColorDarkGray.Name = "borderColorDarkGray";
            this.borderColorDarkGray.Size = new System.Drawing.Size(20, 20);
            this.borderColorDarkGray.TabIndex = 5;
            this.borderColorDarkGray.Click += new System.EventHandler(this.borderColorDarkGray_Click);
            // 
            // borderColorYellow
            // 
            this.borderColorYellow.BackColor = System.Drawing.Color.Yellow;
            this.borderColorYellow.Location = new System.Drawing.Point(56, 45);
            this.borderColorYellow.Name = "borderColorYellow";
            this.borderColorYellow.Size = new System.Drawing.Size(20, 20);
            this.borderColorYellow.TabIndex = 7;
            this.borderColorYellow.Click += new System.EventHandler(this.borderColorYellow_Click);
            // 
            // borderColorGreen
            // 
            this.borderColorGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.borderColorGreen.Location = new System.Drawing.Point(83, 45);
            this.borderColorGreen.Name = "borderColorGreen";
            this.borderColorGreen.Size = new System.Drawing.Size(20, 20);
            this.borderColorGreen.TabIndex = 6;
            this.borderColorGreen.Click += new System.EventHandler(this.borderColorGreen_Click);
            // 
            // borderColorOrange
            // 
            this.borderColorOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.borderColorOrange.Location = new System.Drawing.Point(109, 19);
            this.borderColorOrange.Name = "borderColorOrange";
            this.borderColorOrange.Size = new System.Drawing.Size(20, 20);
            this.borderColorOrange.TabIndex = 5;
            this.borderColorOrange.Click += new System.EventHandler(this.borderColorOrange_Click);
            // 
            // borderColorTeal
            // 
            this.borderColorTeal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.borderColorTeal.Location = new System.Drawing.Point(109, 45);
            this.borderColorTeal.Name = "borderColorTeal";
            this.borderColorTeal.Size = new System.Drawing.Size(20, 20);
            this.borderColorTeal.TabIndex = 4;
            this.borderColorTeal.Click += new System.EventHandler(this.borderColorTeal_Click);
            // 
            // borderColorBlack
            // 
            this.borderColorBlack.BackColor = System.Drawing.Color.Black;
            this.borderColorBlack.Location = new System.Drawing.Point(57, 19);
            this.borderColorBlack.Name = "borderColorBlack";
            this.borderColorBlack.Size = new System.Drawing.Size(20, 20);
            this.borderColorBlack.TabIndex = 3;
            this.borderColorBlack.Click += new System.EventHandler(this.borderColorBlack_Click);
            // 
            // borderColorRed
            // 
            this.borderColorRed.BackColor = System.Drawing.Color.Red;
            this.borderColorRed.Location = new System.Drawing.Point(83, 19);
            this.borderColorRed.Name = "borderColorRed";
            this.borderColorRed.Size = new System.Drawing.Size(20, 20);
            this.borderColorRed.TabIndex = 1;
            this.borderColorRed.Click += new System.EventHandler(this.borderColorRed_Click);
            // 
            // borderColorSelected
            // 
            this.borderColorSelected.BackColor = System.Drawing.Color.Black;
            this.borderColorSelected.Location = new System.Drawing.Point(19, 19);
            this.borderColorSelected.Name = "borderColorSelected";
            this.borderColorSelected.Size = new System.Drawing.Size(20, 20);
            this.borderColorSelected.TabIndex = 2;
            // 
            // lbLineStyle
            // 
            this.lbLineStyle.FormattingEnabled = true;
            this.lbLineStyle.Location = new System.Drawing.Point(55, 121);
            this.lbLineStyle.Name = "lbLineStyle";
            this.lbLineStyle.Size = new System.Drawing.Size(120, 95);
            this.lbLineStyle.TabIndex = 6;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(52, 105);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(54, 13);
            this.label.TabIndex = 7;
            this.label.Text = "Line style:";
            // 
            // Borders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 240);
            this.Controls.Add(this.label);
            this.Controls.Add(this.lbLineStyle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbBottom);
            this.Controls.Add(this.cbRight);
            this.Controls.Add(this.cbLeft);
            this.Controls.Add(this.cbTop);
            this.Controls.Add(this.btnOK);
            this.Name = "Borders";
            this.Text = "Borders";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.CheckBox cbTop;
        private System.Windows.Forms.CheckBox cbLeft;
        private System.Windows.Forms.CheckBox cbRight;
        private System.Windows.Forms.CheckBox cbBottom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel borderColorLightGray;
        private System.Windows.Forms.Panel borderColorDarkGray;
        private System.Windows.Forms.Panel borderColorYellow;
        private System.Windows.Forms.Panel borderColorGreen;
        private System.Windows.Forms.Panel borderColorOrange;
        private System.Windows.Forms.Panel borderColorTeal;
        private System.Windows.Forms.Panel borderColorBlack;
        private System.Windows.Forms.Panel borderColorRed;
        private System.Windows.Forms.Panel borderColorSelected;
        private System.Windows.Forms.ListBox lbLineStyle;
        private System.Windows.Forms.Label label;
    }
}