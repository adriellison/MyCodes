using static System.Console;

namespace Aula_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();

            p1.Nome = "And";
            p1.Idade = 20;
            // p1.EnderecoPessoa = default;
            p1.EnderecoPessoa = new Endereco()
            {
                Logradouro = "Rua teste",
                Numero = 1236,
                CEP = "62000000",
                Cidade = "Russas"
            };
        }
    }
}
