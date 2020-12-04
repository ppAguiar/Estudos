using System;
using ContaBancaria.Entities;
using ContaBancaria.Entities.Exception;
using System.Globalization;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data:");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withdralLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account account = new Account(number, holder, withdralLimit);
                account.Deposit(balance);
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine(account.ToString());
                Console.WriteLine("----------------------------------------------");
                Console.Write("Enter amount for withdraw: ");
                double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account.WithDraw(withdraw);
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine(account.ToString());
                Console.WriteLine("----------------------------------------------");
            }
            catch(DominException e){
                Console.WriteLine("Atenção! " + e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Houve uma exceção não tratada no sistema. Favor contactar o adminstrador!");
            }

        }
    }
}
