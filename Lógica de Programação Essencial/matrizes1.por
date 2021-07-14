programa{
	funcao inicio(){

		cadeia vetor[5]
		cadeia matriz[5][3]

		cadeia frutas[4]
		frutas[0] = "maçã"
		frutas[1] = "pera"
		frutas[2] = "uva"
		frutas[3] = "melão"

		escreva(frutas[0] + "\n")

		cadeia cesta[][] = {{"maçã","100"}, {"pera","200"}, {"melão","300"}}

		escreva("Fruta: " + cesta[0][0] + " Quantidade: " + cesta[0][1])
		escreva("Fruta: " + cesta[1][0] + " Quantidade: " + cesta[1][1])
		escreva("Fruta: " + cesta[2][0] + " Quantidade: " + cesta[2][1])
	}
}

/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 475; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = {cesta, 15, 9, 5}-{vetor, 4, 9, 5}-{matriz, 5, 9, 6};
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */