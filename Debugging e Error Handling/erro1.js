// retornando erro

function verificaPalindromo(string){
	if(!string) return "String inválida"

	return string === string.split("").reverse().join("")
}

// verificaPalindromo("arara");
verificaPalindromo("cat");