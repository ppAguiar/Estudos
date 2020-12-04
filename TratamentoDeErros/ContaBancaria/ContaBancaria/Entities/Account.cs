using ContaBancaria.Entities.Exception;
using System.Globalization;

namespace ContaBancaria.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }
        public double WithDrawLimit { get; set; }

        public Account()
        {

        }

        public Account(int number, string holder, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            WithDrawLimit = withDrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void WithDraw(double amount)
        {
            if (amount > WithDrawLimit)
            {
                throw new DominException("Limite de saque excedido, limite máximo: "+ WithDrawLimit);
            }

            if (amount > Balance)
            {
                throw new DominException("Saldo na conta é inferior a quantia desejada, saldo atual :" + Balance);
            }

            Balance -= amount;
        }

        public override string ToString()
        {
            return "New balance: " + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
