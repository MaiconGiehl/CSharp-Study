using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using Exercise.Entities;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            List<Employee> employees = new List<Employee>(); 

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] data = sr.ReadLine().Split(',');
                    string name = data[0];
                    string email = data[1];
                    double salary = double.Parse(data[2], CultureInfo.InvariantCulture);
                    employees.Add(new Employee(name, email, salary));
                }
            }

            Console.Write("\r\nDo you want to see the email of who is paid above: ");
            double paidAbove = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            var emailsAbove = employees.Where(e => e.Salary > paidAbove).OrderBy(e => e.Email).Select(e => e.Email);
            Console.WriteLine("===================\r\nEmails:");
            foreach(string email in emailsAbove)
            {
                Console.WriteLine(email);
            }

            var sum = employees.Where(e => e.Name[0] == 'M').Select(e => e.Salary).Aggregate(0.0, (x, y) => x + y);
            Console.Write("===================\r\nSum:");
            Console.Write(sum.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("\r\n===================");
        }
    }
}