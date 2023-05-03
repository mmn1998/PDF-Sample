using QuestPDF.Helpers;

namespace ConsoleApp1.data;

internal class PdfConfigurations
{
    public PdfConfigurations(string pdfName,int columnsCount,List<string> columnNames)
    {
        if (columnNames.Count != columnsCount)
            throw new Exception("Column counts and column names are not match!");
        PdfName = pdfName;
        ColumnsCount = columnsCount;
        ColumnNames = columnNames;
    }
    public int ColumnsCount { get; set; }
    public List<string> ColumnNames { get; set; }
    public int PageMargin { get; set; } = 10;
    public float TableBorders { get; set; } = 0.5f;
    public string FontFamily { get; set; } = "B Lotus";
    public int ColumnWidths { get; set; } = 150;
    public string PageBackgroundColor { get; set; } = Colors.LightGreen.Accent1;
    public string HeaderText { get; set; } = "خروجی";
    public string PdfName { get; init; }
}
