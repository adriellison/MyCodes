# Funções

Repositório referente ao curso "Funções" na [Digital Innovation One](https://digitalinnovation.one/).

- Como declarar funções
- Como manipular parâmetros
- Apresentar loops e outras declarações
- Apresentação do argumento "this"

#### Estrutura e Função anônima

```js
function nome(parametros){
	// código
	return; // valor de retorno
}
```

```js
const soma = function(x, y){
	return x + y;
}

soma (2, 3);
soma(5, 4);
```

#### Função auto-invocada

IIFE(Immediately Invoked Function Expression)
Uma função anônima entre parênteses, seguida por outro parênteses, que representa sua chamada.

```js
(
	function(){
		let name = 'José';
		return name;
	}
)();
```

> Também pode ser utilizada com parâmetros ou armazenada em uma variável.


```js
(
	function(a, b){
		return a + b;
	}
)(2, 3);
```

```js
const somaex = (
	function(a, b){
		return a + b;
	}
)(2, 3);

console.log(somaex);
```

#### Callbacks

Utilizando callbacks, você tem maior controle da ordem de chamadas.

```js
const calc = function(operacao, num1, num2){
	return operacao(num1, num2);
}

const soma = function(num1, num2){
	return num1 + num2;
}

const subtracao = function(num1, num2){
	return num1 - num2;
}

const resultSoma = calc(soma, 2, 3);
const resultSub = calc(subtracao, 2, 3);
```

#### Objeto "arguments"

Um array com todos os parâmetros passados quando a função foi invocada.

> Aqui ele verificou que o argumento 90 é maior que o valor máximo atual, então ele atualizou o valor máximo.

```js
function findMax(){
	let max = -Infinity;
	for(let i = 0; i < arguments.length; i++){
		if(arguments[i] > max){
			max = arguments[i];
		}
	}
	return max;
}
```
> Aqui ele retorna o array com todos os argumentos passados.

```js
function showArgs(){
	return arguments;
}
```

#### Arrays

**Spread:** Uma forma de lidar separadamente com elementos

```js
function sum(x, y, z){
	return x + y + z;
}

const numbers = [1, 2, 3];

console.log(sum(...numbers));
```

> O que era parte de um array, agora é parte de um objeto independente.

**Rest:** Combina os elementos de um array em um único valor.

```js
function confereTamanho(...args){
	return args.length;
}

confereTamanho();
confereTamanho(1, 2);
confereTamanho(1, 2, 3);
```

> O que era um elemento independente se torna um array.

#### Objetos

**Object Destructuring:** A sintaxe de atribuição via desestruturação (destructuring assignment) é uma expressão JavaScript que possibilita extrair dados de arrays ou objetos em variáveis distintas.

```js
const user = {
	id: 42,
	displayName: 'John',
	fullName: {
		firstName: 'John',
		lastName: 'Doe'
	},
};

function userId({id}) {
	return id;
}

function fetFullName({fullName: {firstName: first, lastName: last}){
	return `${first} ${last}`;
}

userId(user); // 42

getFullName(user); // John Doe
```

> Entre chaves {}, podemos filtrar apenas os dados que nos interessam em um objeto.

#### This: O que é?

A palavra reservada this, é uma palavra reservada que aponta para o objeto que está sendo executado.

> É uma referência de contexto. No exemplo, this refere-se ao objeto pessoa.

```js
const pessoa = {
	firstNme: 'José',
	lastName: 'Silva',
	id: 1,
	fullName: function(){
		return this.firstName + ' ' + this.lastName;
	},
	getId: function(){
		return this.id;
	}
};

pessoa.fullName(); // José Silva

pessoa.getId(); // 1
```

#### Call

```js
const pessoa = {
	nome: 'José',
}

const animal = {
	nome: 'Dino',
}

function getSomething(){
	console.log(this.nome);
}

getSomething.call(pessoa); // José
getSomething.call(animal); // Dino
```

> É possível passar parâmetros para essa função separando-os por vírgula.

```js
const myObj = {
	num1: 1,
	num2: 2,
}

function soma(a, b){
	console.log(this.num1 + this.num2 + a + b);
}

soma.call(myObj, 3, 4); // 10
```

#### Apply

```js

const pessoa = {
	nome: 'José',
}

const animal = {
	nome: 'Dino',
}

function getSomething(){
	console.log(this.nome);
}

getSomething.apply(animal); // Dino
```

> É possível passar parâmetros para essa função dentro de um array.

```js
const myObj = {
	num1: 1,
	num2: 2,
}

function soma(a, b){
	console.log(this.num1 + this.num2 + a + b);
}

soma.apply(myObj, [3, 4]); // 10
```

#### Bind

Clona a estrutura da função onde é chamada e aplica o valor do objeto passado como parâmetro.

```js
const retornaNomes = function(){
	return this.nome;
}

let bruno = retornaNomes.bind({nome: 'Bruno'});

bruno(); // Bruno
```

## Atividade 1: Alunos Aprovados

1. Crie uma função que recebe o array `alunos` e um número que irá representar a média final;
2. Percorra o array e popule um novo array auxiliar apenas com os alunos cujas notas são maiores ou iguais à média final;
3. Utilize a técnica "object destructuring" para manipular as propriedades desejadas de cada aluno.

## Atividade 2: This

Dada a função `calculaIdade`, utilize os métodos call e apply para modificar o valor de `this`. Crie seus próprios objetos para esta atividade!

```js
function calculaIdade(anos) {
	return `Daqui a ${anos} anos, ${this.nome} terá ${
		this.idade + anos
	} anos de idade.`;
}
```