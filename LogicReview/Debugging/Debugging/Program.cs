namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        
        {

            /* Atalhos
                F9: debugger
                F10: Executar um passo
                F11: Executa um passo entrando na função
                Shift + F11: Sair do método em execução
                Shift + F5: Interromper debugger
            */
            Console.WriteLine("Digite três números: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double resultado = Maior(n1, n2, n3);

            Console.WriteLine("Maior = " + resultado);
        }


        static int Maior(int a, int b, int c)
        {
            int m;
            if (a > b && a > c)
            {
                m = a;
            }
            else if (b > c)
            {
                m = b;
            }
            else
            {
                m = c;
            }
            return m;
        }
    }
}