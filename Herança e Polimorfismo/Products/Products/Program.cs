using System;
using System.Collections.Generic;
using Products.Entities;
using System.Globalization;

namespace Products
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Product {0} data:", i);

                Console.Write("Common, used or imported (c/u/i): ");
                char opt = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                switch (opt)
                {
                    case 'i':
                        Console.Write("Customs fee: ");
                        double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        list.Add(new ImportedProduct(name, price, customsFee));
                        break;
                    case 'u':
                        Console.Write("Manufacture date (DD/MM/YYYY): ");
                        DateTime manufacturedade = DateTime.Parse(Console.ReadLine());
                        list.Add(new UsedProduct(name, price, manufacturedade));
                        break;
                    case 'c':
                        list.Add(new Product(name, price));
                        break;
                    default:
                        Console.WriteLine("Entrada Inválida!");
                        break;
                }
            }

            Console.WriteLine("PRICES TAGS: ");
            foreach (Product product in list)
            {
                Console.WriteLine(product.PriceTag());
            }

        }
    }
}
