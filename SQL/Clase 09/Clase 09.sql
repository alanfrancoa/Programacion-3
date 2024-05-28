CREATE TABLE USUARIOS
(
	ID INT IDENTITY(1,1),
	NOMBRE VARCHAR(25), 
	CLAVE VARCHAR(25)
); --Creamos tabla, ID con identidad (hace que sea autoincremental)

INSERT INTO USUARIOS (NOMBRE, CLAVE) VALUES ('Juan Pérez', 'password123');
-- Ingresamos un valor a la tabla. 

select * from USUARIOS

DELETE from USUARIOS WHERE ID=1
-- Eliminamos el registro, ya que lo ingresamos mal.


INSERT INTO USUARIOS (NOMBRE, CLAVE) VALUES ('pedropascal123', 'password123');

INSERT INTO USUARIOS (NOMBRE, CLAVE) VALUES
('test123', 'adminadmin'),
('pedropedrope', '1234');