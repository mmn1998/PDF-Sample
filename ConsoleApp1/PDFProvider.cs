
using ConsoleApp1.data;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace ConsoleApp1;

internal class PDFProvider<T> where T : TplusCustomer, IDisposable
{
    class test
    {
        public int MyProperty { get; set; }
        public int MyValue { get; set; }

        public int MyProperty1 { get; set; }
        public int MyProperty2 { get; set; }
    }
    public void SavePdf(PdfConfigurations pdfConfigurations, List<T> data,Stream stream)
    {

        Console.WriteLine(data.Count);
        #region test1(pdfsharpcore)
        //var document = new PdfDocument();
        //// Page Options
        //PdfPage pdfPage = document.AddPage();
        //pdfPage.Height = 842;//842
        //pdfPage.Width = 400;

        //// Get an XGraphics object for drawing
        //XGraphics graph = XGraphics.FromPdfPage(pdfPage);

        //// Text format
        //XStringFormat format = new XStringFormat();
        //format.LineAlignment = XLineAlignment.Near;
        //format.Alignment = XStringAlignment.Near;
        //var tf = new XTextFormatter(graph);

        //var fontopt = new XPdfFontOptions(PdfFontEncoding.WinAnsi);
        //XFont fontParagraph = new XFont("B Lotus", 8, XFontStyle.Regular);

        //// Row elements
        //int el_width = 80;

        //// page structure options
        //double lineHeight = 20;
        //int marginLeft = 100;
        //int marginTop = 20;

        //int el_height = 30;
        //int rect_height = 17;

        //int interLine_X_1 = 2;
        //int interLine_X_2 = 2 * interLine_X_1;
        //int interLine_X_3 = 2 * interLine_X_2;
        //int interLine_X_4 = 2 * interLine_X_3;


        //int offSetX_1 = el_width;
        //int offSetX_2 = el_width * 2;
        //int offSetX_3 = el_width * 2;
        //int offSetX_4 = el_width * 2;

        //XSolidBrush rect_style1 = new XSolidBrush(XColors.WhiteSmoke);
        //XSolidBrush rect_style2 = new XSolidBrush(XColors.CadetBlue);
        //XSolidBrush rect_style3 = new XSolidBrush(XColors.YellowGreen);

        //for (int i = 0; i < data.Count; i++)
        //{
        //    double dist_Y = lineHeight * (i + 1);
        //    double dist_Y2 = dist_Y - 2;

        //    // header della G
        //    if (i == 0)
        //    {
        //        graph.DrawRectangle(rect_style2, marginLeft, marginTop, pdfPage.Width - 2 * marginLeft, rect_height);

        //        tf.DrawString("آیدی", fontParagraph, XBrushes.YellowGreen,
        //                      new XRect(marginLeft, marginTop, el_width, el_height), format);

        //        tf.DrawString("کد ملی", fontParagraph, XBrushes.YellowGreen,
        //                      new XRect(marginLeft + offSetX_1 + interLine_X_1, marginTop, el_width, el_height), format);

        //        tf.DrawString("شناسه ملی", fontParagraph, XBrushes.YellowGreen,
        //                      new XRect(marginLeft + offSetX_2 + 2 * interLine_X_2, marginTop, el_width, el_height), format);
        //        //tf.DrawString(data[i].MyValue.ToString(), fontParagraph, XBrushes.YellowGreen,
        //        //              new XRect(marginLeft + offSetX_3 + 2 * interLine_X_3, marginTop, el_width, el_height), format);
        //        //tf.DrawString(data[i].MyProperty2.ToString(), fontParagraph, XBrushes.YellowGreen,
        //        //              new XRect(marginLeft + offSetX_4 + 2 * interLine_X_4, marginTop, el_width, el_height), format);

        //        // stampo il primo elemento insieme all'header
        //        graph.DrawRectangle(rect_style1, marginLeft, dist_Y2 + marginTop, el_width, rect_height);
        //        tf.DrawString(data[i].Id.ToString(), fontParagraph, XBrushes.Black,
        //                      new XRect(marginLeft, dist_Y + marginTop, el_width, el_height), format);

        //        //ELEMENT 2 - BIG 380
        //        graph.DrawRectangle(rect_style1, marginLeft + offSetX_1 + interLine_X_1, dist_Y2 + marginTop, el_width, rect_height);
        //        tf.DrawString(
        //            data[i].Nationalcode,
        //            fontParagraph,
        //            XBrushes.Black,
        //            new XRect(marginLeft + offSetX_1 + interLine_X_1, dist_Y + marginTop, el_width, el_height),
        //            format);


        //        //ELEMENT 3 - SMALL 80

        //        graph.DrawRectangle(rect_style1, marginLeft + offSetX_2 + interLine_X_2, dist_Y2 + marginTop, el_width, rect_height);
        //        tf.DrawString(
        //            data[i].Nationalid,
        //            fontParagraph,
        //            XBrushes.Black,
        //            new XRect(marginLeft + offSetX_2 + 2 * interLine_X_2, dist_Y + marginTop, el_width, el_height),
        //            format);
        //        graph.DrawRectangle(rect_style1, marginLeft + offSetX_3 + interLine_X_3, dist_Y2 + marginTop, el_width, rect_height);
        //        //tf.DrawString(
        //        //    data[i].MyValue.ToString(),
        //        //    fontParagraph,
        //        //    XBrushes.Black,
        //        //    new XRect(marginLeft + offSetX_3 + 2 * interLine_X_3, dist_Y + marginTop, el_width, el_height),
        //        //    format);
        //        //graph.DrawRectangle(rect_style1, marginLeft + offSetX_4 + interLine_X_4, dist_Y2 + marginTop, el_width, rect_height);
        //        //tf.DrawString(
        //        //    data[i].MyValue.ToString(),
        //        //    fontParagraph,
        //        //    XBrushes.Black,
        //        //    new XRect(marginLeft + offSetX_4 + 2 * interLine_X_4, dist_Y + marginTop, el_width, el_height),
        //        //    format);




        //    }
        //    else
        //    {

        //        //if (i % 2 == 1)
        //        //{
        //        //  graph.DrawRectangle(TextBackgroundBrush, marginLeft, lineY - 2 + marginTop, pdfPage.Width - marginLeft - marginRight, lineHeight - 2);
        //        //}

        //        //ELEMENT 1 - SMALL 80
        //        graph.DrawRectangle(rect_style1, marginLeft, marginTop + dist_Y2, el_width, rect_height);
        //        tf.DrawString(

        //            data[i].Id.ToString(),
        //            fontParagraph,
        //            XBrushes.Black,
        //            new XRect(marginLeft, marginTop + dist_Y, el_width, el_height),
        //            format);
        //        //graph.DrawRectangle(rect_style1, marginLeft, marginTop + dist_Y2, el_width, rect_height);
        //        //tf.DrawString(

        //        //    data[i].MyValue.ToString(),
        //        //    fontParagraph,
        //        //    XBrushes.Black,
        //        //    new XRect(marginLeft, marginTop + dist_Y, el_width, el_height),
        //        //    format);
        //        //graph.DrawRectangle(rect_style1, marginLeft, marginTop + dist_Y2, el_width, rect_height);
        //        //tf.DrawString(

        //        //    data[i].MyValue.ToString(),
        //        //    fontParagraph,
        //        //    XBrushes.Black,
        //        //    new XRect(marginLeft, marginTop + dist_Y, el_width, el_height),
        //        //    format);

        //        //ELEMENT 2 - BIG 380
        //        graph.DrawRectangle(rect_style1, marginLeft + offSetX_1 + interLine_X_1, dist_Y2 + marginTop, el_width, rect_height);
        //        tf.DrawString(
        //            data[i].Nationalcode,
        //            fontParagraph,
        //            XBrushes.Black,
        //            new XRect(marginLeft + offSetX_1 + interLine_X_1, marginTop + dist_Y, el_width, el_height),
        //            format);


        //        //ELEMENT 3 - SMALL 80

        //        graph.DrawRectangle(rect_style1, marginLeft + offSetX_2 + interLine_X_2, dist_Y2 + marginTop, el_width, rect_height);
        //        tf.DrawString(
        //            Encoding.UTF8.GetString(Encoding.Default.GetBytes(data[i].Storename)),
        //            fontParagraph,
        //            XBrushes.Black,
        //            new XRect(marginLeft + offSetX_2 + 2 * interLine_X_2, marginTop + dist_Y, el_width, el_height),
        //            format);

        //    }

        //}

        //document.Save("outpdf.pdf");
        //document.Close();
        #endregion
        #region test2(itext7)
        //try
        //{
        //    PdfDocument pdfDoc = new PdfDocument(new PdfWriter("output.pdf"));
        //    PageSize pageSize = new PageSize(400, 250);
        //    Document doc = new Document(pdfDoc);
        //    FontProgram fontProgram = FontProgramFactory.CreateFont("C:\\Windows\\Fonts\\B Lotus.ttf");
        //    EncodingProvider encodingProvider = CodePagesEncodingProvider.Instance;
        //    var test = encodingProvider.GetEncodings().ToList();
        //    var test2 = encodingProvider.GetEncoding(28596);
        //    foreach (var item in test)
        //    {
        //        Console.WriteLine(item.CodePage + "  " + item.Name + "  " + item.DisplayName);
        //    }
        //    Encoding.RegisterProvider(encodingProvider);
        //    PdfFont pdfFont = PdfFontFactory.CreateFont(fontProgram);
        //    //FontSet fontSet = new FontSet();
        //    //iText.Layout.Font.Range range = new RangeBuilder().Create();
        //    FontProvider fontProvider = new FontProvider();
        //    fontProvider.AddFont(fontProgram);
        //    doc.SetFontProvider(fontProvider);
        //    Table table = new Table(3);

        //    table.AddHeaderCell("آیدی").SetFont(pdfFont);
        //    table.AddHeaderCell("کد ملی").SetFont(pdfFont);
        //    table.AddHeaderCell("شناسه ملی").SetFont(pdfFont);


        //    foreach (var item in data)
        //    {
        //        table.AddCell(item.Id.ToString()).SetFont(pdfFont);
        //        table.AddCell(item.Storename).SetFont(pdfFont);
        //        table.AddCell(item.Nationalcode).SetFont(pdfFont);


        //    }
        //    Paragraph paragraph = new Paragraph("تست");
        //    paragraph.Add(table).SetFont(pdfFont);
        //    doc.Add(paragraph);
        //    doc.Close();
        //}
        //catch (Exception e)
        //{

        //    throw;
        //}
        #endregion
        #region test3(questpdf)
        try
        {
            Document.Create(document =>
            {
                document.Page(page =>
                {
                    page.ContentFromRightToLeft();
                    page.Margin(10);
                    page.Header()
                        .Text("خروجی").FontFamily("B Lotus").Fallback()
                        .SemiBold();

                    page.Content().AlignCenter()
                        .Table(table =>
                        {
                            table.ColumnsDefinition(cd =>
                            {
                                //cd.RelativeColumn(200);
                                //cd.RelativeColumn(200);
                                //cd.RelativeColumn(200);
                                for (int i = 0; i < pdfConfigurations.ColumnsCount; i++)
                                {
                                    cd.RelativeColumn(pdfConfigurations.ColumnWidths);
                                }
                            });

                            table.Header(tableHeader =>
                            {
                                //tableHeader.Cell().Border(1).AlignCenter().Text("آیدی").FontFamily("B Lotus").Fallback();
                                //tableHeader.Cell().Border(1).AlignCenter().Text("کد ملی").FontFamily("B Lotus").Fallback();
                                //tableHeader.Cell().Border(1).AlignCenter().Text("نام").FontFamily("B Lotus").Fallback();
                                foreach (var colunName in pdfConfigurations.ColumnNames)
                                {
                                    tableHeader.Cell()
                                        .Border(pdfConfigurations.TableBorders)
                                        .AlignCenter()
                                        .Text(colunName)
                                        .FontFamily(pdfConfigurations.FontFamily)
                                        .Fallback();
                                }
                            });
                            foreach (var item in data)
                            {
                                table.Cell()
                                    .Border(pdfConfigurations.TableBorders)
                                    .AlignCenter()
                                    .Text(item.Id.ToString())
                                    .FontFamily(pdfConfigurations.FontFamily)
                                    .Fallback();
                                table.Cell()
                                    .Border(pdfConfigurations.TableBorders)
                                    .AlignCenter()
                                    .Text(item.Nationalcode)
                                    .FontFamily(pdfConfigurations.FontFamily)
                                    .Fallback(); ;
                                table.Cell()
                                    .Border(pdfConfigurations.TableBorders)
                                    .AlignCenter()
                                    .Text(item.Name)
                                    .FontFamily(pdfConfigurations.FontFamily)
                                    .Fallback();
                            }
                        });
                    page.PageColor(pdfConfigurations.PageBackgroundColor);
                    page.Footer()
                        .Text(text =>
                        {
                            text.CurrentPageNumber();
                        });
                });
            }).GeneratePdf();
        }
        catch (Exception e)
        {

            throw;
        }
        #endregion

    }
    //public static string Reverse(string s)
    //{
    //    //char[] charArray = s.ToCharArray();
    //    //Array.Reverse(charArray);
    //    return new string(s,new Encoding());
    //}
}
class IranianSystemEncoding
{
    static char[] ByteToChar;
    static Byte[][] CharToByte;

