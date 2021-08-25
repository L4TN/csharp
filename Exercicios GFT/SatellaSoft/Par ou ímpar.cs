using System;
namespace sol
{
    class Program
    //Crie um algoritmo que verifique se um número informado é par ou ímpar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número para saber se é par ou ímpar:"); 
            int n = Convert.ToInt32(Console.ReadLine());
            if ( n%2 == 0)
            {
                Console.WriteLine("É par");
            }
            else
            {
                Console.WriteLine("É ímpar");
            }
        }
    }
}

