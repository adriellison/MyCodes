using System;

namespace Aula
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o primeiro valor: ");
            int valor1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Insira o segundo valor: ");
            int valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Primeiro valor: {valor1}");
            Console.WriteLine($"Segundo valor: {valor2}");

            Console.WriteLine($"\nSoma:\n{valor1} + {valor2} = {valor1 + valor2}");
        }
    }
}