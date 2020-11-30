using ProjetoTeste.Entities.Enuns;

namespace ProjetoTeste.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }

        public Worker(string name, WorkerLevel level, double baseSalary)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
        }

        public void AddContract(HourContract contract)
        {

        }

        public void RemoveContract(HourContract contract)
        {

        }

        public double Income(int year, int month)
        {
            return 0;
        }
    }
}
