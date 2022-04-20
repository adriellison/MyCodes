// Arrays

// Spread: Uma forma de lidas separadamente com elementos

function sum(x, y, z){
	return x + y + z;
}

const numbers = [1, 2, 3];

console.log(sum(...numbers));

// O que era parte de um array, agora é parte de um objeto independente.


// Rest: Combina os elementos de um array em um único valor.

function confereTamanho(...args){
	return args.length;
}

confereTamanho();
confereTamanho(1, 2);
confereTamanho(1, 2, 3);

// O que era um elemento independente se torna um array.