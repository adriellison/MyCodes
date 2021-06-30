programa{
	funcao inicio(){
		escreva("1 - Abrir Netflix\n2 - Abrir Amazon Prime\n3 - Abrir HBO GO\n4 - Sair")
		inteiro menu = 0
		escreva("\n\nSua opção: ")
		leia(menu)
		escolha(menu){
			caso 1:
			escreva("Abrindo Netflix")
			pare
		caso 2:
			escreva("Abrindo Amazon Prime")
			pare
		caso 3:
			escreva("Abrindo HBO Prime")
			pare
		caso 4:
			escreva("Saindo da aplicação...")
			pare
		caso contrario:
			escreva("\n\tOpção invalida\n")
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 454; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */