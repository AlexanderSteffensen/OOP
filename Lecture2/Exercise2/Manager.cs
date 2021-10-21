namespace Exercise2
{
    public class Manager : Employee
    {
        private int bonus;
        
        public Manager(string name, string job, int salary, int level, int bonus) : base(name, job, salary,level)
        {
            this.bonus = bonus;
        }

        public override double CalculateYearlySalary()
        {
            return 12 * salary + salary * (double)level * 0.1  + bonus;
        }
    }
}