// retornando string para contornar erro

function verificaPalindromo(string){
	if(!string) throw "String inválida"

	return string === string.split("").reverse().join("")
}

// verificaPalindromo("arara");
verificaPalindromo("cat");