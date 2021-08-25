using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooCalculaIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que calcula a idade de uma pessoa");
            //utilizo o método construtor "Pessoa();"
            //Método Construtor tem o mesmo nome da classe "Pessoa"
            Pessoa p = new Pessoa();
            Console.WriteLine("Nome da pessoa: ");          
            p.Nome = Console.ReadLine();
            Console.WriteLine("Ano de nascimento da pessoa: ");
            p.AnoNascimento = int.Parse(Console.ReadLine()); //ou "Converte.ToInt32"
            p.ExibirDados();
            Console.ReadKey();


        }
    }
}
