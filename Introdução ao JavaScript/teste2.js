// soma dois números
function soma(a, b){
	// console.log(a+b); // apenas ver
	return a + b; // retornar
}

// maior valor
function max(a, b, c, d){
	if(a > b && a > c && a > d){
		maior = a;
	}else if(b > a && b > c && b > d){
		maior = b;
	}else if(c > a && c > b && c > d){
		maior = c;
	}else if(d > a && d > b && d > c){
		maior = d;
	}
	return maior;
}
max(5, 2, 3, 4);

// valores pares do array
function returnEvenValues(array){
	var evenNums = [];
	for(let i = 0; i < array.length; i++){
		if(array[i] % 2 == 0){
			evenNums.push(array[i]);
		}
	}
	return evenNums;
}

console.log("hello word")
console.log(soma(5, 2));
console.log(max(5, 2, 8, 4));
console.log(returnEvenValues([1, 2, 3, 4, 5, 6, 7, 8, 9, 10]));