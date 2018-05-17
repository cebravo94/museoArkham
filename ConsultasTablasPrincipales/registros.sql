use museo;

SELECT registro.id_registro AS Registro, item.nombre AS Item,departamento.nombre as Departamento, usuario.nombre AS Administrador, usuario.nombre AS Gerente, sala.nombre AS Origen, sala.nombre AS Destino, registro.fecha_ingreso AS Fecha
 
 FROM registro, item, usuario, departamento, sala
 
 WHERE item.id_item = registro.id_item AND
		registro.id_admin = usuario.id_usuario AND
        registro.id_gerente = usuario.id_usuario AND
        registro.id_sala_origen = sala.id_sala  AND
        registro.id_sala_destino = sala.id_sala  