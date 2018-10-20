using MySpreadsheet.Customization;
using MySpreadsheet.Dialogs.Format;
using System.Drawing;
using System.Windows.Forms;
using unvell.ReoGrid;
using unvell.ReoGrid.DataFormat;

namespace MySpreadsheet.Services
{
    public class Format
    {
        public static void SetFont(MySpreadsheet my, ReoGridControl workbook)
        {
            var fontStyle = new Dialogs.Format.Font();
            fontStyle.StartPosition = FormStartPosition.Manual;
            fontStyle.Location = new Point(my.Location.X + 20, my.Location.Y + 40);
            var currentSheet = workbook.CurrentWorksheet;
            var range = currentSheet.SelectionRange;
            fontStyle.Initialize(currentSheet.GetRangeStyles(range));

            if (fontStyle.ShowDialog(my) == DialogResult.OK)
                currentSheet.SetRangeStyles(currentSheet.SelectionRange, fontStyle.FontStyle);
        }


        public static void SetColors(MySpreadsheet my, ReoGridControl workbook)
        {
            var color = new Dialogs.Format.Color();
            color.StartPosition = FormStartPosition.Manual;
            color.Location = new Point(my.Location.X + 20, my.Location.Y + 40);
            var currentSheet = workbook.CurrentWorksheet;
            var range = currentSheet.SelectionRange;
            color.Initialize(currentSheet.GetRangeStyles(range));

            if (color.ShowDialog(my) == DialogResult.OK)
                currentSheet.SetRangeStyles(currentSheet.SelectionRange, color.Colors);
        }

        public static void SetRangeFormat(MySpreadsheet my, ReoGridControl workbook)
        {
            var fmt = new Dialogs.Format.NumberDate();
            fmt.StartPosition = FormStartPosition.Manual;
            fmt.Location = new Point(my.Location.X + 20, my.Location.Y + 40);

            if (fmt.ShowDialog(my) == DialogResult.OK)
            {
                var currentSheet = workbook.CurrentWorksheet;
                var range = currentSheet.SelectionRange;
                switch (fmt.Flag)
                {
                    case CellDataFormatFlag.Number:
                        FormatNumber(fmt, currentSheet, range);
                        break;
                    case CellDataFormatFlag.DateTime:
                        FormatDate(currentSheet, range);
                        break;
                    case CellDataFormatFlag.Text:
                        FormatText(currentSheet, range);
                        break;
                    default:
                        FormatNumber(fmt, currentSheet, range);
                        break;

                }
            }
        }

        // I couldn't figure out a way to format dates with time and do time arithmetic.
        //
        //private static void FormatDateTime(Worksheet currentSheet, RangePosition range)
        //{
        //    currentSheet.SetRangeDataFormat(range, CellDataFormatFlag.Custom, new object());
        //}

        private static void FormatDate(Worksheet currentSheet, RangePosition range)
        {
            currentSheet.SetRangeDataFormat(range, CellDataFormatFlag.DateTime,
                new DateTimeDataFormatter.DateTimeFormatArgs
                {
                    CultureName = "en-US",
                    Format = "M/d/yyyy",  // no other format works.
                });
        }

        private static void FormatText(Worksheet currentSheet, RangePosition range)
        {
            currentSheet.SetRangeDataFormat(range, CellDataFormatFlag.Text, null);
        }

        private static void FormatNumber(NumberDate fmt, Worksheet currentSheet, RangePosition range)
        {
            currentSheet.SetRangeDataFormat(range, CellDataFormatFlag.Number,
                new NumberDataFormatter.NumberFormatArgs()
                {
                    DecimalPlaces = fmt.DecimalPlaces,
                    NegativeStyle = NumberDataFormatter.NumberNegativeStyle.RedBrackets,
                    UseSeparator = fmt.UseSeparator
                });
        }

        public static void SetBorder(MySpreadsheet my, ReoGridControl workbook)
        {
            var borderStyle = new Dialogs.Format.Borders();
            borderStyle.StartPosition = FormStartPosition.Manual;
            borderStyle.Location = new Point(my.Location.X + 20, my.Location.Y + 40);
            var currentSheet = workbook.CurrentWorksheet;
            var range = currentSheet.SelectionRange;

            if (borderStyle.ShowDialog(my) == DialogResult.OK)
                currentSheet.SetRangeBorders(currentSheet.SelectionRange, borderStyle.BorderPosition,
                        new RangeBorderStyle
                        {
                            Color = borderStyle.BorderColor,
                            Style = borderStyle.LineStyle,
                        });
        }
    }
}
