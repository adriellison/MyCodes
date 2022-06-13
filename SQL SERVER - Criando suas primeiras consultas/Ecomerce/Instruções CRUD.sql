-- Criando o banco de dados de ecomerce
CREATE DATABASE ecomerce;

-- Usando o banco de dados ecomerce
USE ecomerce;

-- Selecioando todos os registros da tabela Clientes
SELECT * FROM  Cliente;

-- Inserir dados
INSERT INTO Cliente(Codigo, Nome, TipoPessoa) VALUES(1, 'Thiago Abreu', 'F');

INSERT Cliente Values (2, 'Amanda Feitosa', 'F');

INSERT Cliente Values (3, 'Nug LTDA', 'J');

INSERT Cliente Values (4, 'Net Store', 'J');

-- Listar todos os clientes por tipo Pessoa Fisica - F ou Juridica - J
SELECT * FROM Cliente WHERE TipoPessoa = 'J';

SELECT * FROM Cliente WHERE TipoPessoa = 'F';

-- Atualizar dados de um cliente
UPDATE Cliente SET Codigo = 3, Nome = 'Ninho do Ecomerce' WHERE Codigo = 3; 

-- Deletar todos os Clientes com Code 2
DELETE FROM Cliente WHERE Codigo in(2);

DELETE FROM Cliente WHERE Codigo = '2';