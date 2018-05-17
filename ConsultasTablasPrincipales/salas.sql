use museo;

SELECT sala.id_sala AS ID,departamento.nombre AS Departamento, sala.nombre AS Nombre, sala.estado AS Estado, sala.descripcion as Descripcion

FROM departamento ,sala

WHERE  departamento.id_dpto = sala.id_dpto
 