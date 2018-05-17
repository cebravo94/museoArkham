--Actualizar ubicacion del item (Sirve para los movimientos entre departamento de los items).
--Es necesaria una query anterior que capture el id del item (un Select).
UPDATE item SET item.id_dpto = 'nuevo id_dpto', item.id_sala = 'nuevo id_sala' WHERE item.id_item = 'valor';

--Actualizar estado de item (Sirve para actualizar el estado del item).
--Es necesaria una query anterior que capture el id del item (un Select).
UPDATE item SET item.estado = 'estado' WHERE item.id_item = 'valor';

--Actualiza el estado del usuario.
--Es necesaria una query anterior que capture el id del usuario (un Select).
UPDATE usuario SET usuario.estado = 'nuevo estado' WHERE usuario.id_usuario = 'valor';

--Actualiza el estado del departamento
--Es necesaria una query anterior que capture el id del departamento (un Select).
UPDATE departamento SET departamento.estado = 'nuevo estado' WHERE departamento.id_dpto = 'valor';

--Actualiza el estado de la sala
--Es necesaria una query anterior que capture el id de la sala (un Select).
UPDATE sala SET sala.estado = 'nuevo estado' WHERE sala.id_sala = 'valor';

--Actualiza el departamento de pertenencia de una sala.
--Es necesaria una query anterior que capture el id de la sala y el del departamento (un Select).
UPDATE sala SET sala.id_departamento = 'nuevo estado' WHERE sala.id_sala = 'valor';

--Actualiza el administrador de un departamento.
--Es necesaria una query anterior que capture el id del departamento y de el usuario a reemplazar (un Select).
UPDATE departamento SET departamento.id_usuario = 'nuevo estado' WHERE departamento.id_dpto = 'valor';

--Actualiza el departamento y la sala de pertenencia de un item.
--Es necesaria una query anterior que capture el id del item, asi como el departamento y la sala a la que se va a dirigir(un Select).
UPDATE item SET item.id_dpto = 'nuevo estado', item.id_sala = 'nuevo estado' WHERE item.id_item = 'valor';

--Actualiza el estado de la solicitud
--Es necesaria una query anterior que capture el id de la solicitud (un Select).
UPDATE solicitud SET solicitud.estado = 'nuevo estado' WHERE solicitud.id_solicitud = 'valor';

--Actualiza el estado de la solicitud
--Es necesaria una query anterior que capture el id de la solicitud (un Select).
UPDATE solicitud SET solicitud.estado = 'nuevo estado' WHERE solicitud.id_solicitud = 'valor';

--Crear un item generico -> Item 
INSERT INTO item (id_depto, id_sala, nombre, fecha_ingreso, descripcion, coleccion, estado, anno, era,tipo) VALUES ('valor_id_depto', 
	'valor_id_sala', 'valor_nombre', 'valor_fecha_ingreso', 'valor_descripcion', 'valor_coleccion', 'valor_estado', 'valor_anno', 'valor_era','tipo');

--Crear un item de tipo documento -> LAST_INSERT_ID supuestamente detecta la ultima ronda de AUTO_INCREMENT que se ha insertado. Al ser un proceso que ocurre inmediatamente 
--despues de insertar la parte principal del item, el id obtenido corresponderia con el id del item.
INSERT INTO documento(id_item, tipo, autor) VALUES (SELECT LAST_INSERT_ID(), 'valor_tipo', 'valor_autor');

--Crear un item de tipo obra -> LAST_INSERT_ID supuestamente detecta la ultima ronda de AUTO_INCREMENT que se ha insertado. Al ser un proceso que ocurre inmediatamente 
--despues de insertar la parte principal del item, el id obtenido corresponderia con el id del item.
INSERT INTO obra(id_item, material, estilo, tipo, autor) VALUES (SELECT LAST_INSERT_ID(), 'valor_material', 'valor_estilo', 'valor_tipo', 'valor_autor');

--Crear un item de tipo vehiculo -> LAST_INSERT_ID supuestamente detecta la ultima ronda de AUTO_INCREMENT que se ha insertado. Al ser un proceso que ocurre inmediatamente 
--despues de insertar la parte principal del item, el id obtenido corresponderia con el id del item.
INSERT INTO vehiculo(id_item, marca, modelo) VALUES (SELECT LAST_INSERT_ID(), 'valor_marca', 'valor_modelo');

--Crear un item de tipo pieza -> LAST_INSERT_ID supuestamente detecta la ultima ronda de AUTO_INCREMENT que se ha insertado. Al ser un proceso que ocurre inmediatamente 
--despues de insertar la parte principal del item, el id obtenido corresponderia con el id del item.
INSERT INTO pieza(id_item, periodo, tipo) VALUES (SELECT LAST_INSERT_ID(), 'valor_periodo', 'valor_tipo');