    static IranianSystemEncoding()
    {
        InitializeData();
    }

    static void InitializeData()
    {
        var iranSystem = new int[]
        {
            0x06F0, 0x06F1, 0x06F2, 0x06F3, 0x06F4, 0x06F5, 0x06F6, 0x06F7, 0x06F8, 0x06F9, 0x060C, 0x0640, 0x061F, 0xFE81,
            0xFE8B, 0x0621, 0xFE8D, 0xFE8E, 0xFE8F, 0xFE91, 0xFB56, 0xFB58, 0xFE95, 0xFE97, 0xFE99, 0xFE9B, 0xFE9D, 0xFE9F,
            0xFB7C, 0xFB7C, 0xFEA1, 0xFEA3, 0xFEA5, 0xFEA7, 0x062F, 0x0630, 0x0631, 0x0632, 0x0698, 0xFEB1, 0xFEB3, 0xFEB5,
            0xFEB7, 0xFEB9, 0xFEBB, 0xFEBD, 0xFEBF, 0x0637, 0x2591, 0x2592, 0x2593, 0x2502, 0x2524, 0x2561, 0x2562, 0x2556,
            0x2555, 0x2563, 0x2551, 0x2557, 0x255D, 0x255C, 0x255B, 0x2510, 0x2514, 0x2534, 0x252C, 0x251C, 0x2500, 0x253C,
            0x255E, 0x255F, 0x255A, 0x2554, 0x2569, 0x2566, 0x2560, 0x2550, 0x256C, 0x2567, 0x2568, 0x2564, 0x2565, 0x2559,
            0x2558, 0x2552, 0x2553, 0x256B, 0x256A, 0x2518, 0x250C, 0x2588, 0x2584, 0x258C, 0x2590, 0x2580, 0x0638, 0xFEC9,
            0xFECA, 0xFECC, 0xFECB, 0xFECD, 0xFECE, 0xFED0, 0xFECF, 0xFED1, 0xFED3, 0xFED5, 0xFED7, 0xFB8E, 0xFB90, 0xFB92,
            0xFB94, 0xFEDD, 0xFEFB, 0xFEDF, 0xFEE1, 0xFEE3, 0xFEE5, 0xFEE7, 0x0648, 0xFEE9, 0xFEEC, 0xFEEB, 0xFBFD, 0xFBFC,
            0xFBFE, 0x00A0 };
        ByteToChar = new char[256];
        // ascii first
        for (int i = 0; i < 128; i++) ByteToChar[i] = (char)i;
        // non-ascii
        for (int i = 128; i < 256; i++) ByteToChar[i] = (char)iranSystem[i - 128];

        // ok now reverse
        CharToByte = new Byte[256][];
        for (int i = 0; i < 256; i++)
        {
            char ch = (char)ByteToChar[i];
            var low = ch & 0xff;
            var high = ch >> 8 & 0xff;

            var lowCharToByte = CharToByte[high];
            if (lowCharToByte == null)
            {
                lowCharToByte = new Byte[256];
                CharToByte[high] = lowCharToByte;
            }
            lowCharToByte[low] = (byte)(i);
        }
    }

    public static String GetString(byte[] bytes)
    {
        var sb = new System.Text.StringBuilder();
        foreach (var b in bytes)
        {
            sb.Append(ByteToChar[b]);
        }
        return sb.ToString();
    }

    public static Byte[] GetBytes(string str)
    {
        var mem = new System.IO.MemoryStream();
        foreach (var ch in str)
        {
            var high = ch >> 8 & 0xff;
            var lowCharToByte = CharToByte[high];
            Byte res = 0;
            if (lowCharToByte != null)
            {
                var low = ch & 0xff;
                res = lowCharToByte[low];
            }
            if (res == 0) res = 0xff;
            mem.WriteByte(res);
        }
        return mem.ToArray();
    }
}
