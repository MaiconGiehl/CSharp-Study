using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            Dictionary<string, int> results = new Dictionary<string, int>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] ballot = sr.ReadLine().Split(',');
                        string name = ballot[0];
                        int votes = int.Parse(ballot[1]);

                        if (results.ContainsKey(name))
                        {
                            results[name] = results[name] + votes;
                        }
                        else
                        {
                            results[name] = votes;
                        }
                    }
                    foreach (KeyValuePair<string, int> result in results)
                    {
                        Console.WriteLine(result);
                    }
                }
            }
            catch (IOException error)
            {
                Console.WriteLine("Error:");
                Console.WriteLine(error.Message);
            }
        }
    }
}