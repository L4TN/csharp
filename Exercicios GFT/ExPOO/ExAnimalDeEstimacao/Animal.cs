using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeAnimais
{
    public class Animal
    {
        private String nome;

        public String Nome
        {
            get { return this.nome; }
            set { this.nome = value.ToUpper(); }
        }

        private String tipo;

        public String Tipo
        {
            //valores definidos pelo desenvolvedor
            get { return tipo; }
            set 
            {if (value == "Cachorro" || value == "Gato")
                {tipo = value;}
             else
                {tipo = "Peixe";}
            }
        }


    }
}
