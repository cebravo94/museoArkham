use museo;

SELECT pieza.id_item AS ID,sala.nombre as Ubicacion, item.nombre as Item,  pieza.periodo as Periodo, item.era as Era , pieza.tipo AS Tipo, item.estado AS Estado , item.anno AS Año

FROM sala,item,pieza

WHERE pieza.id_item = item.id_item AND
	  item.id_sala = sala.id_sala 