

// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using ConsoleApp1.data;

var data = new List<TplusCustomer>();
for (int i = 1; i < 20; i++)
{
    data.Add(new TplusCustomer(i));
}
List<string> columnNames = new List<string>();
columnNames.Add("آیدی");
columnNames.Add("کد ملی");
columnNames.Add("نام فروشگاه");
columnNames.Add("شناسه ملی  ");
PdfConfigurations PdfConfigurations = new PdfConfigurations("test", 4, columnNames);
PDFProvider.SavePdf(PdfConfigurations, data);