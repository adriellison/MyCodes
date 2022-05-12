using System;

namespace Dio{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Hello World!");

            int numeroDeVezes = 5;

            for(int i = 0; i < numeroDeVezes; i++){
                Console.WriteLine($"Teste de contagem {i}");  
            }
        }
    }
}