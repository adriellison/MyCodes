// Call

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

// É possível passar parâmetros para essa função separando-os por vírgula.

const myObj = {
	num1: 1,
	num2: 2,
}

function soma(a, b){
	console.log(this.num1 + this.num2 + a + b);
}

soma.call(myObj, 3, 4); // 10