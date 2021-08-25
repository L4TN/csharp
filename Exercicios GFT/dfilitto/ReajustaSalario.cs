using System;
namespace C_
{
    class Program
    /* Faça um algoritmo que calcule e exiba o salário reajustado de dez funcionários de acordo com a seguinte regra: 
    Salário até 300, reajuste de 50%; Salários maiores que 300, reajuste de 30%.
    */
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o Salário");
            double s = Convert.ToInt32(Console.ReadLine());
            if (s<=300){s = s * 1.50; }
            else {s = s * 1.30;}
            Console.WriteLine(s);
        }
    }
}