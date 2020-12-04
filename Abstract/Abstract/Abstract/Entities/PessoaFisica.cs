using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract.Entities
{
    class PessoaFisica : Pessoa
    {
        public double GastosSaude { get; set; }

        public PessoaFisica(string nome, double rendaAtual, double gastosSaude) : base(nome, rendaAtual)
        {
            GastosSaude = gastosSaude;
        }

        public override double CalcularImposto()
        {
            double res = 0.0;

            if (RendaAtual < 20000.00)
            {
                res = (RendaAtual * 0.15) - (GastosSaude * 0.5); 
            }
            else
            {
                res = (RendaAtual * 0.25) - (GastosSaude * 0.5);
            }

            return res;
        }
    }
}
