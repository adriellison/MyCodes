# Problema exemplo

Fazer um programa para ler um valor numérico qualquer, e daí mostrar quanto seria o valor de uma circunferência e do volume de uma esfera para um raio daquele valor. Informar também o valor de PI com duas casas decimais.

_Exemplo:_

```
Entre o valor do raio: 3.0
Circunferência: 18.84
Volume: 113.04
Valor de PI: 3.14
```

## Checklist para resolução do problema

- [x] Versã0 1: Métodos na própria classe do programa
  - Nota: Dentro de um método estático você não pode chamar membros de uma instância da mesma classe.

```c#
using System;
using System.Globalization;

class Program
{
	static double Pi = 3.14;

	static void Main(string[] args)
	{
		Console.WriteLine("Entre com o valor do raio: ");
		double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

		double circ = Circunferencia(raio);
		double volume = Volume(raio);

		Console.WriteLine($"Circunferência {circ.ToString("F2")}");
		System.Console.WriteLine($"Volume: {volume.ToString("F2")}");
		System.Console.WriteLine($"Valor de Pi: {Pi.ToString("F2")}");
	}

	static double Circunferencia(double r){
		// r * Pi * r
		return 2 * Pi * r;
	}

	static double Volume(double r){ // 
		// 4 / 3 * Pi * r³ 
		return 4.0 / 3.0 * Pi * r * r * r;
	}
}
```

- [x] Versã0 2: classe Calculadora com membros de instância

```c#
using System;
using System.Globalization;

class Program
{
	static void Main(string[] args)
	{
		Calculadora calc = new Calculadora();

		Console.WriteLine("\nEntre com o valor do raio: ");
		double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

		double circ = calc.Circunferencia(raio);
		double volume = calc.Volume(raio);

		Console.WriteLine($"\n\tCircunferência {circ.ToString("F2")}");
		System.Console.WriteLine($"\tVolume: {volume.ToString("F2")}");
		System.Console.WriteLine($"\tValor de Pi: {calc.Pi.ToString("F2")}\n");
    }
}
```

```c#
public class Calculadora
{
	public double Pi = 3.14;

	public double Circunferencia(double r){
		// r * Pi * r
		return 2 * Pi * r;
	}

	public double Volume(double r){ // 
		// 4 / 3 * Pi * r³ 
		return 4.0 / 3.0 * Pi * r * r * r;
	}
}
```

- [x] Versã0 3: classe Calculadora com método estático

```c#
using System;
using System.Globalization;

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
```

```c#
public class Calculadora
{
	public static double Pi = 3.14;

	public static double Circunferencia(double r){
		// r * Pi * r
		return 2 * Pi * r;
	}

	public static double Volume(double r){ // 
		// 4 / 3 * Pi * r³ 
		return 4.0 / 3.0 * Pi * r * r * r;
	}
}
```