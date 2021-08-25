using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo
{
    class Mensagem
    {
        public String textoMensagem;

        public String TextoMensagem
        {
            get
            {
                return this.textoMensagem;
            }

            set
            {
                this.textoMensagem = value;
            }
        }

        public void ExibirMensagem()
        {
            Console.WriteLine(this.TextoMensagem);
        }
    }
}
