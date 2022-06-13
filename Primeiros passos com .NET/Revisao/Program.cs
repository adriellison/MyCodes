using System;

namespace Revisao
{
	class Program
	{
		static void Main(string[] args)
		{
			Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0;
			string opcaoUsuario = ObterOpcaoUsuario();

			while (opcaoUsuario.ToUpper() != "X")
			{
				switch (opcaoUsuario)
				{
					case "1":
						// Inserir novo aluno
						Console.WriteLine("<<-- Criar Aluno -->>");
						Console.WriteLine("Nome do aluno:");
						Aluno aluno = new Aluno();
						aluno.Nome = Console.ReadLine();

                        Console.WriteLine();

						Console.WriteLine("Nota do aluno:");
						// aluno.Nota = decimal.Parse(Console.ReadLine());
						if (decimal.TryParse(Console.ReadLine(), out decimal nota))
						{
							aluno.Nota = nota;
						}
                        else
                        {
                            throw new ArgumentException("Valor da nota deve ser decimal!");
                        }

                        alunos[indiceAluno] = aluno;
                        indiceAluno++;

						break;

					case "2":
						// Listar alunos
						Console.WriteLine("<<-- Listar alunos! -->>");
                        foreach(var a in alunos)
                        {
                            if(!string.IsNullOrEmpty(a.Nome)) // Só é retornado os valores diferentes de nulo ou vazio
                            {
                            Console.WriteLine($"Aluno: {a.Nome} - Nota: {a.Nota}\n");
                            }
                        }

						break;
					// Calcular media geral
					case "3":
						Console.WriteLine("<<-- Calcular média! -->>");
                        decimal notaTotal = 0;
                        var nrAlunos = 0;
                        for(int i=0; i < alunos.Length; i++)
                        {
                            if(!string.IsNullOrEmpty(alunos[i].Nome))
                            {
                                notaTotal = notaTotal + alunos[i].Nota;
                                nrAlunos++;
                            }
                        }

                        var mediaGeral = notaTotal / nrAlunos;

                        Conceito conceitoGeral;

                        if(mediaGeral < 2)
                        {
                            conceitoGeral = Conceito.E;
                        }
                        else if (mediaGeral < 4)
                        {
                            conceitoGeral = Conceito.D;
                        }
                        else if (mediaGeral < 6)
                        {
                            conceitoGeral = Conceito.C;
                        }
                        else if (mediaGeral < 8)
                        {
                            conceitoGeral = Conceito.B;
                        }
                        else
                        {
                            conceitoGeral = Conceito.A;
                        }
                        
                        Console.WriteLine($"MÉDIA GERAL: {mediaGeral} - CONCEITO: {conceitoGeral}");
						break;
					default:
						throw new ArgumentOutOfRangeException();
				}

				opcaoUsuario = ObterOpcaoUsuario();

			}
		}
		private static string ObterOpcaoUsuario()
		{
            Console.WriteLine();
			Console.WriteLine("|-- Informe a opção desejada --|");
			Console.WriteLine("\t1 - Criar Aluno!");
			Console.WriteLine("\t2 - Listar alunos!");
			Console.WriteLine("\t3 - Calcular média Geral!");
			Console.WriteLine("\tX - Sair!");
			Console.WriteLine();

			string opcaoUsuario = Console.ReadLine();
			Console.WriteLine();
			return opcaoUsuario;
		}
	}
}