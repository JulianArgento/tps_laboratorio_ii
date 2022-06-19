CREATE DATABASE TP4_DB;
GO
USE TP4_DB;
GO
CREATE TABLE Tabla_Compras
(
	ID_COMPRA INT IDENTITY(1,1) PRIMARY KEY,
	NOMBRE_CLIENTE NCHAR(30) NOT NULL,
	PRECIO_COMPRA INT NOT NULL,
	PRODUCTOS_COMPRADOS NCHAR(60) NOT NULL,
	CANTIDAD_COMPRADA INT NOT NULL,
	
);
GO
INSERT INTO Tabla_Compras(NOMBRE_CLIENTE, PRECIO_COMPRA, PRODUCTOS_COMPRADOS, CANTIDAD_COMPRADA) VALUES
	('Horacio', 1800, 'Pochoclos Mediano Dulces|Gaseosa Chico CocaCola', 2),
	('Carolina', 2000, 'Pochoclos Mediano Dulces', 2),
	('Fran', 1200, 'Gaseosa Chico CocaCola', 2),
	('Fran', 1200, 'Gaseosa Grande CocaCola', 2),
	('Julian', 2400, 'Pochoclos Grande Dulces|Gaseosa Grande CocaCola', 2)
	;