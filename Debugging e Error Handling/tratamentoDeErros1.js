// tratamento de erro com return e throw

// retorna uma string qualquer ao inves do erro
function verificaPalindromo1(string) {
	if(!string) return "String inválida"

	return string === string.split('').reverse().join('')
}

// trata a string como um erro mesmo
function verificaPalindromo2(string) {
	if(!string) throw "String inválida"

	return string === string.split('').reverse().join('')
}

// verificaPalindromo('arara')
verificaPalindromo('cat')