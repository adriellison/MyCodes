# Conhecendo o C#

**Contents**
- [Conhecendo o C#](#conhecendo-o-c)
	- [Structs](#structs)
	- [Interfaces](#interfaces)
	- [Enums](#enums)

## Structs

Como as classes, as structs são estruturas de dados que podem conter membros de dados e membros de ação, mas, diferentemente das classes, as structs são tipos de valor e não requerem alocação de heap.

Uma variável de um tipo de strucct armazena diretamente os dados da estrutura, enquanto uma variável de um tipo de classe armazena uma referência a um objeto alocado na memória.

`Structs` não aceitam herança determinada pelo desenvolvedor.
São úteis para pequenas estruturas de dados que possuem semântica de valor: números complexos, pontos em um sistema de coordenadas ou pares de chave-valor em um dicionário são bons exemplos de utilização.

O uso de `structs` em vez de classes para pequenas estruturas de dados pode fazer uma grande diferença no número de alocações de memória.


```c#
public static void main(){
	Ponto[] pontos = new Ponto[100];
	for(int i = 0; i < 100; i++)
		pontos[i] = new Ponto(i, i);
}
```

```c#
public struct Ponto{
	public int x, y;
	public Ponto(int x, int y){
		this.x = x;
		this.y = y;
	}
}
```

Construtores de `structs` são chamados com o operador `new`, semelhante a um construtor de classe, mas em vez de alocar dinamicamente um objeto no _heap_ gerenciado e retornar uma referência a ele, um construtor `struct` simplesmente retorna o próprio valor `struct` (normalmente em um local temporário na stack), e esse valor é copiado conforme necessário.

## Interfaces

Uma interface define um contrato que pode ser implementado por `classes` e `structs`

Uma interface pode conter métodos, propriedades, eventos e indexadores.

Uma interface não fornece implementações dos membros que define - apenas suas "assinaturas"

As interfaces podem empregar herança múltipla.

```c#
interface IControl{
	void Paint();
}

Interface IListBox{
	void SetText(string text);
}

interface IComboBox: IControl, IListBox{}

inteface IDataBound{
	void Bind(Binder b);
}

public class EditBox: IComboBox, IDataBound{
	public void Paint(){}
	public void SetText(string text){}
	public void Bind(Binder b){}
}
```

## Enums

Um `enum` é um tipo de valor distinto com um conjunto de constantes nomeadas.

Você define enumerações quando precisa definir um tipo que pode ter um conjunto de valores discretos.
Eles usam um dos tipos de valor integral como armazenamento subjacente. Eles fornecem significado semântico aos valores discretos.

```c#
enum Cor{
	Vermelho,
	Verde,
	Azul
}

static void EscreverCor(Cor cor){
	switch(cor){
		case Cor.Vermelho:
			Console.WriteLine("Vermelho");
			break;
		case Color.Verde:
			Console.WriteLine("Verde");
			break;
	}
}
```

Cada tipo de `enum` possui um tipo integral correspondente chamado tipo subjacente do tipo de `enum.

Um tipo de enumeração que não declara explicitamente um tipo subjacente tem um tipo subjacente `int`.

```c#
enum Alinhamento: sbyte{
	Esquerda = -1,
	Centro = 0,
	Direita = 1
}
```

---
[>> Voltar ao ínicio >>](#conhecendo-o-c)