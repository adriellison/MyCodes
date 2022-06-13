using System;

namespace funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maior valor - A B C\n");
            Console.WriteLine("Digite o valor de A");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de C");
            int n3 = int.Parse(Console.ReadLine());

            double resultado = Maior(n1, n2, n3);

            Console.WriteLine($"{resultado} é o maior valor!");
        }

        static int Maior(int x, int y, int z){
            if(x > y && x > z){
                return x;
            }else if(y > x && y > z){
                return y;
            }else{
                return z;
            }
        }
    }
}
