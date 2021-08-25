using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooMensagem
{
    public class Mensagem
    {
        //Quando mudamos este atributo de Public para Private, no nosso Program.cs não é mais possível usar este atributo.
        //Então criaremos métodos para tentar contornar o Modificador de acesso

        private String TextoMensagem;

        public void ExibirMensagem()
        {
            //This significa usar os campos e métodos do próprio objeto
            Console.WriteLine(this.TextoMensagem);
        }

        /*
        Criaremos umm método de acesso para interagir com as características/campos/atributos do objeto
        Esse método não vai retornar nada(void) e receberá como entrada um parametro "valor"
        */

        public void getTextoMensagem(String valor)
        {
            this.TextoMensagem = valor.ToUpper;
        }

        //Criaremos um método para ler o valor contido no atributo TextoMensagem das variávies Msg1 e Msg2.
        public String setTextoMensagem()
        {
            //This significa usar os campos, métodos do próprio objeto(Msg1 ou Msg2 )
            //This significa que Pertence ao próprio objeto. 
            return this.TextoMensagem;
            //devolvo para quem efetuar a chamada
        } 
    }
}
