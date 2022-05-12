// tipos primitivos

var v0ouF = false
console.log(v0ouF)

// number
var numero = 10
console.log(numero)
console.log(typeof numero)

// string
var texto = 'texto'
console.log(texto)
console.log(typeof texto)

// Como declarar
var variavel = "valor"
variavel = "novo valor"
console.log(variavel)

let variavel2 = "valor"
variavel2 = "novo valor"
console.log(variavel2)

const variavel3 = "valor"
variavel3 = "novo valor"
console.log(variavel3)

var escopoGlobal = "global"
console.log(escopoGlobal)

function escopoLocal() {
	var escopoLocal = "local"
	console.log(escopoLocal)
}

escopoLocal()

// atribuição
atribuicao = "novo valor"

// comparação
comparacao = "0" == 0 // true

// Comparação identica
comparacaoIdentica = 10 === "10" // false