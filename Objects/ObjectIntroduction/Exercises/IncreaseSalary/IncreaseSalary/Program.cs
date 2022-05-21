using System;
using System.Globalization;

namespace IncreaseSalary
{
    class Program
    {
        static void Main(string[] args)
        {
            Employer employer = new Employer();

            Console.WriteLine("Enter the employer's information");
            Console.Write("Name: ");
            employer.Name = Console.ReadLine();

            Console.Write("Gross salary: ");
            employer.GrossSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Taxes: ");
            employer.Taxes = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            employer.NetSalary = employer.GrossSalary - employer.Taxes;

            Console.WriteLine("Employer information: " + employer);
            Console.WriteLine("");

            Console.WriteLine("Enter percentage to increase salary: ");

            double moreSalaryPercent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);            
            employer.MoreSalary(moreSalaryPercent);

            Console.WriteLine("Updated employer information: " + employer);
            Console.WriteLine("");
        }
    }
}