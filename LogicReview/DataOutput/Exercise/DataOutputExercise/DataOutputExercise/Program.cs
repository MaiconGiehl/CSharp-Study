using System;
using System.Globalization;

namespace DataOutputExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.00;
            double preco2 = 650.50;
            double medida = 53.234567;


            Console.WriteLine($"Produtos: \r\n {produto1}, cujo preço é de $ {preco1}. " + $"\r\n {produto2}, cujo preço é de $ {preco2:F2}.");

            Console.WriteLine($"Registro: {30} anos de idade, código {codigo} e genêro: {genero}");

            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
            Console.WriteLine($"Arredondado (três casas decimais): {medida:F3}");
            Console.WriteLine($"Separador decimal invariant culture: {medida.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}