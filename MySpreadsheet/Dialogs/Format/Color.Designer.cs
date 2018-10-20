namespace MySpreadsheet.Dialogs.Format
{
    partial class Color
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
            this.textColorRed = new System.Windows.Forms.Panel();
            this.textColorSelected = new System.Windows.Forms.Panel();
            this.textColorBlack = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textColorGreen = new System.Windows.Forms.Panel();
            this.textColorOrange = new System.Windows.Forms.Panel();
            this.textColorTeal = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bgColorSelected = new System.Windows.Forms.Panel();
            this.bgColorWhite = new System.Windows.Forms.Panel();
            this.bgColorTeal = new System.Windows.Forms.Panel();
            this.bgColorLightBlue = new System.Windows.Forms.Panel();
            this.bgColorYellow = new System.Windows.Forms.Panel();
            this.bgColorSalmon = new System.Windows.Forms.Panel();
            this.textColorWhite = new System.Windows.Forms.Panel();
            this.bgColorBlack = new System.Windows.Forms.Panel();
            this.textColorDarkGray = new System.Windows.Forms.Panel();
            this.textColorLightGray = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(347, 257);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // textColorRed
            // 
            this.textColorRed.BackColor = System.Drawing.Color.Red;
            this.textColorRed.Location = new System.Drawing.Point(83, 19);
            this.textColorRed.Name = "textColorRed";
            this.textColorRed.Size = new System.Drawing.Size(20, 20);
            this.textColorRed.TabIndex = 1;
            this.textColorRed.Click += new System.EventHandler(this.textColorRed_Click);
            // 
            // textColorSelected
            // 
            this.textColorSelected.Location = new System.Drawing.Point(19, 19);
            this.textColorSelected.Name = "textColorSelected";
            this.textColorSelected.Size = new System.Drawing.Size(20, 20);
            this.textColorSelected.TabIndex = 2;
            // 
            // textColorBlack
            // 
            this.textColorBlack.BackColor = System.Drawing.Color.Black;
            this.textColorBlack.Location = new System.Drawing.Point(57, 19);
            this.textColorBlack.Name = "textColorBlack";
            this.textColorBlack.Size = new System.Drawing.Size(20, 20);
            this.textColorBlack.TabIndex = 3;
            this.textColorBlack.Click += new System.EventHandler(this.textColorBlack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textColorLightGray);
            this.groupBox1.Controls.Add(this.textColorDarkGray);
            this.groupBox1.Controls.Add(this.textColorWhite);
            this.groupBox1.Controls.Add(this.textColorGreen);
            this.groupBox1.Controls.Add(this.textColorOrange);
            this.groupBox1.Controls.Add(this.textColorTeal);
            this.groupBox1.Controls.Add(this.textColorBlack);
            this.groupBox1.Controls.Add(this.textColorRed);
            this.groupBox1.Controls.Add(this.textColorSelected);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 97);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Text color";
            // 
            // textColorGreen
            // 
            this.textColorGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textColorGreen.Location = new System.Drawing.Point(83, 45);
            this.textColorGreen.Name = "textColorGreen";
            this.textColorGreen.Size = new System.Drawing.Size(20, 20);
            this.textColorGreen.TabIndex = 6;
            this.textColorGreen.Click += new System.EventHandler(this.textColorGreen_Click);
            // 
            // textColorOrange
            // 
            this.textColorOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textColorOrange.Location = new System.Drawing.Point(109, 19);
            this.textColorOrange.Name = "textColorOrange";
            this.textColorOrange.Size = new System.Drawing.Size(20, 20);
            this.textColorOrange.TabIndex = 5;
            this.textColorOrange.Click += new System.EventHandler(this.textColorOrange_Click);
            // 
            // textColorTeal
            // 
            this.textColorTeal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textColorTeal.Location = new System.Drawing.Point(109, 45);
            this.textColorTeal.Name = "textColorTeal";
            this.textColorTeal.Size = new System.Drawing.Size(20, 20);
            this.textColorTeal.TabIndex = 4;
            this.textColorTeal.Click += new System.EventHandler(this.textColorTeal_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bgColorBlack);
            this.groupBox2.Controls.Add(this.bgColorYellow);
            this.groupBox2.Controls.Add(this.bgColorSalmon);
            this.groupBox2.Controls.Add(this.bgColorLightBlue);
            this.groupBox2.Controls.Add(this.bgColorTeal);
            this.groupBox2.Controls.Add(this.bgColorSelected);
            this.groupBox2.Controls.Add(this.bgColorWhite);
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Background color";
            // 
            // bgColorSelected
            // 
            this.bgColorSelected.Location = new System.Drawing.Point(12, 19);
            this.bgColorSelected.Name = "bgColorSelected";
            this.bgColorSelected.Size = new System.Drawing.Size(20, 20);
            this.bgColorSelected.TabIndex = 3;
            // 
            // bgColorWhite
            // 
            this.bgColorWhite.BackColor = System.Drawing.Color.White;
            this.bgColorWhite.Location = new System.Drawing.Point(52, 19);
            this.bgColorWhite.Name = "bgColorWhite";
            this.bgColorWhite.Size = new System.Drawing.Size(20, 20);
            this.bgColorWhite.TabIndex = 2;
            this.bgColorWhite.Click += new System.EventHandler(this.bgColorWhite_Click);
            // 
            // bgColorTeal
            // 
            this.bgColorTeal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bgColorTeal.Location = new System.Drawing.Point(78, 45);
            this.bgColorTeal.Name = "bgColorTeal";
            this.bgColorTeal.Size = new System.Drawing.Size(20, 20);
            this.bgColorTeal.TabIndex = 3;
            this.bgColorTeal.Click += new System.EventHandler(this.bgColorTeal_Click);
            // 
            // bgColorLightBlue
            // 
            this.bgColorLightBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bgColorLightBlue.Location = new System.Drawing.Point(78, 19);
            this.bgColorLightBlue.Name = "bgColorLightBlue";
            this.bgColorLightBlue.Size = new System.Drawing.Size(20, 20);
            this.bgColorLightBlue.TabIndex = 4;
            this.bgColorLightBlue.Click += new System.EventHandler(this.bgColorLightBlue_Click);
            // 
            // bgColorYellow
            // 
            this.bgColorYellow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bgColorYellow.Location = new System.Drawing.Point(104, 45);
            this.bgColorYellow.Name = "bgColorYellow";
            this.bgColorYellow.Size = new System.Drawing.Size(20, 20);
            this.bgColorYellow.TabIndex = 5;
            this.bgColorYellow.Click += new System.EventHandler(this.bgColorYellow_Click);
            // 
            // bgColorSalmon
            // 
            this.bgColorSalmon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bgColorSalmon.Location = new System.Drawing.Point(104, 19);
            this.bgColorSalmon.Name = "bgColorSalmon";
            this.bgColorSalmon.Size = new System.Drawing.Size(20, 20);
            this.bgColorSalmon.TabIndex = 5;
            this.bgColorSalmon.Click += new System.EventHandler(this.bgColorSalmon_Click);
            // 
            // textColorWhite
            // 
            this.textColorWhite.BackColor = System.Drawing.Color.White;
            this.textColorWhite.Location = new System.Drawing.Point(56, 45);
            this.textColorWhite.Name = "textColorWhite";
            this.textColorWhite.Size = new System.Drawing.Size(20, 20);
            this.textColorWhite.TabIndex = 7;
            this.textColorWhite.Click += new System.EventHandler(this.textColorWhite_Click);
            // 
            // bgColorBlack
            // 
            this.bgColorBlack.BackColor = System.Drawing.Color.Black;
            this.bgColorBlack.Location = new System.Drawing.Point(52, 45);
            this.bgColorBlack.Name = "bgColorBlack";
            this.bgColorBlack.Size = new System.Drawing.Size(20, 20);
            this.bgColorBlack.TabIndex = 6;
            this.bgColorBlack.Click += new System.EventHandler(this.bgColorBlack_Click);
            // 
            // textColorDarkGray
            // 
            this.textColorDarkGray.BackColor = System.Drawing.Color.Gray;
            this.textColorDarkGray.Location = new System.Drawing.Point(135, 45);
            this.textColorDarkGray.Name = "textColorDarkGray";
            this.textColorDarkGray.Size = new System.Drawing.Size(20, 20);
            this.textColorDarkGray.TabIndex = 5;
            this.textColorDarkGray.Click += new System.EventHandler(this.textColorDarkGray_Click);
            // 
            // textColorLightGray
            // 
            this.textColorLightGray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textColorLightGray.Location = new System.Drawing.Point(135, 19);
            this.textColorLightGray.Name = "textColorLightGray";
            this.textColorLightGray.Size = new System.Drawing.Size(20, 20);
            this.textColorLightGray.TabIndex = 6;
            this.textColorLightGray.Click += new System.EventHandler(this.textColorLightGray_Click);
            // 
            // Color
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 292);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Color";
            this.Text = "Color";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Panel textColorRed;
        private System.Windows.Forms.Panel textColorSelected;
        private System.Windows.Forms.Panel textColorBlack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel textColorGreen;
        private System.Windows.Forms.Panel textColorOrange;
        private System.Windows.Forms.Panel textColorTeal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel bgColorSelected;
        private System.Windows.Forms.Panel bgColorWhite;
        private System.Windows.Forms.Panel textColorWhite;
        private System.Windows.Forms.Panel bgColorBlack;
        private System.Windows.Forms.Panel bgColorYellow;
        private System.Windows.Forms.Panel bgColorSalmon;
        private System.Windows.Forms.Panel bgColorLightBlue;
        private System.Windows.Forms.Panel bgColorTeal;
        private System.Windows.Forms.Panel textColorLightGray;
        private System.Windows.Forms.Panel textColorDarkGray;
    }
}