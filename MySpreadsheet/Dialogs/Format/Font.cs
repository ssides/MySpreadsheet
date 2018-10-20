using System;
using System.Windows.Forms;
using unvell.ReoGrid;

namespace MySpreadsheet.Dialogs.Format
{
    public partial class Font : Form
    {
        public WorksheetRangeStyle FontStyle { get; set; } = new WorksheetRangeStyle();

        public Font()
        {
            InitializeComponent();
        }

        public void Initialize(WorksheetRangeStyle style)
        {
            FontStyle.CopyFrom(style);
            cbBold.Checked = FontStyle.Bold;
            cbItalic.Checked = FontStyle.Italic;
            cbUnderline.Checked = FontStyle.Underline;
            cbStrikethrough.Checked = FontStyle.Strikethrough;
            lbFontName.Text = FontStyle.FontName;
            lbFontSize.Text = FontStyle.FontSize.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            FontStyle.Flag = PlainStyleFlag.FontAll;
            DialogResult = DialogResult.OK;
        }

        private void lbFontName_SelectedValueChanged(object sender, EventArgs e)
        {
            FontStyle.FontName = lbFontName.Text;
        }

        private void cbBold_CheckedChanged(object sender, EventArgs e)
        {
            FontStyle.Bold = cbBold.Checked;
        }

        private void lbFontSize_SelectedValueChanged(object sender, EventArgs e)
        {
            Single result;
            Single.TryParse(lbFontSize.Text, out result);
            FontStyle.FontSize = result;
        }

        private void cbItalic_CheckedChanged(object sender, EventArgs e)
        {
            FontStyle.Italic = cbItalic.Checked;
        }

        private void cbStrikethrough_CheckedChanged(object sender, EventArgs e)
        {
            FontStyle.Strikethrough = cbStrikethrough.Checked;
        }

        private void cbUnderline_CheckedChanged(object sender, EventArgs e)
        {
            FontStyle.Underline = cbUnderline.Checked;
        }
    }
}
