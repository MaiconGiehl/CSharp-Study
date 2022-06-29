using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("How many students for course A?");
            int nStudents = int.Parse(Console.ReadLine());

            HashSet<int> cA = new HashSet<int>();
            for (int i = 0; i < nStudents; i++)
            {
                int register = int.Parse(Console.ReadLine());
                cA.Add(register);
            }
            Console.WriteLine("");

            Console.Write("How many students for course B?");
            nStudents = int.Parse(Console.ReadLine());

            HashSet<int> cB = new HashSet<int>();
            for (int i = 0; i < nStudents; i++)
            {
                int register = int.Parse(Console.ReadLine());
                cB.Add(register);
            }
            Console.WriteLine("");

            Console.Write("How many students for course C?");
            nStudents = int.Parse(Console.ReadLine());

            HashSet<int> cC = new HashSet<int>();
            for (int i = 0; i < nStudents; i++)
            {
                int register = int.Parse(Console.ReadLine());
                cC.Add(register);
            }
            Console.WriteLine("");

            HashSet<int> totalStudents = new HashSet<int>();
            totalStudents.UnionWith(cA);
            totalStudents.UnionWith(cB);
            totalStudents.UnionWith(cC);

            Console.WriteLine("Unique students: " + totalStudents.Count());

        }
    }
}