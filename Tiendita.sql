CREATE DATABASE Tienda;
USE Tienda;

CREATE TABLE Productos(
IdProductos INT PRIMARY KEY,
Nombre VARCHAR (100),
Descripcion VARCHAR (200),
Precio DOUBLE
);

INSERT INTO Productos(IdProductos, Nombre, Descripcion, Precio)
VALUES (1,'Gansito', 'Gansito Congelado', 20.00);

DELIMITER //
DROP PROCEDURE if EXISTS Validar;
CREATE PROCEDURE Validar(
	IN _Nombre VARCHAR(100),
	IN _Descripcion VARCHAR(200),
	IN _Precio DOUBLE)
BEGIN
DECLARE x INT;
SELECT COUNT(*) FROM Productos WHERE Nombre=_Nombre AND Descripcion=_Descripcion AND Precio=_Precio INTO X;
	if X>0 THEN 
		SELECT 'C0rr3Ct0' AS rs, (SELECT Nombre FROM Productos WHERE Nombre=_Nombre AND Descripcion=_Descripcion AND Precio=_Precio) AS Nombre;
	else
		SELECT 'Err0r' AS rs, 0 AS Nombre;
	END if;
END; //

CALL Validar('Gansito', 'Gansito Congelado', 20.00);

