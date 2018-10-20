using System;
using unvell.ReoGrid;
using unvell.ReoGrid.DataFormat;

namespace MySpreadsheet.Customization
{
    public class MyDateTimeFormatter : IDataFormatter
    {
        public string FormatCell(Cell cell)
        {
            long val = cell.GetData<long>();
            var d = new DateTime(val);
            return d.ToString("MM/dd/yyyy HH:mm:ss");
        }

        public bool PerformTestFormat()
        {
            return true;  // must be true, or Custom cannot be used.
        }
    }
}
