using System.Globalization;
using Inheritance.Entities;

namespace Inheritance
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("Enter the number of products: ");
            var numOfProd = int.Parse(Console.ReadLine() ?? string.Empty);
            var products = new Queue<Product>();

            for (var i = 1; i <= numOfProd; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                var type = char.Parse(Console.ReadLine() ?? string.Empty);
                Console.Write("Name: ");
                var name = Console.ReadLine() ?? string.Empty;
                Console.Write("Price: ");
                var price = double.Parse(Console.ReadLine() ?? string.Empty);

                switch (type)
                {
                    case 'i':
                    {
                        Console.Write("Customs fee: ");
                        var customsFee = double.Parse(Console.ReadLine() ?? string.Empty);
                        products.Enqueue(new ImportedProduct(name, price, customsFee));
                        break;
                    }
                    case 'u':
                    {
                        Console.Write("Manufacture date (DD/MM/YYYY): ");
                        var manufactureDate = DateTime.ParseExact(Console.ReadLine() ?? string.Empty, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        products.Enqueue(new UsedProduct(name, price, manufactureDate));
                        break;
                    }
                    default:
                    {
                        products.Enqueue(new Product(name, price));
                        break;
                    }
                }
            }

            Console.WriteLine("PRICE TAGS: ");

            while (products.Any())
            {
                Console.WriteLine(products.Dequeue().PriceTag());
            }
        }
    }
}