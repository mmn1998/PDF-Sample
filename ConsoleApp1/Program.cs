

// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using ConsoleApp1.data;

var data = new List<TplusCustomer>();
using (var context = new Context())
{
    data = context.TplusCustomers.ToList();
}
List<string> columnNames = new List<string>();
columnNames.Add("آیدی");
columnNames.Add("نام");
columnNames.Add("کد ملی");
PdfConfigurations PdfConfigurations = new PdfConfigurations("test", 3, columnNames);
using (MemoryStream stream = new MemoryStream())
{
    using (var finalStream = System.IO.File.Create(""))
    {
        await finalStream.CopyToAsync(stream);

    }
}