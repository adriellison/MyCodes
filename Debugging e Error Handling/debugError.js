// Crie uma função que recebe um array e um número
function validarArray(arr, num){
	// Utilize a declaração try/catch
	try{
		// Relize as seguintes validações:
		// Se os parâmetros não forem enviados, lance um erro do tipo ReferenceError
		if(!arr && !num) throw new ReferenceError("Array não definido, envie os parametros corretamente")
		
		// Se o array não for do tipo 'object', lance um erro do tipo TypeError
		if(typeof arr !== 'object') throw new TypeError("Array precisa ser do tipo object")
		
		// Se o número não for do tipo 'number', lance um erro do tipo TypeError
		if(typeof num !== 'number') throw new TypeError("Num precisa ser do tipo number")
		
		// Se o tamanho do array for diferente do número enviado como parâmetro, lance um erro do tipo RangeError
		if(arr.length !== num) throw new RangeError("Array precisa ter o tamanho igual ao numero enviado")
		
		// se retornar o array, é um caso de sucesso
		return arr
	}catch(e){
		// Filtre as chamadas de catch por cada tipo de erro utilizando o operador instanceof
		if(e instanceof ReferenceError){console.log("Este erro é um ReferenceError!", e.name, e.message)}
		else if(e instanceof TypeError){console.log("Este erro é um TypeError!", e.name, e.stack, e.message)}
		else if(e instanceof RangeError){console.log("Este erro é um RangeError!", e.name, e.stack, e.message)}
		else{console.log("Este erro é um erro desconhecido!", e, e.name, e.stack, e.message)}
		// sendo o .stack que mostra todos os detalhes do erro, .name mostra o nome do erro, .message mostra a mensagem do erro
	}
}

// console.log(validarArray())
console.log(validarArray([1, 6, 3, 2, 7], 5))