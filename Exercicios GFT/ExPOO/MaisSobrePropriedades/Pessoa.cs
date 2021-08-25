using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooCalculaIdade
{
    public class Pessoa
    {
        //Ao digitar o comando "propfull" e der um tab , ele cria a estrutura abaixo, onde os campos são protegidos
        private int anoNascimento;

        public int AnoNascimento
        {
            //Vamos por o this. para dizer que é algo que vai pertencer ao objeto(não é necessário por)
            get { return this.anoNascimento; }
            set { anoNascimento = value; }
        }

        private String nome;

        public String Nome
        {
            get { return this.nome; }
            set { nome = value.ToUpper(); }
        }

        //Vamos melhorar
        private int idade;

        public int Idade
        {
            this.CalcularIdade();
            get 
            { 
                return this.idade; 
            }
        }


        public void ExibirDados()
        {
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Ano de nascimento: " + this.AnoNascimento);
            this.CalcularIdade();
            Console.WriteLine("Idade: " + this.Idade);
        }

        private void CalcularIdade()
        {
            DateTime data = DateTime.Now;
            int ano = data.Year;
            this.idade = ano - this.AnoNascimento;
        }

    }
}
