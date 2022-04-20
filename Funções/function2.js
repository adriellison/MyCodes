// Função auto-invocada

// IIFE(Immediately Invoked Function Expression)

// Uma função anônima entre parênteses, seguida por outro parênteses, que representa sua chamada.

(
	function(){
		let name = 'José';
		return name;
	}
)();

// Também pode ser utilizada com parâmetros ou armazenada em uma variável.

(
	function(a, b){
		return a + b;
	}
)(2, 3);

const somaex = (
	function(a, b){
		return a + b;
	}
)(2, 3);

console.log(somaex);

// Callback
// Utilizando callbacks, você tem maior controle da ordem de chamadas.

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