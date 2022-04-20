// Apply

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

// É possível passar parâmetros para essa função dentro de um array.

const myObj = {
	num1: 1,
	num2: 2,
}

function soma(a, b){
	console.log(this.num1 + this.num2 + a + b);
}

soma.apply(myObj, [3, 4]); // 10