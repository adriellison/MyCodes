using System;
using System.Globalization;

namespace semOrientacao
{
    class Program
    {
        static void Triangulo(){
            Console.WriteLine("<--Área do Triângulo-->");
            double area, a = 0, b = 0, c = 0, p;

            Console.WriteLine("Insira o lado A do triângulo:");
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Insira o lado B do triângulo:");
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Insira o lado C do triângulo:");
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            p = (a + b + c) / 2;

            area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Console.WriteLine($@"
            Area do triângulo: {area:f2}
            Lado a: {a:f2}
            Lado b: {b:f2}
            Lado c: {c:f2}
            ");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Triangulo();
        }
    }
}
