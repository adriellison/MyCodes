CREATE TABLE Clientes(
	Codigo INT NOT NULL,
	Nome VARCHAR(100) NOT NULL,
	TipoPessoa CHAR(1) NOT NULL,
	DataCriacao DATETIME
)

CREATE TABLE Produtos(
	Codigo INT NOT NULL,
	Nome VARCHAR(100) NOT NULL,
	Descricao VARCHAR(200) NULL,
	Preco FLOAT NOT NULL
)

CREATE TABLE Pedido(
	Codigo INT NOT NULL,
	DataSolicitacao DATETIME NOT NULL,
	FlagPago BIT NOT NULL,
	TotalPedido FLOAT NOT NULL,
	CodigoCliente INT NOT NULL
)

CREATE TABLE PedidoItem(
	CodigoPedido INT NOT NULL,
	CodigoProduto INT NOT NULL,
	Preco FLOAT NOT NULL,
	Quantidade INT NOT NULL
)