using static System.Console;

namespace Aula_4
{
    public class Numero
    {
        public int N { get; set;}
        public Numero(int n)
            {
                N = n;
            }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Numero a = new Numero(2);
            Numero b = new Numero(2);

            if(a.N == b.N)
            {
                WriteLine($"a e b são iguais");
            }
            else
            {
                WriteLine($"a e b são diferentes");
            }
        }
    }
}
