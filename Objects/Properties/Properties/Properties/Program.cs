using System;
using System.Globalization;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product("TV", 500.00, 10); ;

            p.Name = "T";

            Console.WriteLine(p.Name);
            Console.WriteLine(p.Price);
            Console.WriteLine(p.Amount);


        }
    }
}