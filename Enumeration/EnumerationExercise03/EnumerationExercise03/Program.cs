using System;
using System.Globalization;
using EnumerationExercise03.Entities;

namespace EnumerationExercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter order's data");
            Console.WriteLine("Status: ");
            Console.Write("How many products to this order?");

            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\r\n-------------");

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Insert product #{i} data");
                Console.Write("Name: ");
                string productName = Console.ReadLine();
                Console.Write("Price");
                double price = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName, price);
                Console.WriteLine("-------------");
            }
        }
    }
}