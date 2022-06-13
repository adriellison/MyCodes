using System;
using System.Globalization;

namespace triangulo
{
    class Program
    {
        static void AreaTriangulo(){
            Triangulo x;

            x = new Triangulo();

            Console.WriteLine("<--Área do Triângulo-->");

            Console.WriteLine("Insira o lado A do triângulo:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Insira o lado B do triângulo:");
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Insira o lado C do triângulo:");
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = x.Area();

            Console.WriteLine($@"
            Area do triângulo: {area:f2}
            Lado a: {x.A:f2}
            Lado b: {x.B:f2}
            Lado c: {x.C:f2}
            ");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AreaTriangulo();
        }
    }
}
