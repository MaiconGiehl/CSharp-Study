using System;

namespace ExtMeth
{
    class Program
    {
        public static void Main(string[] args)
        {
            DateTime dt = new DateTime(2022, 05, 30, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());
        }
    }
}