using System;
using System.Globalization;

namespace QuarterlyNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            Console.WriteLine("Insert student's information");
            Console.Write("Name: ");
            student.Name = Console.ReadLine();

            Console.Write("First Note: ");
            student.Note1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Second Note: ");
            student.Note2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Third Note: ");
            student.Note3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("");

            Console.WriteLine("Final note: " + student.FinalNote().ToString("F2", CultureInfo.InvariantCulture));

            if (student.Approved())
            {
                Console.WriteLine("Approved");  
            }
            else
            {
                Console.WriteLine("Disapproved");
                Console.WriteLine("It was missing " + student.Remaining().ToString("F2", CultureInfo.InvariantCulture) + " points");
            }
        }
    }
}