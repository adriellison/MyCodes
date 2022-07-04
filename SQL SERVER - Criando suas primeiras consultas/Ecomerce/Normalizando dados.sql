SELECT * FROM [ecomerce]..[Cliente];

ALTER TABLE ecomerce..Cliente ADD CONSTRAINT pk_cliente PRIMARY KEY(Codigo);

INSERT Cliente VALUES('Julio', 'J', GETDATE());