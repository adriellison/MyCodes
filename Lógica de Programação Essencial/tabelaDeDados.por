programa{
	funcao inicio(){
		// Criação de vetores com dados inicializados
		cadeia nome[] = {"Andre", "Thiago", "Bruno", "Carlos", "Cassio"}
		real altura[] = {1.71, 1.78, 1.75, 1.87, 1.71}
		inteiro posicao

		// cabeçalho da tabela
		escreva("--------------------\n")
		escreva("       TABELA       \n")
		escreva("--------------------\n")

		/*
		 * Percorre os vetores exibindo as informações. Note que as informações
		 * são relacionadas, colocando-as na mesma posição em ambos os vetores.
		 * Por exemplo, se quiséssemos incluir a idade de cada pessoa,
		 * criaríamos mais um vetor do tipo inteiro e a idade de Andre, seria
		 * armazenada na posição 0 do novo vetor, a idade de Thiago, na posição 1
		 * a de Bruno na posição 2, e a assim por diante.
		 */
		 para(posicao=0; posicao<5; posicao++){
		 	escreva(nome[posicao], "\t\t", altura[posicao], "\n")
		 }
		 escreva("--------------------\n")
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 914; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */