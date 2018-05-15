/*Consulta que muestra todos los objetos*/
SELECT *
FROM item AS t1

/*Consulta de departamentos*/

SELECT *
FROM item as t1, departamento as t2, sala as t3
WHERE t2.nombre = 'x' AND t2.id_dpto=t1.id_dpto AND t3.id_dpto=t2.id_dpto

/*Consulta de busqueda por marca*/

SELECT *
FROM item as t1, departamento as t2, sala as t3
WHERE t3.coleccion = 'x' AND t2.id_dpto=t1.id_dpto AND t3.id_dpto=t2.id_dpto

/*Consulta de busqueda por autor*/

SELECT *
FROM item as t1, departamento as t2, sala as t3, documento as t4, obra as t5
WHERE t4.autor = 'x' AND t2.id_dpto=t1.id_dpto AND t3.id_dpto=t2.id_dpto AND t5.autor ='x' AND t5.id_item=t1.id_item AND t4.id_item=t3_item

/*Consulta en marca*/

SELECT *
FROM item as t1, departamento as t2, sala as t3, vehiculo as t4
WHERE t4.marca = 'x' AND t2.id_dpto=t1.id_dpto AND t3.id_dpto=t2.id_dpto AND t5.id_item=t1.id_item AND t4.id_item=t3_item

/*Consulta por año*/

SELECT *
FROM item as t1, departamento as t2, sala as t3
WHERE t1.anno = 1997 AND t2.id_dpto=t1.id_dpto AND t3.id_dpto=t2.id_dpto 