programa{
	funcao inicio(){
		escreva("1 - Abrir Netflix\n2 - Abrir Amazon Prime\n3 - Abrir HBO GO\n4 - Sair")
		inteiro menu = 0
		escreva("\n\nSua opção: ")
		leia(menu)

		se(menu == 1){
			escreva("Abrindo Netflix")
		}se(menu == 2){
			escreva("Abrindo Amazon Prime")
		}se(menu == 3){
			escreva("Abrindo HBO Prime")
		}se(menu == 4){
			escreva("Saindo da aplicação...")
		}
	}
}

/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 384; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */