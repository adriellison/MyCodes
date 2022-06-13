USE ecomerce;

SELECT * FROM Produtos;

SELECT * FROM Cliente;

SELECT * FROM Pedido;

SELECT * FROM PedidoItem;

INSERT Pedido VALUES(2, GETDATE(), 0, 22.49, 1);

SELECT * FROM PedidoItem;