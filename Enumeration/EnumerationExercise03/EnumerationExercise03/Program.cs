using System;
using System.Globalization;
using EnumerationExercise03.Entities;
using EnumerationExercise03.Entities.Enums;


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
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Client client = new Client(clientName, email, birthDate);

            Order order = new Order(client);


            //Console.WriteLine("Enter order's data");
            //Console.Write("Status: ");
            //OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            //Console.Write("How many products to this order?");

            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine("\r\n-------------");

            //for (int i = 1; i <= n; i++)
            //{
            //    Console.WriteLine($"Insert product #{i} data");
            //    Console.Write("Name: ");
            //    string productName = Console.ReadLine();
            //    Console.Write("Price: ");
            //    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //    Console.Write("Quantity: ");
            //    int quantity = int.Parse(Console.ReadLine());

            //    Product product = new Product(productName, price);
            //    OrderItem orderItem = new OrderItem(product, quantity);

            //    Console.WriteLine("-------------");
            //}
            Console.WriteLine(order);
        }
    }
}