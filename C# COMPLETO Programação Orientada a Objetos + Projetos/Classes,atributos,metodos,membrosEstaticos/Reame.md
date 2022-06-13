# Classe

- É um tipo estruturado que pode conter (membros):
  - Atributos (dados / campos)
  - Métodos (funções / operações)

- A classe também pode prover muitos outros recursos, tais como:
  - Construtores
  - Sobrecarga
  - Encapsulamento
  - Herança
  - Polimorfismo

- Exemplos:
  - Entidades: Produtos, Cliente, Triangulo
  - Serviços: ProdutoController, ClienteController
  - Utilitários: Calculadora, Compactador
  - Outros (views, repositórios, gerenciadores, etc.)

## Instanciação

(Alocação dinâmica de memória)

```c#
double areaX, areaY, p
Triangulo x, y;

x = new Triangulo();
```

## discussão

- Toda classe em C# é uma subclasse da classe `Object`

- `Object` possuo os seguintes métodos:
  - `Get Type` - retorna o tipo do objeto
  - `Equals` - compara se o objeto é igual a outro
  - `GetHashCode` - retorna um código hash do objeto
  - `ToString` - converte o objeto para string

- Demo