using System;
namespace sol
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcula Média de 5 notas ");
            string[] line = Console.ReadLine().Split(" ");
            double A = double.Parse(line[0]);
            double B = double.Parse(line[1]);s
            double C = double.Parse(line[2]);
            double D = double.Parse(line[3]);
            double E = double.Parse(line[4]);
            double Med = (A + B + C + D + E)/5;
            Console.WriteLine(Med);   
            Console.ReadKey();         
        }
    }
}

