using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract.Entities
{
    class PessoaJuridica : Pessoa
    {
        public int NumeroFuncionarios { get; set; }

        public PessoaJuridica(string nome, double rendaAtual, int numeroFuncionarios) : base(nome, rendaAtual)
        {
            NumeroFuncionarios = numeroFuncionarios;
        }

        public override double CalcularImposto()
        {
            double res = 0.0;
            if (NumeroFuncionarios > 10)
            {
                res = RendaAtual * 0.14;
            }
            else
            {
                res = RendaAtual * 0.16;
            }
            return res;
        }
    }
}
