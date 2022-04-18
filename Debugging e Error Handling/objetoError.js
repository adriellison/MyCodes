// new Error(message, fileName, lineNumber)

// todos os parâmetros são opcionais

const MeuErro = new Error()

// definindo nome para meu erro
MeuErro.name = "InvalidMessage"

MeuErro.message = "Mensagem inválida"
// throw MeuErro

// - Verificar informações no console -
// MeuErro.name
// MeuErro.message

// Verifica a pilha de chamadas
// MeuErro.stack

// Mostra meu erro
// MeuErro