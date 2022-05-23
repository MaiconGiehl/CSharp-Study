using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sintaxe opcional e simplificada para percorrer coleções

            string[] vect = new string[] { "Maria" , "Alex", "Bob"};


            // Normal
            for(int i = 0; i < vect.Length; i++)
            {
                Console.WriteLine(vect[i]);
            }

            // Foreach
            foreach (string name in vect)
            {
                Console.WriteLine(name);
            }
        }
    }
}