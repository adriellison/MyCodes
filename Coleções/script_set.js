// set exemplo

const lista = [30, 30, 40, 5, 223, 2049, 3034, 5]

function valoresUnicos(arr){
	const myset = new Set(arr)

	// return myset; retorna apenas o set
	return [...myset] // com o uso de SPREAD ele retorna um array
}

console.log(valoresUnicos(lista))