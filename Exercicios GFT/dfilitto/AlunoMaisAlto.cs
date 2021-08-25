using System;

namespace C_
{
    class Program
    /*
    Faça um algoritmo que leia a altura e a matricula de dez alunos. 
    Mostre a matricula do aluno mais alto e do aluno mais baixo.
    */

    {
        static void Main(string[] args)
        {
            Console.Write("Digite a Matrícula");
            Console.WriteLine(" e a Altura do aluno em centímetros:");
            int i = 0;
            double aux = 0;
            int aux2 = 0;
            
            while(i<10)
            {
                i++; 
                int rmAluno = Convert.ToInt32(Console.ReadLine());
                Double alturaAluno = double.Parse(Console.ReadLine());

                if (alturaAluno>aux)
                {
                    aux=alturaAluno;
                    aux2=rmAluno;
                }
                Console.WriteLine($"O aluno com Matrícula:{aux2} tem a maior altura que é de {aux}cm \n");
                Console.WriteLine("Digite a próxima matrícula e altura em centímetros do aluno:");

            }
        }
    }
}
