
function soma(n1, n2){
	return n1 + n2;
}

// alert(soma(10, 20));

function validaIdade(idade){
	var validar;
	if(idade >= 18){
		validar = true;
	}else{
		validar = false;
	}
	return validar
}

var idade = prompt("Qual a sua idade?");
console.log(validaIdade(idade));