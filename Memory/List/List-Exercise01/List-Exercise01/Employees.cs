using System.Globalization;

namespace Exercise
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"{Id}, " +
                $"{Name}, " +
                $"{Salary.ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public void IncreaseSalary(double percentageToIncrease)
        {
            Salary += Salary * percentageToIncrease / 100.0;
        }
    }
}
