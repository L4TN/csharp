using System;

namespace C_
{
    class Program
    /*
    Faça um algoritmo que exiba quantas pessoas possuem mais de 18 anos. 
    O algoritmo deverá ler a idade de 10 pessoas.
    */

    {
        static void Main(string[] args)
        {
            var i=0;
            var a = 0;
            var qnt = 0;
            Console.WriteLine("Insira 10 idades, e retorna N de maior de idade");
            while(i<10)
            {
                i++;
                a = Convert.ToInt32(Console.ReadLine());
                    if (a>=18)
                    {
                        qnt++;
                    }
            }    
            Console.Write(qnt);
        }
    }
}
