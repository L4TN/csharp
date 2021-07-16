using System;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(strings[] args)
        {
            int a =0,b=1,c=0;
            
            Console.Write("Insira a sequencia: ");
            int valores = int.parse(Console.ReadLine());
            Console.WriteLine("Sequencia de Fibonacci" + valores + "valores");
            
            for (int=0; < valores; i++)
            {
                if(i<valores-1)
                {
                    Console.Write(a + ", ")   
                }
                else
                {
                    Console.Write(a);
                }
                c=a+b;
                a=b;
                b=c;
        }

        Console.ReadKey();
    }
}