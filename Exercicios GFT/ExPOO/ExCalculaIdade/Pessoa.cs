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
            get { return nome; }
            set { nome = value.ToUpper(); }
        }

        public void ExibirDados()
        {
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Ano de nascimento: " + this.AnoNascimento);
            int idade = this.CalcularIdade();
            Console.WriteLine("Idade: " + idade);
        }

        private int CalcularIdade()
        {
            DateTime data = DateTime.Now;
            int ano = data.Year;
            int idade = ano - this.AnoNascimento;
            return idade; 
        }

    }
}
