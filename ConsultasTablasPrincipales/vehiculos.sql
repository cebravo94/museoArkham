use museo;

SELECT sala.nombre as Ubicacion,  vehiculo.marca as Marca, vehiculo.modelo as Modelo , item.anno AS Año, item.estado AS Estado

FROM sala,item,vehiculo

WHERE vehiculo.id_item = item.id_item AND
	  item.id_sala = sala.id_sala 