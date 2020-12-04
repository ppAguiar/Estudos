using System.Globalization;
namespace Abstract.Entities
{
    abstract class Pessoa
    {
        public string Nome { get; set; }
        public double RendaAtual { get; set; }

        public Pessoa()
        {

        }

        public Pessoa(string nome, double rendaAtual)
        {
            Nome = nome;
            RendaAtual = rendaAtual;
        }

        public abstract double CalcularImposto();

        public override string ToString()
        {
            return Nome + ": $" + CalcularImposto().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
