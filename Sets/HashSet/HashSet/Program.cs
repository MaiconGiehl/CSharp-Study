using System;

namespace Set
{
    class program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");


            Console.WriteLine(set.Contains("Notebook"));
            Console.WriteLine(set.Contains("Microwave"));

            Console.WriteLine("---------");

            foreach (string p in set)
            {
                Console.WriteLine(p);
            }
        }
    }
}