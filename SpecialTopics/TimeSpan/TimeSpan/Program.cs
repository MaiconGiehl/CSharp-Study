using System;
using System.Globalization;


namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan(0, 1, 30);
            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);
            Console.WriteLine("============");

            TimeSpan t2 = new TimeSpan(900000000L);
            Console.WriteLine(t2);
            Console.WriteLine("============");

            TimeSpan t3 = new TimeSpan(2, 11, 21);
            Console.WriteLine(t3);
            Console.WriteLine("=====");

            TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
            Console.WriteLine(t4);
            Console.WriteLine("============");

            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);
            Console.WriteLine(t5);
            Console.WriteLine("============");

            Console.WriteLine();

            TimeSpan ts1 = TimeSpan.FromDays(1.5);
            Console.WriteLine(ts1);
            Console.WriteLine("============");

            TimeSpan ts2 = TimeSpan.FromHours(1.5);
            Console.WriteLine(ts2);
            Console.WriteLine("============");

            TimeSpan ts3 = TimeSpan.FromMinutes(1.5);
            Console.WriteLine(ts3);
            Console.WriteLine("============");

            TimeSpan ts4 = TimeSpan.FromSeconds(1.5);
            Console.WriteLine(ts4);
            Console.WriteLine("============");

            TimeSpan ts5 = TimeSpan.FromMilliseconds(1);
            Console.WriteLine(ts5);
            Console.WriteLine("============");

            TimeSpan ts6 = TimeSpan.FromTicks(900000000L);
            Console.WriteLine(ts6);
            Console.WriteLine("============");
        }
    }
}