SELECT * FROM Pedido;

INSERT Pedido VALUES(1, GETDATE(), 0, 3, 4);
INSERT Pedido VALUES(2, GETDATE(), 1, 3, 2);
INSERT Pedido VALUES(3, GETDATE(), 1, 3, 1);
INSERT Pedido VALUES(4, GETDATE(), 1, 35, 3);
INSERT Pedido VALUES(5, GETDATE(), 0, 25, 3);
INSERT Pedido VALUES(6, GETDATE(), 0, 50, 3);

SELECT * FROM PedidoItem;

INSERT PedidoItem VALUES(1, 3, 20, 3);
INSERT PedidoItem VALUES(2, 5, 50, 3);
INSERT PedidoItem VALUES(3, 4, 75, 3);
INSERT PedidoItem VALUES(4, 1, 35, 35);
INSERT PedidoItem VALUES(5, 2, 30, 25);
INSERT PedidoItem VALUES(6, 3, 20, 50);

SELECT Clientes.nome, Pedido.TotalPedido FROM Clientes JOIN Pedido ON Cliente.Codigo = Pedido.CodigoCliente WHERE Clientes.Codigo = 3;