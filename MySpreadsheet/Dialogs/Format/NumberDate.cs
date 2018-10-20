using System;
using System.Windows.Forms;
using unvell.ReoGrid.DataFormat;

namespace MySpreadsheet.Dialogs.Format
{
    public partial class NumberDate : Form
    {
        public CellDataFormatFlag Flag { get; set; } = CellDataFormatFlag.Text;
        public short DecimalPlaces { get; set; } = 0;
        public bool UseSeparator { get; set; } = false;

        public NumberDate()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void rbNumber_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNumber.Checked)
                Flag = CellDataFormatFlag.Number;
            tbDecimalPlaces.Enabled = cbUseComma.Enabled = rbNumber.Checked;
        }

        private void tbDecimalPlaces_TextChanged(object sender, EventArgs e)
        {
            short result;
            short.TryParse(tbDecimalPlaces.Text, out result);
            DecimalPlaces = result;
        }

        private void cbUseComma_CheckedChanged(object sender, EventArgs e)
        {
            UseSeparator = cbUseComma.Checked;
        }

        private void rbDate_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDate.Checked)
                Flag = CellDataFormatFlag.DateTime;

        }

        private void rbText_CheckedChanged(object sender, EventArgs e)
        {
            if (rbText.Checked)
                Flag = CellDataFormatFlag.Text;
        }
    }
}
