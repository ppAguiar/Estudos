using System;
using System.Collections.Generic;
using Abstract.Entities;
using System.Globalization;
namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> list = new List<Pessoa>();
            double total = 0;
            Console.Write("Entre com o número de Pessoas: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"DADOS PESSOA #{i}:");
                Console.Write("Pessoa Física ou Juridica(f ou j): ");
                char op = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Renda Anual: ");
                double renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture );
                


                if (op == 'f' || op == 'F')
                {
                    Console.Write("Gastos com saúde: ");
                    double saude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new PessoaFisica(nome, renda, saude));
                }
                else
                {
                    Console.Write("Número de Funcionários: ");
                    int func = int.Parse(Console.ReadLine());
                    list.Add(new PessoaJuridica(nome, renda, func));
                }
                    
            }
            Console.WriteLine("IMPOSTO COBRADO: ");
            foreach (Pessoa p in list)
            {
                Console.WriteLine(p.ToString());
                total += p.CalcularImposto();
            }

            Console.WriteLine("Total de Impostos " + total);
        }
    }
}
