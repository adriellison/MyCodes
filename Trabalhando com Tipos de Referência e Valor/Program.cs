using static System.Console;

namespace Trabalhando_com_Tipos_de_Referência_e_Valor
{
    public class Program
    {
        static void Demo1()
        {
            int a = 2;
            a = Adicionar20(a);

            WriteLine($"O valor é {a}");
        }

        static void Demo2()
        {

            Pessoa p0 = new Pessoa();
            p0.Nome = "Default";
            p0.Idade = 0;
            p0.Documento = "65270238047";

            Pessoa p1 = p0;

            Pessoa p2 = new Pessoa();
            p2.Documento = p0.Documento;
            p2.Nome = p0.Nome;
            p2.Idade = p0.Idade;

            WriteLine($"O nome padrão é: {p0.Nome}\n");
            TrocarNome(p0, "And");

            WriteLine($"O nome padrão foi alterado para: {p0.Nome}");

            WriteLine($@"
            O nome de p0 é : {p0.Nome}
            O nome de p1 é : {p1.Nome}
            ");
        }

        static void Demo3()
        {
            StrucPessoa p1 = new StrucPessoa()
            {
                Nome = "Julia",
                Idade = 30,
                Documento = "81422456048"
            };

            var p2 = p1;

            p1 = TrocarNome(p1, "João");

            WriteLine($"Nome do p1: {p1.Nome}");
            WriteLine($"Nome do p2: {p2.Nome}");

            // WriteLine($@"
            // Nome do p1: {p1.Nome}
            // Nome do p2: {p2.Nome}
            // ");
        }

        static void Demo4()
        {
            string nome = "And";

            TrocarNome(nome, "Nara");

            WriteLine($"O novo nome é {nome}");
        }

        static void Demo5()
        {
            int[] pares = new int[] { 0, 2, 4, 6, 8 };

            MudarParaImpar(pares);

            WriteLine($"Os impares {string.Join(",", pares)}");
        }

        static int Adicionar20(int a)
        {
            return a + 20;
        }

        static void TrocarNome(Pessoa p1, string novoNome)
        {
            p1.Nome = novoNome;
        }

        static StrucPessoa TrocarNome(StrucPessoa p1, string novoNome)
        {
            p1.Nome = novoNome;
            return p1;
        }

        static void TrocarNome(string nome, string novoNome)
        {
            nome = novoNome;
        }

        static void MudarParaImpar(int[] pares)
        {
            for (int i = 0; i < pares.Length; i++)
            {
                pares[i] = pares[i] + 1;
            }
        }

        static int EncontrarNumero(int[] numeros, int numero)
        {
            for(int i = 0; i < numeros.Length; i++)
            {
                if(numeros[i] == numero)
                {
                    return i;
                }
            }
            return -1;
        }

        static void Demo6()
        {
            int[] numeros = new int[] {0,2,4,6,8,10,12,14,16,18};

            WriteLine($"Digite o número que você procura na lista: ");
            var numero = int.Parse(ReadLine());

            var indexEncontrado = EncontrarNumero(numeros, numero);

            if(indexEncontrado >= 0)
            {
                WriteLine($"O número que procura está na posição {indexEncontrado}");
            }
            else
            {
                WriteLine($"O número que você procura não se encontra na lista!");
            }
        }

        public static void Main()
        {
            WriteLine("Hello, World!");
        }
    }
}