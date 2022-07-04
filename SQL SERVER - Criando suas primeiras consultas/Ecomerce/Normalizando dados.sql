SELECT * FROM [Ecomerce]..[Clientes];

ALTER TABLE Ecomerce..Clientes ADD CONSTRAINT pk_clientes PRIMARY KEY(Codigo);

INSERT Clientes VALUES('Julio', 'J', GETDATE());