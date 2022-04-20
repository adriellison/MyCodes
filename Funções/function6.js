// This: O que é?

// A palavra reservada this, é uma palavra reservada que aponta para o objeto que está sendo executado.
// É uma referência de contexto. No exemplo, this refere-se ao objeto pessoa.

const pessoa = {
	firstNme: 'José',
	lastName: 'Silva',
	id: 1,
	fullName: function(){
		return this.firstName + ' ' + this.lastName;
	},
	getId: function(){
		return this.id;
	}
};

pessoa.fullName(); // José Silva

pessoa.getId(); // 1