using System;
namespace sol
{
    class Program
    // Desenvolva uma calculadora, onde será necessário entrar com a operação, primeiro e segundo valor, exiba o resultado na tela.
    {
        static void Main (string[] args)
        {
            Console.WriteLine("####CALCULADORA####");
            Console.WriteLine("Qual a operação ? Digite um número para escolher a operação: ");
            Console.WriteLine("1 - SOMA ");
            Console.WriteLine("2 - SUBTRAÇÃO ");
            Console.WriteLine("3 - MULTIPLICAÇÃO ");
            Console.WriteLine("4 - DIVISÃO ");

            int option = int.Parse(Console.ReadLine());

            switch(option){
                case 1:
                    Console.WriteLine("Digite os dois números para a operação:" );
                    double a = double.Parse(Console.ReadLine());
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine(a+b);
                    break;
                
                case 2:
                    Console.WriteLine("Digite os dois números para a operação:" );
                    a = double.Parse(Console.ReadLine());
                    b = double.Parse(Console.ReadLine());
                    Console.WriteLine(a-b);
                    break;
                
                case 3:
                    Console.WriteLine("Digite os dois números para a operação:" );
                    a = double.Parse(Console.ReadLine());
                    b = double.Parse(Console.ReadLine());
                    Console.WriteLine(a*b);
                    break;

                case 4:
                    Console.WriteLine("Digite os dois números para a operação:" );
                    a = double.Parse(Console.ReadLine());
                    b = double.Parse(Console.ReadLine());
                    Console.WriteLine(a/b);
                    break;

            }
        }
    }
}

