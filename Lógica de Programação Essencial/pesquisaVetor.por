programa{
	funcao inicio(){
		inteiro vetor[] = {1,2,3,4,5,6,7,9,0} //vetor com valores pré-definidos
		inteiro numero
		logico busca = falso //resultado da procura
		inteiro i

		escreva("Valor da busca? ")
		leia(numero)

		para(i=0; i<=8; i++){
			se(vetor[i] == numero){
				escreva("Valor encontrado na posição: ", i, "\n")
				busca = verdadeiro
			}
		}se(nao busca){
			escreva("Valor da busca não encontrado!\n")
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 372; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */