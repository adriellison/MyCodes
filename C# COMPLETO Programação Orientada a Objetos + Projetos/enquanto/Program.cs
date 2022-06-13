using System;

namespace enquanto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Digite um número:");
            double x = double.Parse(Console.ReadLine());

            while(x >= 0.0){
                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("F2"));
                Console.WriteLine("Digite outro número: ");
                x = double.Parse(Console.ReadLine());
            }

            System.Console.WriteLine("Número negativo!");
        }
    }
}
