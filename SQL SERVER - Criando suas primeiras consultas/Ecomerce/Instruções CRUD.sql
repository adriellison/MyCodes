-- Criando o banco de dados de ecomerce
CREATE DATABASE Ecomerce;

-- Usando o banco de dados ecomerce
USE Ecomerce;

-- Selecioando todos os registros da tabela Clientes
SELECT * FROM  Cliente;

-- Inserir dados
INSERT INTO Clientes(Codigo, Nome, TipoPessoa) VALUES(1, 'Thiago Abreu', 'F');

INSERT Clientes Values (2, 'Amanda Feitosa', 'F');

INSERT Clientes Values (3, 'Nug LTDA', 'J');

INSERT Clientes Values (4, 'Net Store', 'J');

-- Listar todos os clientes por tipo Pessoa Fisica - F ou Juridica - J
SELECT * FROM Clientes WHERE TipoPessoa = 'J';

SELECT * FROM Clientes WHERE TipoPessoa = 'F';

-- Atualizar dados de um cliente
UPDATE Clientes SET Codigo = 3, Nome = 'Ninho do Ecomerce' WHERE Codigo = 3; 

-- Deletar todos os Clientes com Code 2
DELETE FROM Clientes WHERE Codigo in(2);

DELETE FROM Clientes WHERE Codigo = '2';