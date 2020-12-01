using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoTeste.Entities
{
    class Departament
    {
        public string Name { get; set; }

        public Departament(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return "Departament: " + Name;
        }
    }
}
