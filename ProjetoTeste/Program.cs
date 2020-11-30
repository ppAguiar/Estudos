using System;
using ProjetoTeste.Entities;

namespace ProjetoTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            Departament dep = new Departament(Console.ReadLine());

            Console.WriteLine(dep);

        }
    }
}
