using System;
using System.Globalization;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many rooms will be rented? ");
            int totalRent = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Register[] registers = new Register[10];

            for (int i = 1; i <= totalRent; i++)
            {
                Console.WriteLine($"Rent #" + i);

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());

                Console.WriteLine();

                registers[room] = new Register { Rent = i, Name = name, Email = email, Room = room };

            }

            Console.WriteLine("Busy rooms");

            for (int i = 0; i < registers.Length; i++)

                if (registers[i] != null)
                {
                    Console.WriteLine(registers[i]);
                }
        }

    }
}