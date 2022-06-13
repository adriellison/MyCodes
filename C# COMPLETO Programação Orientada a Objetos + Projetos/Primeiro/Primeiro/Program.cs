using System;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string s = Console.ReadLine();

            string[] vet = s.Split(' ');

            Console.WriteLine($"palavra 1: {vet[0]}");
            Console.WriteLine($"palavra 2: {vet[1]}");
            Console.WriteLine($"palavra 3: {vet[2]}");
        } 
    }
}
