using System;
using System.Globalization;

namespace Couser
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = TimeSpan.MaxValue;
            Console.WriteLine(t1);

            TimeSpan t2 = TimeSpan.MinValue;
            Console.WriteLine(t2);

            TimeSpan t3 = TimeSpan.Zero;
            Console.WriteLine(t3);

            Console.WriteLine("------------------------");

            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);
            Console.WriteLine(t);
            Console.WriteLine("Days: " + t.Days);

            Console.WriteLine("------------------------");

            TimeSpan ts1 = new TimeSpan(1, 30, 10);
            TimeSpan ts2 = new TimeSpan(0, 10, 5);

            TimeSpan sum = ts1.Add(ts2);
            Console.WriteLine(sum);

            TimeSpan dif = ts1.Subtract(ts2);
            Console.WriteLine(dif);

            TimeSpan mult = ts2.Multiply(2.0);
            Console.WriteLine(mult);

            TimeSpan div = ts2.Divide(2.0);
            Console.WriteLine(div);
        }
    }
}