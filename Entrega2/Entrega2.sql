-- DROP DATABASE Bodega
CREATE DATABASE Bodega
GO
USE Bodega
GO

CREATE TABLE [dbo].[Producto] (
	idprod CHAR(7) PRIMARY KEY,
	nombre VARCHAR (100),
	descripcion VARCHAR (100),
	existencias INT,
	precio DECIMAL (10,2),
	preciov DECIMAL (10,2),
	ganancia AS  preciov - precio,
	CHECK (preciov>precio)
)
GO
-- TRUNCATE TABLE [dbo].[Producto];

CREATE TABLE [dbo].[Pedido] (
	idpedido CHAR(7) UNIQUE,
	idprod CHAR (7),
	cantidad INT,
	FOREIGN KEY (idprod) REFERENCES [dbo].[Producto] (idprod)
)
GO
-- TRUNCATE TABLE [dbo].[Pedido];

CREATE TRIGGER UpdateProducts
ON [dbo].[Pedido]
AFTER INSERT 
AS
BEGIN
	UPDATE [dbo].[Producto]
	SET existencias = existencias - i.cantidad
	FROM [dbo].[Producto] t
	INNER JOIN inserted i ON t.idprod = i.idprod;
END
GO

INSERT INTO [dbo].[Producto] (idprod, nombre, descripcion, existencias, preciov, precio)
VALUES
('P001', 'Shampoo', 'Shampoo anticaída y anticaspa', 43, 10.50, 8),
('P002', 'Agua alpina 500mL', 'Bebida hidratante', 100, 0.60, 0.30),
('P003', 'Sopa Maruchan', 'Deliciosa sopa para sacarte de un apuro', 63, 1, 0.60),
('P004', 'Bolsa de Arroz 1Lb', 'Grano de la canasta básica', 89, 1.42, 1),
('P005', 'Black Label - Johnie Walker', 'Perfecta para celebrar ese momento especial',30, 23.80, 15),
('P006', 'Lechuga Unidad', 'Fresca lechuga de nuestros campos', 41, 0.90, 0.40),
('P007', 'Manzanas Libra', 'Manzana importada', 203, 2.89, 2),
('P008', 'Blue Label - Johnie Walker', 'Perfecta para celebrar ese momento especial', 3, 350, 250),
('P009', 'Queso Fresco Petacones', 'Queso para acompañar con tortillas', 20, 5.90, 4.89),
('P010', 'Leche Entera', 'Leche salud recién llegada', 30, 1.90, 1.60),
('P011', 'Docena de huevos', 'Desde el nido a tu mesa', 32, 2.25, 1.50),
('P012', 'Lomo rollizo lb', 'Rico lomo para ese asado', 300, 6.50, 4.25),
('P013', 'Chorizo Argentino (6 unidades)', 'Rico chorizo para acompañar', 43, 3.65, 2.50),
('P014', 'Gaseosa 7Up 1.5L', 'Sabrosa bebida para degustar', 43, 1.25, 0.70),
('P015', 'Gaseosa Coca Cola + Bebida Del Valle 2.5L', 'Para pelo', 20, 3.45, 2.50),
('P016', 'Hielo polar escarrsa bolsa de 5 Lb', 'Para helar tus bebidas' , 30, 1.36, 0.50),
('P017', 'Aceite orisol 700mL', 'Para que tus comidas sepan más sabrosas', 53, 2.40, 1.75)
GO

UPDATE [dbo].[Producto] SET existencias = 0 WHERE idprod = 'P002';

SELECT @@SERVERNAME AS 'Nombre del Servidor:'
GO

-- UPDATE [dbo].[Producto] SET descripcion = 'Cabello más limpio y saludable con Dove', existencias = 14, precio = 20.50, preciov = 22.90 WHERE idprod = 'P001'
-- DELETE FROM [dbo].[Producto] WHERE idprod = 1

SELECT idprod AS ID, nombre AS Nombre,descripcion AS Descripcción, existencias AS Existentes, CONCAT('$ ', precio) AS Precio, CONCAT('$ ',preciov) AS 'Precio de Venta', ganancia AS 'Ganancias:' FROM [dbo].[Producto]
GO

SELECT idprod AS ID, descripcion AS Descripcción, existencias AS Existentes, precio AS Precio, preciov AS 'Precio de Venta', ganancia AS 'Ganancias:'
	FROM [dbo].[Producto]
GO

SELECT idpedido AS ID, nombre, cantidad
FROM [dbo].[Pedido]
INNER JOIN [dbo].[Producto] ON [dbo].[Pedido].idprod = [dbo].[Producto].idprod
GO

SELECT idpedido AS ID, nombre, cantidad
FROM [dbo].[Pedido]
INNER JOIN [dbo].[Producto] ON [dbo].[Pedido].idprod = [dbo].[Producto].idprod
WHERE cantidad <> 0
GO

SELECT idprod AS ID, nombre AS Nombre, descripcion AS Descripcción, existencias AS Existentes, precio AS Precio, preciov AS 'Precio de Venta', ganancia AS 'Ganancias:' FROM[dbo].[Producto] WHERE existencias <> 0