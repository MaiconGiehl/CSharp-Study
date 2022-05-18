namespace OldestPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            Person first, second;

            //----------------------------------------------

            first = new Person();
            Console.WriteLine("Insira o nome da primeira pessoa: ");
            first.Name = Console.ReadLine();
            Console.WriteLine("Insira a idade da primeira pessoa: ");
            first.Age = int.Parse(Console.ReadLine());

            //----------------------------------------------

            second = new Person();
            Console.WriteLine("Insira o nome da segunda pessoa: ");
            second.Name = Console.ReadLine();
            Console.WriteLine("Insira a idade da segunda pessoa: ");
            second.Age = int.Parse(Console.ReadLine());

            if (first.Age > second.Age)
            {
                Console.WriteLine($"{first.Name} é a pessoa mais velha.");
            }
            else
            {
                Console.WriteLine($"{second.Name} é a pessoa mais velha.");
            }

        }
    }
}
