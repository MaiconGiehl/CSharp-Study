using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            // Boxing = É o processo de conversão de um objeto tipo valor para um objeto tipo referência compatível

            int x = 20;

            Object objBx = x;

            Console.WriteLine(x);
            Console.WriteLine(objBx);



            // Unboxing = é o processo de conversão de um objeto tipo valor compatível

            int y = 20;
            Object objUbx = y;


            Console.WriteLine(y);
            Console.WriteLine(objUbx);

            int z = (int)objUbx;

            Console.WriteLine(z);
        }
    }
}