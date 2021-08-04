function botao(){
	alert("Obrigado por clicar");
}

function clicou(){
	// console.log(document.getElementById("agradecimento"));
	document.getElementById("agradecimento").innerHTML = "<b>Obrigado por clicar</b>"
}

function redirecionar(){
	window.open("https://web.digitalinnovation.one/home"); // redireciona abreindo outra janela
	// window.location.href = "https://web.digitalinnovation.one/home"; // abre o link na mesma janela
}

function trocar(elemento){
	// alert("Trocar texto")
	// document.getElementById("mousemove").innerHTML = "Tire o mouse daqui";
	elemento.innerHTML = "Tire o mouse daqui";
}

function voltar(elemento){
	// document.getElementById("mousemove").innerHTML = "Passe o mouse o mouse aqui";
	elemento.innerHTML = "Passe o mouse o mouse aqui";
}

// function loud(){
// 	alert("Página carregada")
// }

function funcaoChange(elemento){
	console.log(elemento.value)
}