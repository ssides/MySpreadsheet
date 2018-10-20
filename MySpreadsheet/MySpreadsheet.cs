using System;
using System.Linq;
using System.Windows.Forms;
using MySpreadsheet.BusinessObjects;

namespace MySpreadsheet
{
    public partial class MySpreadsheet : Form
    {
        public string BasePath { get; set; }
        public SheetFileNameInfo SheetFilenameInfo { get; set; }

        public MySpreadsheet(string fassoc)
        {
            InitializeComponent();
            var reader = new System.Configuration.AppSettingsReader();
            BasePath = (string)reader.GetValue("BasePath", typeof(string));
            if (fassoc != null)
            {
                SheetFilenameInfo = new SheetFileNameInfo {
                    SheetName = "Sheet1",
                    FullPath = fassoc
                };
                workbook.CurrentWorksheet.LoadRGF(fassoc);
            }
            // This sets the default DataFormat of all new cells to Custom.
            // DataFormatterManager.Instance.DataFormatters.Add(CellDataFormatFlag.Custom, new Customization.MyDateTimeFormatter());
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SheetFilenameInfo = Services.Services.SaveAs(BasePath, workbook);
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SheetFilenameInfo = Services.Services.Open(BasePath, workbook, SheetFilenameInfo);
        }

        private void FormatCellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Services.Format.SetFont(this, workbook);
        }

        private void NumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Services.Format.SetRangeFormat(this, workbook);
        }

        private void ColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Services.Format.SetColors(this, workbook);
        }

        private void NewWorksheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var s in workbook.Worksheets.ToList())
                workbook.Worksheets.Remove(s);

            var sheet = workbook.CreateWorksheet("Sheet1");
            workbook.Worksheets.Add(sheet);
        }

        private void SaveSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SheetFilenameInfo == null)
                SheetFilenameInfo = Services.Services.SaveAs(BasePath, workbook);
            if (SheetFilenameInfo.SheetName != workbook.CurrentWorksheet.Name)
                SheetFilenameInfo = Services.Services.SaveAs(BasePath, workbook);
            workbook.CurrentWorksheet.SaveRGF(SheetFilenameInfo.FullPath);
        }

        private void bordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Services.Format.SetBorder(this, workbook);
        }

        private void insertDateAsNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Services.Services.InsertCurrentDateIntoSelectionStartPosition(workbook);
        }

        private void convertDateToNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Services.Services.ConvertSelectionStartPostionToDateNumber(workbook);
        }
    }
}
