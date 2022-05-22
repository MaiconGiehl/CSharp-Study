using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p; // necessário inicializar, mas não precisa do "Point p = new Point()"
            p.X = 10;
            p.Y = 20;
            Console.WriteLine(p);
            p = new Point();
            Console.WriteLine(p);
        }
    }
}