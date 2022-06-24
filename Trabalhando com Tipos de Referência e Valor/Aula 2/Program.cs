using static System.Console;

namespace Aula_2
{
    class Program
    {
        static void Adicionar20(ref int a)
        {
            a += 20;
        }

        static void Demo1()
        {
            int a = 5;
            Adicionar20(ref a);
            WriteLine($"O valor de a é {a}");
        }

        static void AlternarNomes(string[] nomes, string nome, string novoNome)
        {
            for(int i = 0; i < nomes.Length; i++)
            {
                if(nomes[i] == nome)
                {
                    nomes[i] = novoNome;
                }
            }
        }

        static void Demo2() // Era a antiga main, por isso ainda tem a lista de nomes
        {
            var nomes = new string[]{"José", "Maria", "Ricardo", "Alice", "Pedro"};

            WriteLine("<< Lista de nomes >>");
            for(int i=0; i < nomes.Length; i++)
            {
                WriteLine($" - {nomes[i]}");
            }
            Write("Informe o nome a ser alterado: ");
            var nome = ReadLine();

            WriteLine("Insira o novo nome: ");
            var novoNome = ReadLine();

            AlternarNomes(nomes, nome, novoNome);

            WriteLine($"Você alterou o nome [{nome}] para [{novoNome}]");
        }

        static int LocalizarNome(string[] nomes, string nome)
        {
            for(int i = 0; i < nomes.Length; i++)
            {
                if(nomes[i] == nome)
                return i;
            }
            return -1;
        }

        static void Demo3()
        {
            var nomes = new string[]{"José", "Maria", "Ricardo", "Alice", "Pedro"};

            WriteLine("<< Lista de nomes >>");
            for(int i=0; i < nomes.Length; i++)
            {
                WriteLine($" - {nomes[i]}");
            }
            Write("\nInforme o nome a ser alterado: ");
            var nome = ReadLine();

            var indice = LocalizarNome(nomes, nome);

            if(indice >= 0)
            {
                Write("\nInsira o novo nome: ");
                var novoNome = ReadLine();

                nomes[indice] = novoNome;
                WriteLine($"Você alterou {(nome)} para {novoNome}\n");

                WriteLine("<< Lista de nomes com nome alterado >>");
                for(int i = 0; i < nomes.Length; i++)
                {
                    if(nomes[i] == novoNome)
                    {
                        WriteLine($" - [{nomes[i]}] << nome alterado");
                    }
                    else
                    {
                        WriteLine($" - {nomes[i]}");
                    }
                }
            }
            else
            {
                WriteLine("O nome não foi encontrado!");
            }
        }
        static void Main(string[] args)
        {
            // Demo1();
            // Demo2();
            Demo3();
        }
    }
}
