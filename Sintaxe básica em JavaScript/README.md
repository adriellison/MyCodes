# Sintaxe e Operadores

Este repositório contém conteúdo do Curso "Sintaxe básica em JavaScript", que faz parte do Basecamp de Javascript na [Digital Innovation One](https://digitalinnovation.one/).

## Tipagem

A tipagem funciona como uma regra de uso de dados, quanto mais forte for a tipagem, mais obrigatória é a declaração do tipo de dado.

A tipagem em JavaScript é fraca, a delcaração dos dados acontece de modo dinâmico.

```js
var numero = 1;
```

O JavaScript já converte o valor 1 para o tipo Number.

## Declaração de variáveis
Existem 3 modos de declarar as variáveis em JavaScript:

- var – escopo global e local, pode ter seu valor alterado, se não tiver um valor inicial será tratada como null;

- let – escopo local de bloco, pode ter seu valor alterado, se não tiver um valor inicial será tratada como null;

- const – escopo local de bloco, somente leitura, o valor inicial é obrigatório e não pode ser alterado.

## Escopo

O escopo em JavaScript define a limitação e visibilidade de um bloco de código.

- Escopo global – quando a variável é declarada fora de qualquer bloco, sua visibilidade fica disponível em todo o código.

- Escopo local – quando a variável é declarada dentro de um bloco, sua visibilidade pode ficar disponível ou não.

## Atribuição

O sinal de igualdade “=“ em JavaScript, significa atribuição.

> Ex.:

> como declarar: 

```js
var nome = “meu nome”;
```

> como ler: variável nome recebe o valor meunome;

## Comparação

Para fazermos uma comparação de valores em JavaScript usamos “==“.

> Ex.:

> como declarar:
```js
"0" == 0;
```

> como ler: “0” tem o valor igual a 0?

> nesse caso retorna true

## Comparação idêntica

Para fazermos uma comparação de valores e tipos em JavaScript usamos “===“.

> Ex.:

> como declarar:

```js
"0" === 0;
```

> como ler: “0” tem o valor e o tipo idêntico a 0?

> nesse caso retorna false

# Operadores aritméticos, relacionais e lógicos
Sintaxe Básica em JavaScript

### Operadores aritméticos
São tipos de operadores matemáticos com valor numérico:

- \+ adição;
- \- subtração;
- \* multiplicação;
- \/ divisão real;
- \% divisão inteira;
- \** potenciação;

### Operadores relacionais

São tipos de operadores que consultam a relação entre valores:

- \> maior que;
- \< menor que;
- \>= maior ou igual a;
- \<= menor ou igual a;

### Operadores lógicos

São tipos de operadores que consultam valores lógicos:

- && - “e” – considera que todos os valores sejam true;
- || - “ou” – considera que qualquer valor seja true;
- ! - “não” – inverte o valor de true para false ou vice-versa;

# Vetores ou arrays

Arrays são um tipo de lista, ou matriz de variáveis, onde cada variável possui um índice. Os valores podem ser de vários tipos.

Imagina que um array é uma caixa com várias outras caixas dentro e cada uma contendo algum valor;

> Ex.: 
```js
let array = [‘string’, 1, true...]
```

## Array

O array deve ser declarado entre colchetes “[]”, e podem guardar qualquer valor dentro de seus índices: inclusive outros arrays.

> Ex.: 
```js
let array = ['string', 1, true, false, [‘array1], [‘array2’]...]
```

Obs.: O índice só é acessado por um número inteiro, onde 0 é o primeiro índice. Cada índice é separado por vírgula.

## Manipulando Arrays

Ao ser declarado, o Array traz consigo uma série de métodos para
manipulá-lo.

- forEach() – itera um array(uma repetição para cada item dentro do array);

```js
array1.forEach(function(item, index){
	console.log(item, index);
});
```

	string 0
	1 1
	true 2
	[ 'array1' ] 3
	[ 'array2' ] 4
	[ 'array3' ] 5
	[ 'array4' ] 6

- push() – add item no final do array;

```js
array1.push("push");
console.log(array1);
```

	[ 'string', 1, true, [ 'array1' ], [ 'array2' ], [ 'array3' ], [ 'array4' ], 'push' ]

- pop() – remove item no final do array;

```js
array1.pop();
console.log(array1);
```
	[ 'string', 1, true, [ 'array1' ], [ 'array2' ], [ 'array3' ], [ 'array4' ] ]

- shift() – remove item no início do array;

```js
array1.shift();
console.log(array1);
```
	[ 1, true, [ 'array1' ], [ 'array2' ], [ 'array3' ], [ 'array4' ] ]

- unshift() – add item no início do array;

```js
array1.unshift("unshift");
console.log(array1);
```
	[ 'unshift', 1, true, [ 'array1' ], [ 'array2' ], [ 'array3' ], [ 'array4' ] ]

- indexOf() – retorna o índice de um valor;

```js
console.log(array1.indexOf(true));
```
	1

- splice() – remove ou substitui um item pelo índice;

```js
array1.splice(true, 2);
```
	[ 'unshift', 1, [ 'array1' ], [ 'array2' ], [ 'array3' ], [ 'array4' ] ]

- slice() – retorna uma parte de um array existente;
```js
console.log(array1.slice(0, 2));
```
	[ 'unshift', 1 ]

## Objetos

Dados que possuem propriedades e valores que definem suas características. Deve ser declarado entre chaves “{}”.

> Ex.: imagine uma xícara azul. Ela tem cor, pode ter vários
tamanhos e funções(quero cafééé). Pode ser declarada assim:

```js
var xicara = {
	cor: ‘azul’,
	tamanho: ‘p’,
	funcao: tomarCafe()
}
```

## Manipulando objetos

As propriedades de ojbetos podem ser atribuídas à variáveis, facilitando a manipulação do objeto. Chamamos isso de desestruturação.

> Ex.: 
```js
var xicara = {cor: ‘azul’, tamanho: ‘p’, funcao: tomarCafe()}

var cor = xicara.cor;
var tamanho = xicara.tamanho;
var funcao = tomarCafe();
```

Outra forma de fazer a desestruturação é utilizando chaves ao declarar a variável:

> Ex.: 
```js
var xicara = {cor: ‘azul’, tamanho: ‘p’, funcao: tomarCafe()}

var { cor, tamanho, funcao } = xicara;
```

# Estruturas condicionais

São instruções para realizar determinadas tarefas a partir de uma condição, seja de decisão ou repetição;

> Ex.: Um jogo precisa mudar o placar toda vez que um jogador marca pontuação;

## if

Podemos usar as palavras reservadas “if” para estabelecer uma condição:
> Ex.: 
```js
var jogador1 = 0;
var jogador2 = 0;

if (jogador1 > 0) {
	console.log(‘jogador1 marcou ponto’);
}
```
como ler: se o jogador 1 tiver valor maior que 0 ele marcou ponto.

## else

No caso de a condição não ser atendida podemos usar o “else” :
> Ex.:
```js
var jogador1 = 1;
var jogador2 = 0;

if (jogador1 > 0) {
	console.log(‘jogador1 marcou ponto’);
} else {
	console.log(‘ninguem marcou ponto’);
}
```

## else if

Caso haja mais de uma condição usamos o “else if“.
> Ex.:
```js
var jogador1 = 1;
var jogador2 = 0;

if (jogador1 > 0) {
	console.log(‘jogador1 marcou ponto’);
} else if (jogador2 > 0) {
	console.log(‘jogador2 marcou ponto’);
} else {
	console.log(‘ninguém marcou ponto);
}
```

## ninho de if

Podemos também usar o “if” dentro de um outro “if”, chamamos isso de aninhamento de if’s ou ninho de if’s.

> Ex.: 
```js
if (jogador1 = -1) {
	if (jogador1 > 0) {
		console.log(‘jogador 1 marcou ponto’);
	} else {
		console.log(‘ninguém marcou ponto’);
	}
} else {
	console.log(‘jogador inválido’);
}
```

## If ternário

Podemos também fazer uma verificação em uma única linha usando o “if” ternário:

> Ex.:

```js
[condição] ? [instrução1] : [instrução2];

jogador1 > 0 ? console.log(‘marcou ponto’) : console.log(‘não marcou ponto”);
```
Lembre de usar a interrogação “?” e dois pontos “:”

## Usando switch/case

O “switch/case” funciona como uma estrutura condicional também;

> Ex.:
```js
switch (${expressao}) {
	case 1:
		${instrucao};
		break;
	case 2:
		${instrução};
		break;
}
```

# Laços de repetição

São estruturas condicionais que repetem uma instrução até atingir
determinada condição:

## For

Funciona como uma repetição de instrução até que a condição
seja falsa:

for ([expressaoInicial]; [condicao]; [incremento]) {declaracao }

> Ex.: 
```js
var array = [‘valor1’, ‘valor2’, ‘valor3’, ‘valor4’]

for (let i = 0; i < array.length; i++) {
	console.log(i);
}
```

## For/in

Funciona como uma repetição a partir de uma propriedade:

for ([indice] in [objeto ou array]) {declaracao }

> Ex.:

```js
var array = [‘valor1’, ‘valor2’, ‘valor3’, ‘valor4’]

for (i in array) {
	console.log(i);
}
```

## For/of

Funciona como uma repetição a partir de um valor:

for ([indice] of [array]) {declaracao }

> Ex.: 
```js
var array = [‘valor1’, ‘valor2’, ‘valor3’, ‘valor4’]

for (i of array) {
	console.log(i);
}
```

O For/of não funciona com objetos pois as propriedades variam,
diferentes do índice em um array que sempre serão números
inteiros.

Mas e se eu quiser pegar o valor mesmo assim?

> Ex.:
```js
for (i of object.propriedade) {
	console.log(i);
}
```

> porém cada caractere dentro do valor será impresso em linhas separadas.

## While

Executa uma instrução “enquanto” determinada condição for
verdadeira, a verificação é feita antes da execução;

> Ex.:
```js
var a = 0;
while (a < 10) {
	a++;
	console.log(a);
}
```

>  como ler: enquanto a variável a for menor que 10 ela vai receber mais um e imprimir no console.

## Do/while

Executa uma instrução “até que” determinada condição seja falsa,
a verificação é feita depois da execução;
> Ex.:
```js
var a = 0;
do {
	a++;
	console.log(a);
} while (a < 10)
```

> como ler: a variável a vai receber mais um e imprimir no console até que seu valor chegue a 10

# Funções e suas particularidades

1. O que são funções?;
2. Como declarar funções;
3. Funções com parâmetros;

## Funções

São blocos de comandos e instruções para a execução de
determinadas tarefas:

> Ex.:
```js
function nomeDaFuncao() {
	${instrucao};
}

nomeDaFuncao();
```
Como declarar?

Geralmente se utiliza a palavra reservada “function” seguida de parênteses “()” e chaves “{}”:

> Ex.:
```js
function funcao() {
	console.log(“mensagem”);
}

funcao();
```

- () – indica que é um objeto do tipo function;
- {} – indica que é um bloco de instrução;

## Funções com parâmetros
As funções podem receber em sua declaração, parâmetros, que servem como variáveis, onde sua atribuição pode ser feita durante a chamada da função:

> Ex.:
```js
function nomeDaFuncao(parametro) {
	${instrucao};
}

nomeDaFuncao(valorDoParametro);
```
> Ex.:
```js
function mensagem(primeiro, segundo) {
	console.log(primeiro, segundo);
}

nomeDaFuncao(“Tudo certo”, “jovem!”);
```

# Aprofundando em funções

## Funções declarativas

São funções que possuem o uso mais comum, deve ser declarada usando a palavra reservada “function” seguida do nome da função, parênteses “()” e chaves “{}”:

Ex.:
```js
function nomeDaFuncao() {
	${instrucao};
}
```
// o nome da função é obrigatório;

## Expressões de Funções

São funções atribuídas à expressões. A nomeação das funções por expressão é opcional:

> Ex. 1:
```js
var funcao = function nomeDaFuncao() {
${instrucao};
}
```
> Ex. 2:
```js
var funcao = function() {
	${instrucao};
};
```

## Arrow Function

São funções de expressão de sintaxe curta. Arrow functions sempre serão anônimas, portanto não podem ser nomeadas.

Deve ser declarada com parênteses "()", seguido de "=>" e depois
chaves "{}"

> Ex. 1:
```js
var funcao = () => {
	${instrucao};
}
```

# Exercício - Criando uma calculadora
Para este exercício vamos utilizar alguns métodos nativos do JavaScript:

- Number() – para converter valores em números;
- Prompt() – para registrar entradas de usuário;
- Alert() – para mostrar mensagem ao usuário;
- Template Strings – para usar strings junto com expressões;

# Para saber mais

Funções – https://developer.mozilla.org/pt-BR/docs/Web/JavaScript/Guide/

Functions Number – https://developer.mozilla.org/pt-BR/docs/Web/JavaScript/Reference/Global_Objects/Number

Window.prompt – https://developer.mozilla.org/pt-BR/docs/Web/API/Window/pro

mpt Window.alert – https://developer.mozilla.org/pt-BR/docs/Web/API/Window/alert

Template String - https://developer.mozilla.org/pt-BR/docs/Web/JavaScript/Reference/Template_literals
