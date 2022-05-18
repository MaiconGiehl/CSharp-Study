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
            student.Note1 = double.Parse(Console.ReadLine());

            Console.Write("Second Note: ");
            student.Note2 = double.Parse(Console.ReadLine());

            Console.Write("Third Note: ");
            student.Note3 = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Final note: " + student.Total());
            if (student.Total() >= 60)
            {
                student.Status = "Aproved";
                Console.WriteLine(student.Status);
            }
            else
            {
                student.Status = "Reproved";
                Console.WriteLine(student.Status);
                Console.WriteLine("It was missing " + (60 - student.Total()) + " points");

            }
        }
    }
}