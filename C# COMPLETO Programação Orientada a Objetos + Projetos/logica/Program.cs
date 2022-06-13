using System;

namespace logica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            char genero = 'F';
            int idade = 32;
            double saldo = 10.358930;
            string nome = "Maria";

            System.Console.WriteLine($"\nBom dia, seu saldo é R$ {saldo:F2}");

            double a = 1.0 , b = -3.0, c = -4.0;

            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);

            System.Console.WriteLine(delta);
            System.Console.WriteLine(x1);

            // Entrada de dados
            System.Console.WriteLine("Bom dia User!");
            string frase = Console.ReadLine();
            
            System.Console.WriteLine("Insira uma cor:");
            string x = Console.ReadLine();
            System.Console.WriteLine("Insira uma cor:");
            string Y = Console.ReadLine();
            System.Console.WriteLine("Insira uma cor:");
            string Z = Console.ReadLine();

            System.Console.WriteLine("Insira uma frase com 3 palavras!");
            string[] v = Console.ReadLine().Split(' ');
            System.Console.WriteLine(v[0]);
            System.Console.WriteLine(v[1]);
            System.Console.WriteLine(v[2]);
        }
    }
}