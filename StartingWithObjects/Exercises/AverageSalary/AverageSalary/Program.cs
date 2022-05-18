using System;
using System.Globalization;

namespace AverageSalary
{
    class Program
    {
        static void Main(string[] args)
        {
            Employer one, two;

            //-------------------------------------------------------

            one = new Employer();
            Console.WriteLine("Insira o nome do primeiro funcionário");
            one.Name = Console.ReadLine();
            Console.WriteLine("Insira o salário do primeiro funcionário");
            one.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //-------------------------------------------------------

            two = new Employer();
            Console.WriteLine("Insira o nome do segundo funcionário");
            two.Name = Console.ReadLine();
            Console.WriteLine("Insira o salário do segundo funcionário");
            two.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double average = (double)(one.Salary + two.Salary) / 2;

            Console.WriteLine($"Salário médio: {average.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
