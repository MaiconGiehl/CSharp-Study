using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = DateTime.Now;
            Console.WriteLine(d);
            Console.WriteLine(d.Ticks);

            Console.WriteLine("----------------");

            DateTime d1 = new DateTime(2022, 5, 25);
            Console.WriteLine(d1);

            Console.WriteLine("----------------");

            DateTime d2 = new DateTime(2022, 5, 25, 20, 45, 3);
            Console.WriteLine(d2);

            Console.WriteLine("----------------");

            DateTime d3 = new DateTime(2022, 5, 25, 20, 45, 3, 500);
            Console.WriteLine(d3);
            // Formatação padrao nao leva em conta os milissegundos

            Console.WriteLine("----------------");

            DateTime d4 = DateTime.Now;
            Console.WriteLine(d4);

            Console.WriteLine("----------------");

            DateTime d5 = DateTime.Today;
            Console.WriteLine(d5);

            Console.WriteLine("----------------");


            DateTime d6 = DateTime.UtcNow;
            Console.WriteLine(d6);


            Console.WriteLine("======================");


            DateTime date1 = DateTime.Parse("2000-08-15");
            Console.WriteLine(date1);

            Console.WriteLine("----------------");

            DateTime date2 = DateTime.Parse("2000-08-15 13:08:59");
            Console.WriteLine(date2);

            Console.WriteLine("----------------");

            DateTime date3 = DateTime.Parse("25/05/22");
            Console.WriteLine(date3);

            DateTime date4 = DateTime.Parse("25/05/22 13:05:59");
            Console.WriteLine(date4);


            Console.WriteLine("======================");


            DateTime dt1 = DateTime.ParseExact("2008-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            Console.WriteLine(dt1);

            Console.WriteLine("----------------");

            DateTime dt2 = DateTime.ParseExact("15/08/2022 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(dt2);
        }
    }
}