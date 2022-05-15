namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Conversão Implícita
            float x = 4.5f;
            double y = x;

            Console.WriteLine(y);


            // Conversão Explícita (Casting)
            double a;
            float b;

            a = 5.1;
            b = (float)a;

            Console.WriteLine(b);

            // Risco de Perda de Informação
            double c;
            int d;

            c = 5.1;
            d = (int)c;

            Console.WriteLine(d);

            // Casting em Operações Matemáticas (sem identificar, nesse caso, ele entende que precisa fazer uma multiplicação inteira.
            int e = 5;
            int f = 2;

            double resultado = (double) e / f;
            Console.WriteLine(resultado);

        }
    }
}