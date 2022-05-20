using System;
using System.Globalization;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product("TV", 500.00, 10); ;

            p.SetName("TV 4K");
            p.SetName("A"); 
            // Não funciona por causa da condicao
            // Encapsulamento melhora seu controle sobre as entradas e saídas


            Console.WriteLine(p.GetName());
            Console.WriteLine(p.GetPrice());
            Console.WriteLine(p.GetAmount());


        }
    }
}