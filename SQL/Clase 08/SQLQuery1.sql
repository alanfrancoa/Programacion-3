CREATE TABLE Animales(
ID INT PRIMARY KEY, 
NOMBRE VARCHAR(50)
); --creo tabla

SELECT * FROM Animales;

ALTER TABLE Animales 
ADD ESPECIE varchar (20) not null DEFAULT 'Perro';
-- Agrega a la tabla animales el campo especie, en los registros previos, donde el valor sea nulo, su default es perro.

INSERT INTO ANIMALES VALUES 
(1, 'Kitty', 'Gato'),
(2, 'Cinammoroll', 'Perro'),
(3, 'Pompompurin', 'Perro'),
(4, 'MyMelody', 'Conejo'),
(5, 'Kuromi', 'Conejo'),
(6, 'Pochacco', 'Perro'),
(7, 'Keroppi', 'Rana'),
(8, 'Chococat', 'Gato'),
(9, 'Badz Maru', 'Pajaro'),
(10, 'Tuxedosam', 'Pajaro');

ALTER TABLE Animales
add EDAD INT not null DEFAULT 0;
--agregamos el campo edad a nuestra tabla, no puede ser nulo, los registros anteriores toman 0 como valor default. 

insert into Animales values
(11, 'Pirulina','Marmota', 200),
(12, 'Trotksy', 'Gato', 10),
(13, 'Shamu', 'Ballena', 35),
(14, 'Keiko', 'Ballena', 40);
--agregamos mas animales, tienen que tener ID, nombre, especie y edad.

--CONSULTAS
SELECT ESPECIE, max (EDAD) as [Mas viejito], min (ID) as [Minimo ID]
from Animales
group by ESPECIE
--Muestra clasificado por especie, el animal mas viejo y el que tenga el ID mas bajo.

SELECT ESPECIE, COUNT(*) AS [CANTIDAD]
FROM ANIMALES
GROUP BY ESPECIE
ORDER BY CANTIDAD DESC

--Muestra los campos especie, cuenta la cantidad.
--Los agrupupa por especie, ordenandolos de manera descendiente.


SELECT especie, COUNT(*) AS cantidad, AVG(edad) AS promedio_edad, MAX(edad) AS maxima_edad
FROM animales
GROUP BY especie
ORDER BY cantidad DESC;
--clasifica por especie, cuenta cuantos animales de cada especie, promedio de edad, y el animal mas grande.

select top 3 * from animales where especie = 'gato'
order by edad desc;
--muestra los 3 gatos mas grandes de edad, los ordena de manera descendiente.

select top 3 nombre
from animales 
where especie in ('gato', 'perro')
order by edad desc
--Muestra los tres animales mas grandes,que sean gato o perro.

select top 3 nombre
from animales 
where especie not in ('gato', 'perro')
order by edad desc
--Muestra los 3 animales mas viejos, que no sean perro o gato, ordena de manera desc.