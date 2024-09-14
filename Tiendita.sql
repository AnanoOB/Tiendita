CREATE DATABASE Tienda;
USE Tienda;

CREATE TABLE Productos(
IdProductos INT PRIMARY KEY AUTO_INCREMENT,
Nombre VARCHAR (100),
Descripcion VARCHAR (200),
Precio DOUBLE
);

INSERT INTO Productos(IdProductos, Nombre, Descripcion, Precio)
VALUES (1,'Gansito', 'Gansito Congelado', 20.00);

