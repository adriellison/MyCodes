using System;
using System.Globalization;

namespace membrosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nEntre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine($"\n\tCircunferência {circ.ToString("F2")}");
            System.Console.WriteLine($"\tVolume: {volume.ToString("F2")}");
            System.Console.WriteLine($"\tValor de Pi: {Calculadora.Pi.ToString("F2")}\n");
        }
    }
}
