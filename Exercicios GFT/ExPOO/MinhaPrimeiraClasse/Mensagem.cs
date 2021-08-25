using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooMensagem
{
    public class Mensagem
    {
        public String TextoMensagem;

        public void ExibirMensagem()
        {
            //This significa usar os campos e métodos do próprio objeto
            Console.WriteLine(this.TextoMensagem);
        }
    }
}
