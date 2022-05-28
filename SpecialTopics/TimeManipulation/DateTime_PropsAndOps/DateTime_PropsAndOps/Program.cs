namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);

            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("1) Date: " + d.Day);

            Console.WriteLine("==============");


            string s1 = d.ToLongDateString();
            Console.WriteLine("Long date str: " + s1);

            Console.WriteLine("==============");

            string s2 = d.ToLongTimeString();
            Console.WriteLine("Long time str: " + s2);

            Console.WriteLine("==============");

            string s3 = d.ToShortDateString();
            Console.WriteLine("Short date str: " + s3);
            
            Console.WriteLine("==============");

            string s4 = d.ToShortTimeString();
            Console.WriteLine("Short date str: " + s4);

            Console.WriteLine("==============");

            string s5 = d.ToString();
            Console.WriteLine(s5);
            
            Console.WriteLine("==============");

            string s6 = d.ToString("yyyy-MM-dd HH:mm:ss");
            Console.WriteLine(s6);

            Console.WriteLine("==============");

            string s7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");
            Console.WriteLine(s7);

            Console.WriteLine("==============\r\n\r\n");

            // --------------------------------------------

            DateTime dt = new DateTime(2022, 10, 15);
            Console.WriteLine(dt);

            DateTime dt2 = dt.AddDays(7);
            Console.WriteLine(dt2);

            DateTime dt3 = dt.AddMinutes(3);
            Console.WriteLine(dt3);

            TimeSpan t = dt.Subtract(dt2);
            Console.WriteLine(t);

        }
    }
}