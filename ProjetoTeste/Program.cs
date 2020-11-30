using System;
using ProjetoTeste.Entities;
using ProjetoTeste.Entities.Enuns;
using System.Globalization;

namespace ProjetoTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            /*-------------------------------------
             *  Dados Departamento
             --------------------------------------*/
            Console.Write("Enter department's name: ");
            Departament dep = new Departament(Console.ReadLine());
            /*-------------------------------------
             *  Dados Trabalhador
             --------------------------------------*/

            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel wl;
            Enum.TryParse(Console.ReadLine(), out wl);
            Console.Write("Base salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Worker worker = new Worker(name, wl, salary);

            /*-------------------------------------
             *  Impressão de dados
             --------------------------------------*/
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine(dep);


        }
    }
}
