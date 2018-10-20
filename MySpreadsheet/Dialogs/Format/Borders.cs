using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using unvell.ReoGrid;
using unvell.ReoGrid.Graphics;

namespace MySpreadsheet.Dialogs.Format
{
    public partial class Borders : Form
    {
        public SolidColor BorderColor { get; set; }
        public BorderLineStyle LineStyle { get; set; } = BorderLineStyle.Solid;
        public BorderPositions BorderPosition { get; set; }

        public List<BusinessObjects.BorderLineStyle> LineStyles { get; set; } = new List<BusinessObjects.BorderLineStyle>();

        public Borders()
        {
            InitializeComponent();
            UpdateColor(borderColorBlack.BackColor);

            LineStyles.Add(new BusinessObjects.BorderLineStyle { Name = "None", ID = BorderLineStyle.None });
            LineStyles.Add(new BusinessObjects.BorderLineStyle { Name = "Solid", ID = BorderLineStyle.Solid });
            LineStyles.Add(new BusinessObjects.BorderLineStyle { Name = "BoldSolid", ID = BorderLineStyle.BoldSolid });
            LineStyles.Add(new BusinessObjects.BorderLineStyle { Name = "BoldSolidStrong", ID = BorderLineStyle.BoldSolidStrong });
            LineStyles.Add(new BusinessObjects.BorderLineStyle { Name = "Dotted", ID = BorderLineStyle.Dotted });
            LineStyles.Add(new BusinessObjects.BorderLineStyle { Name = "BoldDotted", ID = BorderLineStyle.BoldDotted });
            LineStyles.Add(new BusinessObjects.BorderLineStyle { Name = "Dashed", ID = BorderLineStyle.Dashed });
            LineStyles.Add(new BusinessObjects.BorderLineStyle { Name = "BoldDashed", ID = BorderLineStyle.BoldDashed });
            LineStyles.Add(new BusinessObjects.BorderLineStyle { Name = "DoubleLine", ID = BorderLineStyle.DoubleLine });
            LineStyles.Add(new BusinessObjects.BorderLineStyle { Name = "Dashed2", ID = BorderLineStyle.Dashed2 });
            LineStyles.Add(new BusinessObjects.BorderLineStyle { Name = "DashDot", ID = BorderLineStyle.DashDot });
            LineStyles.Add(new BusinessObjects.BorderLineStyle { Name = "DashDotDot", ID = BorderLineStyle.DashDotDot });
            LineStyles.Add(new BusinessObjects.BorderLineStyle { Name = "BoldDashDot", ID = BorderLineStyle.BoldDashDot });
            LineStyles.Add(new BusinessObjects.BorderLineStyle { Name = "BoldDashDotDot", ID = BorderLineStyle.BoldDashDotDot });

            lbLineStyle.DataSource = LineStyles;
            lbLineStyle.DisplayMember = "Name";
            lbLineStyle.ValueMember = "ID";
            lbLineStyle.SelectedIndex = 1;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            LineStyle = (BorderLineStyle)lbLineStyle.SelectedValue;
            BorderPosition = GetBorderPosition();
            DialogResult = DialogResult.OK;
        }

        private BorderPositions GetBorderPosition()
        {
            var result = BorderPositions.None;

            if (cbTop.Checked) result |= BorderPositions.Top;
            if (cbRight.Checked) result |= BorderPositions.Right;
            if (cbBottom.Checked) result |= BorderPositions.Bottom;
            if (cbLeft.Checked) result |= BorderPositions.Left;

            return result;
        }

        private void borderColorBlack_Click(object sender, EventArgs e)
        {
            UpdateColor(borderColorBlack.BackColor);
        }

        private void UpdateColor(System.Drawing.Color c)
        {
            borderColorSelected.BackColor = c;

            BorderColor = new SolidColor
            {
                R = c.R,
                G = c.G,
                B = c.B,
                A = 255
            };
        }

        private void borderColorRed_Click(object sender, EventArgs e)
        {
            UpdateColor(borderColorRed.BackColor);
        }

        private void borderColorOrange_Click(object sender, EventArgs e)
        {
            UpdateColor(borderColorOrange.BackColor);
        }

        private void borderColorLightGray_Click(object sender, EventArgs e)
        {
            UpdateColor(borderColorLightGray.BackColor);
        }

        private void borderColorYellow_Click(object sender, EventArgs e)
        {
            UpdateColor(borderColorYellow.BackColor);
        }

        private void borderColorGreen_Click(object sender, EventArgs e)
        {
            UpdateColor(borderColorGreen.BackColor);
        }

        private void borderColorTeal_Click(object sender, EventArgs e)
        {
            UpdateColor(borderColorTeal.BackColor);
        }

        private void borderColorDarkGray_Click(object sender, EventArgs e)
        {
            UpdateColor(borderColorDarkGray.BackColor);
        }
    }
}
