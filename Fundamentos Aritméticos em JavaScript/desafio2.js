// let N = -1
N = parseInt(gets())
if(N>0){
	for (let num = 2; num <= N; num+=2 ) {
		if(N%2==0 && num>N){
			console.log(num-1);
			// ou posso substituir e colocar um break caso o num > N
		}else{
			console.log(num);
		}
	}
}