/*Consulta que muestra todos los objetos*/
SELECT *
FROM item AS t1

/*Consulta de departamentos*/

SELECT t2.* , t3.nombre AS nombreSala, t1.nombre as nombreItem
FROM item as t1, departamento as t2, sala as t3
WHERE t2.nombre = 'departamento de documentos' AND t2.id_dpto=t1.id_dpto AND t3.id_dpto=t2.id_dpto

/*Consulta de busqueda por coleccion*/

SELECT SELECT t2.nombre AS nombreDpto ,t3.nombre as nombreSala,t1.*
FROM item as t1, departamento as t2, sala as t3
WHERE t1.coleccion = 'documentos historicos' AND t2.id_dpto=t1.id_dpto AND t3.id_dpto=t2.id_dpto

/*Consulta de busqueda por autor*/

SELECT t3.autor
FROM item as t1,departamento as t2,obra as t3
WHERE t3.id_item = t1.id_item and t3.autor='Raymond Monvoisin' and t1.id_dpto = t2.id_dpto

/*Consulta en marca*/

SELECT t2.nombre AS nombreDpto ,t3.nombre as nombreSala,t1.*
FROM item as t1, departamento as t2, vehiculo as t4 ,sala as t3
WHERE t4.marca = 'ford' AND t2.id_dpto=t1.id_dpto  AND t4.id_item=t1.id_item and t1.id_sala=t3.id_sala

/*Consulta por año*/

SELECT t2.nombre AS nombreDpto ,t3.nombre as nombreSala,t1.*
FROM item as t1, departamento as t2, sala as t3
WHERE t1.anno = 1997 AND t2.id_dpto=t1.id_dpto AND t3.id_dpto=t2.id_dpto 