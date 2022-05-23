using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for(int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }


            Console.WriteLine("Main diagonal: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + "; ");
            }
            Console.WriteLine();

            int score = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                      if (mat[i, j] < 0)
                    {
                        score++;
                    }
                }
            }
            Console.WriteLine("Negative numbers: " + score);
        }
    }
}