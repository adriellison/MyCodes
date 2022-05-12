using System;

namespace Estruturas
{
	class Program{
		static void Main(string[] args){
			Console.WriteLine("Hello World!");
		}

        static void InstrucaoIF(){
            int a = 10;
            if(args.Length == 0){
                Console.WriteLine("Nenhum argumento");
            }else if(args.Length == 1){
                Console.WriteLine("1 argumento");
            }else{
                Console.WriteLine($"{args.Length} argumentos");
            }
        }

        static void InstrucaoSwitch(){
            int numeroDeArgumentos = args.Length;
            switch(numeroDeArgumentos){
                case 0:
                    Console.WriteLine("Nenhum argumento");
                    break;
                case 1:
                    Console.WriteLine("1 argumento");
                    break;
                default:
                    Console.WriteLine($"{numeroDeArgumentos} argumentos");
                    break;
            }
        }

        static void InstrucaoWhile(){
            int i = 0;
            while(i < args.Length){
                Console.WriteLine(args[i]);
                i++;
            }
        }

        static void InstrucaoDo(){
            string texto;
            do{
                texto = Console.ReadLine();
                Console.WriteLine(texto);
            } while(!string.IsNullOrEmpty(texto));
        }

        static void InstrucaoFor(){
            for(int i = 0; i < args.Length; i++){
                Console.WriteLine(args[i]);
            }
        }

        static void InstrucaoForeach(){
            foreach(string argumento in args){
                Console.WriteLine(argumento);
            }
        }

        static void InstrucaoBreak(){
            while(true){
                string texto = Console.ReadLine();

                if(string.IsNullOrEmpty(texto)){
                    break;
                }

                console.WriteLine(texto);
            }
        }

        static void InstrucaoContinue(){
            for(int i = 0; i < args.Length; i++){
                if(args[i].StartsWith("-")){
                    continue;
                }

                console.WriteLine(args[i]);
            }
        }

        static void InstrucaoReturn(String[] args){
            int Somar(int a, int b){
                return a + b;
            }

            Console.WriteLine(Somar(1, 2));
            Console.WriteLine(Somar(3, 4));
            Console.WriteLine(Somar(5, 6));

            return;
        }

        static void InstrucaoTryCatchFinallyThrow(String[] args){
            double Dividir(double x, double y){
                throw new DivideByZeroException();
                return x / y;
            }

            try{
                if(args.Length != 2){
                    throw new InvalidOperationException("Informe 2 números");
                }

                double x = double.Parse(args[0]);
                double y = double.Parse(args[1]);
                Console.WriteLine(Dividir(x, y));
            }catch(InvalidOperationException e){
                Console.WriteLine(e.Message);
            }catch(Exception e){
                Console.WriteLine($"Erro genérico: {e.Message}");
            }finally{
                Console.WriteLine("Fim");
            }
        }

        static void IntrucaoUsing(String[] args){
            // using(System.IO.TextWriter w = System.IO.File.CreateText("teste.txt")){
            //     w.WriteLine("Line 1");
            //     w.WriteLine("Line 2");
            //     w.WriteLine("Line 3");
            // }
            
            Write = System.IO.File.CreateText("teste.txt");

            w.WriteLine("text");

            w.dispose();
        }

	}
}
