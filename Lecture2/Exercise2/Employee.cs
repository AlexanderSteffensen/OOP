namespace Exercise2
{
    public class Employee
    {
        private string name;
        private string job;
        protected int salary;
        protected int level;

        public Employee(string name, string job, int salary, int level)
        {
            this.name = name;
            this.job = job;
            this.salary = salary;
            this.level = level;
        }

        public virtual double CalculateYearlySalary()
        {
            return 12 * salary + salary * (double)level * 0.1;
        }
    }
}