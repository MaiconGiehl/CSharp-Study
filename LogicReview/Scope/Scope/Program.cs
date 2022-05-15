namespace Scope
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco = double.Parse(Console.ReadLine());
            double desconto = 0.0;

            if (preco > 100.0)
            {
                // Pertence ao escopo da função
                desconto = preco * 0.1;
            }

            Console.WriteLine(desconto);
            // Só é possível acessar de fora pra dentro, o maior dentro do menor.

        }

    }
}