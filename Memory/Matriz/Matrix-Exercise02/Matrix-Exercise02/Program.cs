using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many rows will it have? ");
            int nRows = int.Parse(Console.ReadLine());

            Console.Write("How many columns will it have? ");
            int nColumns = int.Parse(Console.ReadLine());

            int[,] matrix = new int[nRows, nColumns];

            Console.WriteLine("\nInsert your matrix " + nRows + "x" + nColumns + ":");
            for (int r = 0; r < nRows; r++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int c = 0; c < nColumns; c++)
                {
                    matrix[r, c] = int.Parse(values[c]);
                }
            }
            Console.WriteLine();

            Console.Write("What value do you want search for? ");
            int toFind = int.Parse(Console.ReadLine());

            for (int r = 0; r < nRows; r++)
            {
                for (int c = 0; c < nColumns; c++)
                {
                    if (toFind == matrix[r, c])
                    {
                        Console.WriteLine("Position: " + r + ", " + c);

                        if (c > 0)
                        {
                            int left = matrix[r, c - 1];
                            Console.WriteLine("Left: " + left);
                        }

                        if (r > 0)
                        {
                            int up = matrix[r - 1, c];
                            Console.WriteLine("Up: " + up);
                        }

                        if (c < nColumns - 1)
                        {
                            int right = matrix[r, c + 1];
                            Console.WriteLine("Right: " + right);
                        }

                        if (r < nRows - 1)
                        {
                            int down = matrix[r + 1, c];
                            Console.WriteLine("Down: " + down);
                        }

                        Console.WriteLine("");

                    }
                }
            }
        }
    }
}