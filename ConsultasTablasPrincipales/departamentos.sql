use museo;

SELECT usuario.nombre AS Administrador, departamento.nombre as Departamento

FROM departamento, usuario
 
WHERE departamento.id_usuario=usuario.id_usuario