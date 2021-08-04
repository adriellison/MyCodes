// ---------------------- listas ----------------------
var lista = ["maçã", "pêra", "laranja"];
console.log(lista);
// alert(lista[1]);
lista.pop(); // remove o ultimo elemento da lista -laranja
lista.pop(); // remove o ultimo elemento da lista -pêra
lista.push("uva"); // adiciona um elemnto na lista
console.log(lista.length); // mostra o tamanho da lista
console.log(lista.reverse); // mostra a lista em ordem inversa
console.log(lista.toString()); // deixa de tratar como elemento para tratar como string
console.log(lista.join(" - ")); // mostra a string separada por traço e espaços

// ---------------------- dicionário ----------------------
var fruta = {nome:"maçã", cor:"vermelha"}
console.log(fruta);
console.log("a frute é: " + fruta.nome);
console.log("a cor da fruta é: " + fruta.cor);

var frutas = [{nome:"manga", cor:"amarelo"}, {nome:"uva", cor:"roxo"}, {nome:"acerola", cor:"vermelho"}];
console.log(frutas);
// alert(frutas[1].nome);