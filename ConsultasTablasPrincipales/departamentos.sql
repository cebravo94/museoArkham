use museo;

SELECT  departamento.id_dpto AS ID,usuario.nombre AS Administrador, departamento.nombre as Departamento

FROM departamento, usuario
 
WHERE departamento.id_usuario=usuario.id_usuario