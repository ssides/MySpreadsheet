using System;

namespace MySpreadsheet.BusinessObjects
{
    public static class Constants
    {
        public static readonly DateTime StartDate = new DateTime(1899, 12, 30);
    }

    public class BorderLineStyle
    {
        public string Name { get; set; }
        public unvell.ReoGrid.BorderLineStyle ID { get; set; }
    }

    public class SheetFileNameInfo
    {
        public string SheetName { get; set; }
        public string FullPath { get; set; }
    }

}
