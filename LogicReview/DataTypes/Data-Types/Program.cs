// See https://aka.ms/new-console-template for more information

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            bool completo = false;
            char genero = 'F';
            // ou
            char letra = '\u0041';
            byte n1 = 255;
            int n2 = 1000;
            int n3 = 214783647;
            long n4 = 214783648L;
            float n5 = 4.5f;
            double n6 = 4.5;
            string nome = "Maria Green";
            object obj1 = "Alex Brown";
            object obj2 = 4.5f;

            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);


            // Para consultar valores máximos e mínimos

            int N1 = int.MinValue;
            int N2 = int.MaxValue;
            sbyte N3 = sbyte.MinValue;
            decimal N4 = decimal.MaxValue;

            Console.WriteLine(N1);
            Console.WriteLine(N2);
            Console.WriteLine(N3);
            Console.WriteLine(N4);
        }
    }
}