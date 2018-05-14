use museo;

SELECT sala.nombre as Ubicacion, item.nombre as Item,  obra.autor as Autor , obra.tipo AS Tipo, obra.estilo AS Estilo, obra.material AS Material, item.estado AS Estado , item.anno AS Año

FROM sala,item,obra

WHERE obra.id_item = item.id_item AND
	  item.id_sala = sala.id_sala 