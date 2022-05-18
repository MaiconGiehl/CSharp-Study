using System;
using System.Globalization;

namespace Stock
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();

            Console.WriteLine("Insert the product data: ");
            Console.Write("Name: ");
            p.Name = Console.ReadLine();
            Console.Write("Price: ");
            p.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantity in stock: ");
            p.Amount = int.Parse(Console.ReadLine());

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