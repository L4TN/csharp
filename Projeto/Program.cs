using System;

namespace Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            int indiceAluno = 0;
            string opcaoUsuario = ObterOpcaoUsuario();
            
            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                    Console.WriteLine("Informe o nome do aluno:");
                    var aluno = new Aluno();
                    aluno.Nome = Console.ReadLine();
                    
                    Console.WriteLine("Informe a nota do aluno:");

                    if (int.TryParse(Console.ReadLine(), out int nota))
                    {
                        aluno.Nota = nota;      
                    }
                    else
                    {
                        throw new ArgumentException("Valor da nota deve ser decimal");
                    }
                    alunos[indiceAluno] = aluno;
                    indiceAluno++;


                        //TODO: adicionar aluno
                        break;
                    case "2":
                        foreach(var a in alunos)
                        {
                            if (!string.IsNullOrEmpty(a.Nome))
                            {
                                Console.WriteLine($"ALUNO: {a.Nome} - NOTA {a.Nota}");
                            }
                                
                        }
                            
                        //TODO: listar alunos
                        break;

                    case "3":
                        decimal notatotal = 0;
                        var nrAlunos= 0;
                        for(int i= 0; i<alunos.Length;i++)
                            if (string.IsNullOrEmpty(alunos[i].Nome))
                                notatotal = notatotal + (decimal)alunos[i].Nota;
                                nrAlunos++;

/*
                        var mediaGeral = notatotal/nrAlunos;
                        Conceito conceitoGeral;
                        if(mediaGeral <2)
                        {
                            conceitoGeral = Conceito.E;

                        }
                        else if(mediaGeral<4)
                        {
                            conceitoGeral=Conceito.D;
                        }
                        else if(mediaGeral<6)
                        {
                            conceitoGeral = Conceito.C;
                        }
                        else if(mediaGeral<8)
                        {
                            conceitoGeral = Conceito.B;
                        }
                        else if(mediaGeral<10)
                        {
                            conceitoGeral = Conceito.A;
                        }
                        

                        Console.WriteLine($"MÉDIA GERAL: {mediaGeral} - CONCEITO: {conceitoGeral}");
*/
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }

        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular média Geral");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            return opcaoUsuario;
        }
    }
}
