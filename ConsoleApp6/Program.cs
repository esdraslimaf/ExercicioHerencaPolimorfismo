//NET 6.0

using ConsoleApp6.Entities;
using System.Globalization;

List<Product> list = new List<Product>();

Console.Write("Enter the number of products: ");
int n = int.Parse(Console.ReadLine());

for(int i = 1; i <= n; i++)
{
    Console.WriteLine($"Product: #{i} data: ");
    Console.Write("Common, used or imported(c/u/i)? ");
    char resp = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    
    if (resp == 'i') { 
        Console.Write("Customs fee: ");
        double customsfee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        list.Add(new ImportedProduct(name, price, customsfee));
    }
    else if (resp == 'u') {
        Console.Write(" Manufacture date (DD/MM/YYYY): ");
        DateTime manufacturedate = DateTime.Parse(Console.ReadLine());
        list.Add(new UsedProduct(name, price, manufacturedate));
    }
    else {
        list.Add(new Product(name, price));
         }
}

Console.WriteLine("");
Console.WriteLine("Price tags: ");
foreach(Product p in list)
{
    Console.WriteLine(p.PriceTag());
}
