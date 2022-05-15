using System;

namespace AssignmentOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a);
            a += 2;
            a *= 3;
            Console.WriteLine(a);

            string s = "ABC";
            s += "DEF";
            Console.WriteLine(s);

            int b = 10;
            int c = ++b;
            // se o mais é colocado no final, o valor de atribuicao do c vai ser
            // o original do b (10) e o b tem seu valor somado (b = 11)
            Console.WriteLine(b);
            Console.WriteLine(c);

        }
    }
}