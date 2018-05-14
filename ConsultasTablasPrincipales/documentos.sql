use museo;

SELECT sala.nombre as Ubicacion, item.nombre as Item,  documento.autor as Autor , documento.tipo AS Tipo, item.estado AS Estado , item.anno AS Año

FROM sala,item,documento

WHERE documento.id_item = item.id_item AND
	  item.id_sala = sala.id_sala 