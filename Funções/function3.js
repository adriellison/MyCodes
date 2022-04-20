// Objeto "arguments"

// Um array com todos os parâmeotros passados quando a função foi invocada.

function findMax(){
	let max = -Infinity;
	for(let i = 0; i < arguments.length; i++){
		if(arguments[i] > max){
			max = arguments[i];
		}
	}
	return max;
}

// Aqui ele verificou que o argumento 90 é maior que o valor máximo atual, então ele atualizou o valor máximo.

function showArgs(){
	return arguments;
}

// Aqui ele retornou o array com todos os argumentos passados.