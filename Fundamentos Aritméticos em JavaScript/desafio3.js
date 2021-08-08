let numero = Array(5);
// let n;

for(let i =0 ; i < numero.length; i++){
    numero[i] = parseInt(gets());
}

let positivos = numero.filter(n => n > 0);
let negativos = numero.filter(n => n  < 0);
let pares = numero.filter(n => n % 2 == 0);
let impares = numero.filter(n => n % 2 != 0);

console.log(pares.length + " valor(es) par(es)");
console.log(impares.length + " valor(es) impar(es)");
console.log(positivos.length + " valor(es) positivo(s)");
console.log(negativos.length + " valor(es) negativo(s)");