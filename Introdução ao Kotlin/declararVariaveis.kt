// constante
const val MAX_AGE = 68
//função principal
fun main(){
    // variavel com valor imutavel na durante a execução
    val minAge:Int
    minAge = 16
    var	currentAge:Int
    currentAge = 90
    
    println(currentAge > MAX_AGE)
    println(minAge > MAX_AGE)
    
    // var (valor mutável, CamelCase):
	// Variável que pode ter seu valor alterado
	// valor definido e alterado durante a execução
	// 	var currentAge = 22

	//	var currentAge:Int?
    //	currentAge = null ou 22

    //------------------------------------------------------
    // val (valor imutável, CamelCase):
    // Variável que terá somente o valor atribuído
    // valor difinido durante a execução
	//	val currentAge = 22

	//	val currentAge:Int?
    //	currentAge = null ou 22
    
    //------------------------------------------------------
    // const Val (valor imutável, SNAKE_CASE):
    // Constante cujo valor é atribuido durante a compilação
    // valor definido durante a compilação
	//	const val MIN_AGE = 16
	//	const val MAX_AGE = 68
}