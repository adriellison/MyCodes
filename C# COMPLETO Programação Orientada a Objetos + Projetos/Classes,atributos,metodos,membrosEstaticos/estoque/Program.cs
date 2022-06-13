using System;
using System.Globalization;

namespace estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            System.Console.WriteLine("\nEntre os dados do produto:");
            System.Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            System.Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            // System.Console.WriteLine($@"
            // Dados do produto: {p.Nome}, $ {p.Preco:f2}, {p.Quantidade} unidades
            // ");
            System.Console.WriteLine($"\n\t>> Dados do produto: {p}");

            // Console.WriteLine();
            Console.Write("\nDigite o número de produtos a ser adicionado: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            System.Console.WriteLine($"\n\t>> Dados atualizados: {p}");

            // Console.WriteLine();
            Console.Write("\nDigite o número de produtos a ser removido: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            System.Console.WriteLine($"\n\t>> Dados atualizados: {p}\n");
        }
    }
}
