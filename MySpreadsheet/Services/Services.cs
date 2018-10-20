using MySpreadsheet.BusinessObjects;
using System;
using System.Windows.Forms;
using unvell.ReoGrid;
using unvell.ReoGrid.DataFormat;

namespace MySpreadsheet.Services
{
    public class Services
    {
        public static BusinessObjects.SheetFileNameInfo Open(string basePath, ReoGridControl workbook, BusinessObjects.SheetFileNameInfo sheetFilenameInfo)
        {
            var dialog = new OpenFileDialog();
            dialog.InitialDirectory = basePath;
            dialog.Filter = "rgf files (*.rgf)|*.rgf";
            dialog.RestoreDirectory = true;

            if (dialog.ShowDialog() == DialogResult.OK)
                workbook.CurrentWorksheet.LoadRGF(dialog.FileName);
            else
                return sheetFilenameInfo;

            return new BusinessObjects.SheetFileNameInfo
            {
                SheetName = workbook.CurrentWorksheet.Name,
                FullPath = dialog.FileName
            };
        }


        public static BusinessObjects.SheetFileNameInfo SaveAs(string basePath, ReoGridControl workbook)
        {
            var dialog = new SaveFileDialog();
            dialog.InitialDirectory = basePath;
            dialog.Filter = "rgf files (*.rgf)|*.rgf";
            dialog.RestoreDirectory = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                workbook.CurrentWorksheet.SaveRGF(dialog.FileName);
            }

            return new BusinessObjects.SheetFileNameInfo
            {
                SheetName = workbook.CurrentWorksheet.Name,
                FullPath = dialog.FileName
            };
        }

        public static void InsertCurrentDateIntoSelectionStartPosition(ReoGridControl workbook)
        {
            var currentSheet = workbook.CurrentWorksheet;
            var range = currentSheet.SelectionRange;
            var position = range.StartPos;
            var cell = currentSheet.Cells[position];
            cell.DataFormat = CellDataFormatFlag.DateTime;
            cell.Data = (DateTime.Now - Constants.StartDate).TotalDays;
        }

        public static void ConvertSelectionStartPostionToDateNumber(ReoGridControl workbook)
        {
            try
            {
                var currentSheet = workbook.CurrentWorksheet;
                var range = currentSheet.SelectionRange;
                var position = range.StartPos;
                var cell = currentSheet.Cells[position];
                cell.DataFormat = CellDataFormatFlag.DateTime;
                cell.Data = ((DateTime)cell.Data - Constants.StartDate).TotalDays;
            }
            catch (Exception)
            {
                InsertCurrentDateIntoSelectionStartPosition(workbook);
            }
        }
    }
}
