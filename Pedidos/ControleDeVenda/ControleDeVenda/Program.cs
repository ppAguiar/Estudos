using System;
using ControleDeVenda.Entities;
using ControleDeVenda.Entities.Ennuns;
using System.Globalization;
namespace ControleDeVenda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus orderstatus = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.WriteLine();
            Console.Write("How many items to this order? ");

            Order order = new Order(DateTime.Now, orderstatus);
            order.Client = new Client(name, email, birthDate);

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n;i++)
            {
                Console.WriteLine("Enter #{0} item data: ", i);
                Console.Write("Product name: ");
                string nameproduct = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                Product product = new Product(nameproduct, price);
                OrderItem item = new OrderItem(quantity, price, product);
                order.AddItems(item);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(order.ToString());


           
        }
    }
}
