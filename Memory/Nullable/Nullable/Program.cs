namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //double z = null; = erro;

            Nullable<double> z = null;
            // ou
            double? x = null;
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("X is null");
            }

            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("Y is null");
            }



            // Coalescencia

            double? x2 = null;
            double? y2 = 10;

            double a = x2 ?? 5;
            double b = y2 ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);


        }
    }
}