function jogo(){
	var jogador1 = 1
	var jogador2 = 0
	var placar
	
	jogador1 != -1 && jogador2 != -1 ? console.log("Jogadores válidos!") : console.log("Jogadores inválidos!")
		
	if(jogador1 > 0){
	console.log("Jogador 1 marcou ponto")
	}else if(jogador2 > 0){
	console.log("Jogador 2 marcou ponto")
	}else{
	console.log("Ninguem marcou ponto")
	}
}

function testeSwitch(jogador1, jogador2){
	switch(placar){
		case placar = jogador1 > jogador2:
			console.log("Jogador 1 venceu")
			break
		case placar = jogador2 > jogador1:
			console.log("Jogador 2 venceu")
			break
		default:
			console.log("Empate")
	}
}

function testeFor(){
	let array = ["valor1", "valor2", "valor3", "valor4", "valor5"]
	
	
	// for - executa uma instrução até que ela seja falsa
	for(let indice = 0; indice < array.length; indice++){
		console.log("Valor do array: " + array[indice])
	}
}

function testeForIn(){
	// for/in executa repetição a partir de uma propriedade
	let array = ["valor1", "valor2", "valor3", "valor4", "valor5"]
	let object = {propriedade1: "valor1", propriedade2: "valor2", propriedade3: "valor3"}
	
	// com array
	for(let i in array){
		console.log(i)
	}
	
	// com object
	for(i in object){
		console.log(i)
	}
}

function testeForOf(){
	let array = ["valor1", "valor2", "valor3", "valor4", "valor5"]
	
	for(i of array){
		console.log(i)
	}
}

// var a = 0
// while(a < 10){
// 	console.log("Valor de a: " + a)
// 	a++
// }

var b = 0
do{
	b++
	console.log(b)
}while(b<5)  // a será incrementado até que seja menor que 5