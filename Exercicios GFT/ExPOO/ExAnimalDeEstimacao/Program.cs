using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeAnimais
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal();
            Animal b = new Animal();
            Animal c = new Animal();
            Animal d = new Animal();
            Animal e = new Animal();
            int gato = 0;
            int cachorro = 0;
            int peixe = 0;

            Console.WriteLine("Digite o nome do animal 1: ");
            a.Nome = Console.ReadLine();

            Console.WriteLine("Digite o nome do animal 2: ");
            b.Nome = Console.ReadLine();

            Console.WriteLine("Digite o nome do animal 3: ");
            c.Nome = Console.ReadLine();

            Console.WriteLine("Digite o nome do animal 4: ");
            d.Nome = Console.ReadLine();

            Console.WriteLine("Digite o nome do animal 5: ");
            e.Nome = Console.ReadLine();

            Console.WriteLine("Digite o tipo do animal 1: ");
            a.Tipo = Console.ReadLine();
            if (a.Tipo == "Cachorro") cachorro++;
            if (a.Tipo == "Gato") gato++;
            if (a.Tipo == "Peixe") peixe++;

            Console.WriteLine("Digite o tipo do animal 2: ");
            b.Tipo = Console.ReadLine();
            if (a.Tipo == "Cachorro") cachorro++;
            if (a.Tipo == "Gato") gato++;
            if (a.Tipo == "Peixe") peixe++;
            
            Console.WriteLine("Digite o tipo do animal 3: ");
            c.Tipo = Console.ReadLine();
            if (a.Tipo == "Cachorro") cachorro++;
            if (a.Tipo == "Gato") gato++;
            if (a.Tipo == "Peixe") peixe++;

            Console.WriteLine("Digite o tipo do animal 4: ");
            d.Tipo = Console.ReadLine();
            if (a.Tipo == "Cachorro") cachorro++;
            if (a.Tipo == "Gato") gato++;
            if (a.Tipo == "Peixe") peixe++;
            Console.WriteLine("Digite o tipo do animal 5: ");
            e.Tipo = Console.ReadLine();
            if (a.Tipo == "Cachorro") cachorro++;
            if (a.Tipo == "Gato") gato++;
            if (a.Tipo == "Peixe") peixe++;

            Console.WriteLine("Quantidades de cachorros: ");
            Console.WriteLine(cachorro);

            Console.WriteLine("Quantidades de gatos: ");
            Console.WriteLine(gato);

            Console.WriteLine("Quantidades de peixes: ");
            Console.WriteLine(peixe);
            Console.ReadKey();
        }
    }
}
