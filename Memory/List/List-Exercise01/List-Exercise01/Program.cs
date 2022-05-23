using System;
using System.Globalization;
using System.Collections.Generic;



namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int nEmployees = int.Parse(Console.ReadLine());
            Console.WriteLine("=====================");

            List<Employee> employees = new List<Employee>();

            for (int i = 1; i <= nEmployees; i++)
            {
                Console.WriteLine("Employee #" + i);

                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                employees.Add(new Employee(id, name, salary));
                Console.WriteLine("--------------------");
            }

            Console.WriteLine("Employees list: ");
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }

            Console.WriteLine("=====================");


            Console.WriteLine("Enter the employer ID that will have salary increase: ");
            int idToIncrease = int.Parse(Console.ReadLine());

            Console.WriteLine("--------------------");


            Employee employeeToIncrease = employees.Find(x => x.Id == idToIncrease);
            if (employeeToIncrease != null)
            {
                Console.WriteLine("Enter the percentage ");
                double percentageToIncrease = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employeeToIncrease.IncreaseSalary(percentageToIncrease);
                Console.WriteLine("--------------------");
            } else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine("Updated list of employees: ");
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
        }

    }

}
