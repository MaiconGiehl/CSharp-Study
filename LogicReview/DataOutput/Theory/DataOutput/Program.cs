using System;
using System.Globalization;

namespace DataOutput
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Bom dia!");
            Console.WriteLine("Boa tarde!");
            Console.WriteLine("Boa noite!");


            Console.WriteLine("============");
            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";


            // Usando . ao invés de vírgula no prompt
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));


            //PlaceHolder
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais.", nome, idade, saldo);

            //Interpolação
            Console.WriteLine($"{nome} tem {idade}  anos e tem saldo igual a {saldo:F2} reais.");

            // Concatenação
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais.");
        }
    }
}