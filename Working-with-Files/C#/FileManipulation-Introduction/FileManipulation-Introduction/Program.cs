using System;
using System.IO;

namespace FileManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"YourPathTill\01\file1.txt";

            string targetPath = @"YourPathTill\01\file2.txt";

            // creates a new file in 01's folder with the same content
            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                // Read the file

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
                // Tell you all the file lines

            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
                // you can't create because it already exist
            }

        }
    }
}