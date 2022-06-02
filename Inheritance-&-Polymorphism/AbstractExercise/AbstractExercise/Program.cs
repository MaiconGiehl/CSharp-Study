using System;
using System.Globalization;
using System.Collections.Generic;
using AbstractExercise.Entities;

namespace AbstractExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            List<TaxPayer> list = new List<TaxPayer>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("\r\n======================");
                Console.WriteLine($"Tax payer {i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char personType = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (personType == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new NaturalPerson(name, anualIncome, healthExpenditures));
                } 
                else if (personType == 'c')
                {
                    Console.Write("Number of employees: ");
                    int employeesNumber = int.Parse(Console.ReadLine());
                    list.Add(new LegalPerson(name, anualIncome, employeesNumber));

                }
            }

            Console.WriteLine("======================\r\n");

            double sum = 0.0;
            Console.WriteLine("TAXES PAID: ");
            foreach (TaxPayer taxPayer in list) {
                Console.WriteLine(taxPayer);
                sum += taxPayer.TotalTaxes();
            }

            Console.WriteLine("TOTAL TAXES: $" + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}