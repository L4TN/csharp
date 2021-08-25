using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Mensagem msg1 = new Mensagem();
            msg1.TextoMensagem = "Olá mundo";
            msg1.ExibirMensagem();
            Console.ReadKey();
        }
    }
}
