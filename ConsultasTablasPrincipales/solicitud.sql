use museo;

SELECT solicitud.id_solicitud AS Solicitud, item.nombre as Item, sala.nombre as Origen, sala.nombre as Destino, solicitud.estado AS Estado, itemSolicitado.fecha_solicitud AS Fecha, solicitud.comentario as Comentario

FROM solicitud, sala,item, itemSolicitado

WHERE solicitud.id_item = item.id_item AND
	  solicitud.id_sala_origen = sala.id_sala AND
      solicitud.id_sala_destino = sala.id_sala AND
      itemSolicitado.id_solicitud = solicitud.id_solicitud
      
 
 