// Maps exemplo

function getAdmins(map){
	let admins = [];
	for([key, value] of map){
		if(value === 'Admin'){
			admins.push(key)
		}
	}
	return admins;
}

const usuarios = new Map()

usuarios.set('Adri', 'Admin')
usuarios.set('Maria', 'User')
usuarios.set('João', 'User')
usuarios.set('Pedro', 'Admin')

console.log(getAdmins(usuarios))