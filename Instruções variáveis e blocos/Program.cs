using System;

namespace instruções_pratica
{
    class Program
    {
        static void Declaracoes()
        {
            int a;
            int b = 2, c=3; 
            a = 1 ;
            const int d = 4;
            Console.WriteLine(a+b+c+d);
        }

        static void InstrucaoIf(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Nenhum Argumento")
            }
            else if (args.Length == 1)
            {
                Console.WriteLine("Um Argumento")
            }
            else
            {
                Console.WriteLine($"{args.Length}Argumento")
            }

        }

        static void InstrucaoSwitch(string[] arg)
        {
            int numeroDeArgumentos = args.Length;
            switch (numeroDeArgumentos)
            {
                case 0:
                    Console.WriteLine("Nenhum argumento");
                    break;
                case 1:
                    Console.WriteLine("Um argumento");
                    break;
                default:
                    Console.WriteLine($"{numeroDeArgumento} argumento");
                    break;
            }

        }
        static void InstrucaoWhile(string[] args)








    }
}

        

