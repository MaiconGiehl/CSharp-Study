using System;
using System.Globalization;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Insert the product data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Product p = new Product(name, price);

            Product p2 = new Product();

            //Product p3 = new Product { Name = "TV", Price = 500.00, Amount = 20 };
            Product p3 = new Product
            {
                Name = "TV",
                Price = 500.00,
                Amount = 20
            };


            Console.WriteLine();
            Console.WriteLine("Product data: " + p);
            Console.WriteLine();


            Console.Write("Type how many products are going to be inserted: ");
            int moreProducts = int.Parse(Console.ReadLine());
            p.AdcProducts(moreProducts);

            Console.WriteLine();
            Console.WriteLine("Updated product data: " + p);
            Console.WriteLine();

            Console.Write("Type how many products are going to be taken: ");
            int lessProducts = int.Parse(Console.ReadLine());
            p.RmvProducts(lessProducts);

            Console.WriteLine();
            Console.WriteLine("Updated product data: " + p);

        }
    }
}