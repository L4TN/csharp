using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooMensagem
{
    class Program
    {
        static void Main(string[] args)
        {
            Mensagem msg1,msg2;
            msg1 = new Mensagem();
            //msg1.TextoMensagem = "Hello World";
            ms1.setTextoMensagem("Hello World");
            Console.WriteLine(msg1.setTextoMensagem());
            //msg1.ExibirMensagem();

            msg2 = new Mensagem();
            //msg2.TextoMensagem = "Segundo objeto";

            //Esse método exclui a necessidade de usar o Console.WriteLine
            msg2.ExibirMensagem();

            //Console.WriteLine(msg1.TextoMensagem);
            Console.ReadKey();
        }
    }
}
