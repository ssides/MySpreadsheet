using System;
using System.Windows.Forms;
using unvell.ReoGrid;
using unvell.ReoGrid.Graphics;

namespace MySpreadsheet.Dialogs.Format
{
    public partial class Color : Form
    {
        public WorksheetRangeStyle Colors { get; set; } = new WorksheetRangeStyle();

        public Color()
        {
            InitializeComponent();
        }

        public void Initialize(WorksheetRangeStyle style)
        {
            Colors.CopyFrom(style);
            textColorSelected.BackColor = System.Drawing.Color.FromArgb(style.TextColor.R, style.TextColor.G, style.TextColor.B);
            bgColorSelected.BackColor = System.Drawing.Color.FromArgb(style.BackColor.R, style.BackColor.G, style.BackColor.B);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Colors.Flag = PlainStyleFlag.TextColor | PlainStyleFlag.BackColor | PlainStyleFlag.FillPatternColor;
            DialogResult = DialogResult.OK;
        }

        private void UpdateTextColor(System.Drawing.Color c)
        {
            textColorSelected.BackColor = c;

            Colors.TextColor = new SolidColor
            {
                R = c.R,
                G = c.G,
                B = c.B,
                A = 255
            };
        }

        private void UpdateBGColor(System.Drawing.Color c)
        {
            bgColorSelected.BackColor = c;

            Colors.BackColor = new SolidColor
            {
                R = c.R,
                G = c.G,
                B = c.B,
                A = 255
            };
            Colors.FillPatternColor = Colors.BackColor;
        }

        private void bgColorWhite_Click(object sender, EventArgs e)
        {
            UpdateBGColor(bgColorWhite.BackColor);
        }

        private void bgColorLightBlue_Click(object sender, EventArgs e)
        {
            UpdateBGColor(bgColorLightBlue.BackColor);
        }

        private void bgColorSalmon_Click(object sender, EventArgs e)
        {
            UpdateBGColor(bgColorSalmon.BackColor);
        }

        private void bgColorBlack_Click(object sender, EventArgs e)
        {
            UpdateBGColor(bgColorBlack.BackColor);
        }

        private void bgColorTeal_Click(object sender, EventArgs e)
        {
            UpdateBGColor(bgColorTeal.BackColor);
        }

        private void bgColorYellow_Click(object sender, EventArgs e)
        {
            UpdateBGColor(bgColorYellow.BackColor);
        }

        private void textColorRed_Click(object sender, EventArgs e)
        {
            UpdateTextColor(textColorRed.BackColor);
        }

        private void textColorBlack_Click(object sender, EventArgs e)
        {
            UpdateTextColor(textColorBlack.BackColor);
        }

        private void textColorWhite_Click(object sender, EventArgs e)
        {
            UpdateTextColor(textColorWhite.BackColor);
        }

        private void textColorGreen_Click(object sender, EventArgs e)
        {
            UpdateTextColor(textColorGreen.BackColor);
        }

        private void textColorOrange_Click(object sender, EventArgs e)
        {
            UpdateTextColor(textColorOrange.BackColor);
        }

        private void textColorTeal_Click(object sender, EventArgs e)
        {
            UpdateTextColor(textColorTeal.BackColor);
        }

        private void textColorLightGray_Click(object sender, EventArgs e)
        {
            UpdateTextColor(textColorLightGray.BackColor);
        }

        private void textColorDarkGray_Click(object sender, EventArgs e)
        {
            UpdateTextColor(textColorDarkGray.BackColor);
        }
    }
}
