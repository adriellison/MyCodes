CREATE TABLE Teste(
	Id Int PRIMARY KEY NOT NULL,
	Nome VARCHAR(50) NOT NULL,
	Descricao varchar(50) NULL,
	Sexo CHAR(10) NOT NULL
)

INSERT Teste VALUES(01, 'And', null, 'm');

SELECT * FROM Teste;