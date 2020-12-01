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
            worker.Departament = dep;
            /*-------------------------------------
             *  Entrada de Contratos
             --------------------------------------*/
            Console.Write("How many contracts to this worker? ");
            int numeroDeContratos = int.Parse(Console.ReadLine());
            HourContract[] vetCont = new HourContract[numeroDeContratos];
            for (int i = 0; i < numeroDeContratos; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Enter #{0} contract data:", i);
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hour = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, value, hour);
                worker.AddContract(contract);
            }
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            DateTime dataref = DateTime.Parse(Console.ReadLine());
            int mes = dataref.Month;
            int ano = dataref.Year;
            /*-------------------------------------
             *  Impressão de dados
             --------------------------------------*/
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine(worker.Departament);
            Console.WriteLine("Incone for " + mes + "/" + ano +  ": " + worker.Income(ano, mes).ToString("F2", CultureInfo.InvariantCulture) );
            Console.WriteLine();
            Console.WriteLine("------------------------------");
        }
    }
}
