use museo;

/*Llenado de usuario*/

INSERT INTO usuario (contrasenna,nombre,rut,correo,fecha_ingreso,tipo) VALUES 
(0000,'default','0000000-0','default',"0000-000-00",'default'), 
(1234,'Juana Maria','11648123-5','juanamaria@gmail.com',"1997-03-03",'Secretaria'), 
(1234,'Juan Letelier','23658123-3','juanletelier@gmail.com',"1997-03-03",'Bodega'), 
(1234,'Miguel Gonzalez','18563987-8','miguelgonzalez@gmail.com',"1997-03-03",'Director'), 
(1234,'Rodrigo Cordero','19696146-1','rodrigocordero@gmail.com',"1997-03-03",'Gerente'), 
(1234,'Jesus Moris','17696147-3','jesusmoris@gmail.com',"1997-03-03",'Administrador'), 
(1234,'Bastian Sepulveda','19563387-8','bastiansepulveda@gmail.com',"1997-03-03",'Administrador'), 
(1234,'Fabian Oyarce','19473859-5', 'foyarce15@alumnos.utalca.cl',"1997-03-03",'Administrador'), 
(1234,'Renato Oyarce', '14236401-8','renato_cobre@hotmail.com',"1973-10-07",'Administrador'), 
(1234,'Angelica Valenzuela', '14236387-9','mi_valenzu@hotmail.com',"1997-08-27",'Administrador'), 
(1234,'Fernanda Lopez', '19008841-3','flopez15@alumnos.utalca.cl',"1995-10-18", 'Administrador'), 
(1234,'Felipe Gonzales', '9547317-2','fgonzales@hotmail.com',"1993-12-30",'Administrador'), 
(1234,'Sabina Correa', '17568760-2','scorrea@hotmail.com', "1985-11-02",'Administrador'), 
(1234,'Sergio Muñoz','17653148-7','sergiomuñoz@gmail.com',"1992-01-04",'Administrador'),
(1234, 'Rodrigo Letelier' , '19696148-8' , 'rodrigoletelier@gmail.com' , '1992-05-15' , 'Bodega');

/*Llenado de departamentos*/


INSERT INTO departamento (id_usuario,nombre,descripcion,estado) VALUES 
(1,'default','default','Activo'),
(3,'Bodega','Donde se almacenan los items que no estan en exhibición','Activo'),
(6,'Departamento de documentos','Departamento que exhibe todo tipo de documentos historicos','Activo'),
(7,'Departamento de obras','Departamento que exhibe importantes obras chilenas','Activo'),
(8,'Departamento de vehiculos','Departamento que exhibe todo tipo de vehiculos a lo largo de la historia','Activo'),
(9,'Departamento de piezas','Departamento que exhibe importantes piezas chilenas','Activo');

/*Llenado de salas*/

INSERT INTO sala(id_dpto,nombre,descripcion,area,estado) VALUES 
(2,'Bodega','Sala donde se almacenan todos los ítems que no están en exhibición',1000,'En uso'),
(3,'Sala de cartas 1','Sala con todo tipos de cartas escritas a la largo de la historia por personajes emblematios',5,'En uso'),
(3,'Sala de cartas 2','Sala con todo tipos de cartas escritas a la largo de la historia por personajes emblematios',5,'En uso'),
(4,'Sala de obras 1','Sala con todo tipo de obras chilenas',5,'En uso'),
(4,'Sala de obras 2','Sala con todo tipo de obras chilenas',5,'En uso'),
(5,'Sala de autos 1','Sala con todo tipos de autos',5,'En uso'),
(5,'Sala de autos 2','Sala con todo tipos de autos',5,'En uso'),
(5,'Sala de motos 1','Sala con todo tipos de motos',5,'En uso'),
(5,'Sala de motos 2','Sala con todo tipos de motos',5,'En uso'),
(6,'Sala de piezas 1','Sala con todo tipo de piezas chilenas',5,'En uso'),
(6,'Sala de piezas 2','Sala con todo tipo de piezas chilenas',5,'En uso'),
(1,'Sala de maquinarias' , 'Sala con distintas maquinarias historicas',5,'Disponible'),
(1,'Sala de documentos 1' , 'Sala con documentos',5,'Disponible'),
(1,'Sala de documentos 2' , 'Sala con distintas maquinarias historicas',5,'Disponible'),
(1,'Sala de pinturas 1' , 'Sala con distintas pinturas',5,'Disponible'),
(1,'Sala de esculturas' , 'Sala con distintas esculturas',5,'Disponible');

/*llenado de items*/

/*insert de documentos */
INSERT INTO item (id_dpto,id_sala,fecha_ingreso,descripcion,coleccion,estado,anno,tipo,nombre,era) VALUES (3,3,'2017-05-25','Cartas de las hermanas Frank a amigas en Estados Unidos','Documentos historicos','En Exhibicion',1942,'Documento','Cartas de Ana Frank','D.C');
INSERT INTO documento (id_item,tipo,autor) VALUES (1,'Documento historico','Ana Frank');

INSERT INTO item (id_dpto,id_sala,fecha_ingreso,descripcion,coleccion,estado,anno,tipo,nombre,era) VALUES (3,3,'2017-05-25','Tratado de paz y amistad entre Chile y Peru(copia)','Documentos historicos','En Exhibicion',1884,'Documento','Tratado de paz Chile Peru','D.C');
INSERT INTO documento (id_item,tipo,autor) VALUES (2,'Documento historico','Anonimo');

INSERT INTO item (id_dpto,id_sala,fecha_ingreso,descripcion,coleccion,estado,anno,tipo,nombre,era) VALUES (3,3,'2017-06-30','Documento que contiene el acta de matrimonio de Adolf Hitler y Eva Broun','Documentos historicos','En Exhibicion',1945,'Documento','Acta de matrimonio de Hitler','D.C');
INSERT INTO documento (id_item,tipo,autor) VALUES (3,'Documento','Anonimo');

INSERT INTO item (id_dpto,id_sala,fecha_ingreso,descripcion,coleccion,estado,anno,tipo,nombre,era) VALUES (3,3,'2017-06-30','Instrumento de Rendición de
Todas las fuerzas alemanas en Holanda, en el noroeste de Alemania incluyendo todas las islas, y en Dinamarca ','Documentos historicos','En Exhibicion',1945,'Documento','Acta de rendicion alemana','D.C');
INSERT INTO documento (id_item,tipo,autor) VALUES (4,'Documento','Anonimo');

INSERT INTO item (id_dpto,id_sala,fecha_ingreso,descripcion,coleccion,estado,anno,tipo,nombre,era) VALUES (3,3,'2017-06-30','Instrumento de rendición de
todas las fuerzas japonesas ','Documentos historicos','En Exhibicion',1945,'Documento','Acta de rendicion japonesa','D.C');
INSERT INTO documento (id_item,tipo,autor) VALUES (5,'Documento','Anonimo');

INSERT INTO item (id_dpto,id_sala,fecha_ingreso,descripcion,coleccion,estado,anno,tipo,nombre,era) VALUES (3,3,'2016-05-04','Acuerdo de Asistencia Mutua entre el Reino Unido y Polonia.','Documentos historicos','En Exhibicion',1939,'Documento','Acuerdo Anglo-Polaco de Ayuda Mutua','D.C');
INSERT INTO documento (id_item,tipo,autor) VALUES (6,'Documento','Anonimo');

INSERT INTO item (id_dpto,id_sala,fecha_ingreso,descripcion,coleccion,estado,anno,tipo,nombre,era) VALUES (3,3,'2015-06-13','Intercambio de notas diplomáticas entre el Secretario de Estado de Estados Unidos, Cordell Hull, y al Embajador Británico Marqués de Lothian, acordando el intercambio de destructores obsoletos por bases militares en las posesiones británicas.','Documentos historicos','En Exhibicion',1940,'Documento','Acuerdo de Bases por Destructores','D.C');
INSERT INTO documento (id_item,tipo,autor) VALUES (7,'Documento','Anonimo');

/*insert de vehiculo*/
INSERT INTO item (id_dpto,id_sala,fecha_ingreso,descripcion,coleccion,estado,anno,tipo,nombre,era) VALUES (5,6,'2016-05-04','Era un pequeño vehículo sobre orugas y guiado por cable, utilizado por el Ejército alemán durante la Segunda Guerra Mundial. Entre las fuerzas Aliadas, era llamado tanque escarabajo','Vehiculos de guerra','En Exhibicion',1939,'Vehiculo','Goliath','D.C');
INSERT INTO vehiculo (id_item,marca,modelo) VALUES (8,'Borgward','N/A');

INSERT INTO item (id_dpto,id_sala,fecha_ingreso,descripcion,coleccion,estado,anno,tipo,nombre,era) VALUES (5,6,'2017-04-23','El Ectomobile o Ecto 1 es un Cadillac Miller “Lymo Style, Ambulance Conversión”. El diseño original del vehículo fue de Steven Dane; la conversión del vehículo tuvo un costo de $4,800 dólares.','Vehiculos famosos','En Exhibicion',1959,'Vehiculo','Ecto 1','D.C');
INSERT INTO vehiculo (id_item,marca,modelo) VALUES (9,'Cadillac','Miller Meteor');

INSERT INTO item (id_dpto,id_sala,fecha_ingreso,descripcion,coleccion,estado,anno,tipo,nombre,era) VALUES (5,6,'2015-07-23','El DeLorean original es un modelo creado por el constructor John DeLorean, con carrocería de acero inoxidable, el primer prototipo del auto se presentó en octubre de 1976','Vehiculos famosos','En Exhibicion',1981,'Vehiculo','Time Machine','D.C');
INSERT INTO vehiculo (id_item,marca,modelo) VALUES (10,'DeLorean','DMC12');

INSERT INTO item (id_dpto,id_sala,fecha_ingreso,descripcion,coleccion,estado,anno,tipo,nombre,era) VALUES (5,7,'2015-07-23','Dentro de la historia, Herbie es un vochito de carreras con mente propia, cuenta con el número 53 y tiene placas vintage de California con las letras y dígitos: QFP 857.','Vehiculos famosos','En Exhibicion',1963,'Vehiculo','Herbie','D.C');
INSERT INTO vehiculo (id_item,marca,modelo) VALUES (11,'VW','Deluxe');

INSERT INTO item (id_dpto,id_sala,fecha_ingreso,descripcion,coleccion,estado,anno,tipo,nombre,era) VALUES (5,7,'2015-07-23','Filme protagonizado por el legendario Steve Mc Queen, quien encarnó al policía Frank Bullitt. El filme fue estrenado el 17 de octubre de 1968. En el 2008 Ford Motor Company produjo un nuevo modelo para celebrar el 40 aniversario de la película.','Vehiculos famosos','En Exhibicion',1968,'Vehiculo','Mustang Bullit','D.C');
INSERT INTO vehiculo (id_item,marca,modelo) VALUES (12,'Ford','Mustang GT');

INSERT INTO item (id_dpto,id_sala,fecha_ingreso,descripcion,coleccion,estado,anno,tipo,nombre,era) VALUES (5,7,'2015-07-23','El coche más memorable de la película, el Pursuit Special negro de Max, era una versión GT351 limitada del Ford XB Falcon Hardtop de 1973, modificado por el director artístico de la película, Jon Dowding.','Vehiculos famosos','En Exhibicion',1973,'Vehiculo','Pursuit Special','D.C');
INSERT INTO vehiculo (id_item,marca,modelo) VALUES (13,'Ford','Falcon Interceptor');

/*insert de piezas*/

INSERT INTO item (id_dpto,id_sala,fecha_ingreso,descripcion,coleccion,estado,anno,tipo,nombre,era) VALUES (6,10,'2016-07-13','Hacha del Faraón Ahmose, Egipto, 1539-1514 a.C.','Piezas historicas','En Exhibicion',1539,'Pieza','Hacha del Faraón Ahmose','a.C.');
INSERT INTO pieza (id_item,periodo,tipo) VALUES (14,'Antiguo egipto','Pieza egipcia');

INSERT INTO item (id_dpto,id_sala,fecha_ingreso,descripcion,coleccion,estado,anno,tipo,nombre,era) VALUES (6,10,'2016-07-13','Dedo artificial proveniente del Antiguo Egipto, probablemente la primera prótesis médica.','Piezas historicas','En Exhibicion',1540,'Pieza','Dedo artificial egipcio','a.C.');
INSERT INTO pieza (id_item,periodo,tipo) VALUES (15,'Antiguo egipto','Pieza egipcia');

INSERT INTO item (id_dpto,id_sala,fecha_ingreso,descripcion,coleccion,estado,anno,tipo,nombre,era) VALUES (6,11,'2016-07-13','Casco corintio de la Batalla de Maraton (490 a.C.), hallado en 1834 con la calavera en su interior.','Piezas historicas','En Exhibicion',1834,'Pieza','Casco corintio','a.C.');
INSERT INTO pieza (id_item,periodo,tipo) VALUES (16,'490 a.C.','Pieza romana');

INSERT INTO item (id_dpto,id_sala,fecha_ingreso,descripcion,coleccion,estado,anno,tipo,nombre,era) VALUES (6,11,'2016-07-13','Corona del Emperador Bizantino Constantino Monomachos, 1042 d.C.','Piezas historicas','En Exhibicion',1042,'Pieza','Corona del Emperador Bizantino ','d.C.');
INSERT INTO pieza (id_item,periodo,tipo) VALUES (17,'1042 d.C.','Pieza');

/*insert de obras*/

INSERT INTO item (id_dpto,id_sala,fecha_ingreso,descripcion,coleccion,estado,anno,tipo,nombre,era) VALUES (4,4,'2016-07-13','Patrocinio de San José
, 1744.','Obras chilenas','En Exhibicion',1744,'Obra','Patrocinio de San José','d.C.');
INSERT INTO obra (id_item,material,estilo,tipo,autor) VALUES (18,'Oleo sobre tela','Oleo sobre tela','Pintura','Gaspar Miguel de Berrio');

INSERT INTO item (id_dpto,id_sala,fecha_ingreso,descripcion,coleccion,estado,anno,tipo,nombre,era) VALUES (4,4,'2016-07-13','Bernardo O’Higgins, Director Supremo
, 1821','Obras chilenas','En Exhibicion',1821,'Obra','Bernardo O’Higgins','d.C.');
INSERT INTO obra (id_item,material,estilo,tipo,autor) VALUES (19,'Oleo sobre tela','Oleo sobre tela','Pintura','José Gil de Castro y Morales');

INSERT INTO item (id_dpto,id_sala,fecha_ingreso,descripcion,coleccion,estado,anno,tipo,nombre,era) VALUES (4,5,'2016-07-13',' El Huaso y la lavandera
, 1835','Obras chilenas','En Exhibicion',1835,'Obra','El huaso y la lavandera','d.C.');
INSERT INTO obra (id_item,material,estilo,tipo,autor) VALUES (20,'Oleo sobre tela','Oleo sobre tela','Pintura','Johann Moritz Rugendas');

INSERT INTO item (id_dpto,id_sala,fecha_ingreso,descripcion,coleccion,estado,anno,tipo,nombre,era) VALUES (4,5,'2016-07-13',' Retrato de Julia Codesido de Mora','Obras chilenas','En Exhibicion',1846,'Obra','Retrato de Julia Codesido de Mora','d.C.');
INSERT INTO obra (id_item,material,estilo,tipo,autor) VALUES (21,'Oleo sobre tela','Oleo sobre tela','Pintura','Raymond Monvoisin');

/*insert en bodega*/

INSERT INTO item (id_dpto,id_sala,fecha_ingreso,descripcion,coleccion,estado,anno,tipo,nombre,era) VALUES (2,2,'2017-05-25','Archivos del soldado estadounidense de infanteria Peter While','Documentos historicos','Bodega',1945,'Documento','Archivos de white','D.C');
INSERT INTO documento (id_item,tipo,autor) VALUES (22,'Documento historico','Peter white');

INSERT INTO item (id_dpto,id_sala,fecha_ingreso,descripcion,coleccion,estado,anno,tipo,nombre,era) VALUES (2,2,'2017-05-25','Carta del futuro presidente de EEUU y comandante superomo de los aliados del frente occidental durante la segunda guerra mundial','Documentos historicos','Bodega',1945,'Documento','Carta presidente','D.C');
INSERT INTO documento (id_item,tipo,autor) VALUES (23,'Documento historico','Dwight Eisenhower');

INSERT INTO item (id_dpto,id_sala,fecha_ingreso,descripcion,coleccion,estado,anno,tipo,nombre,era) VALUES (2,2,'2016-07-13',' Con una de las miradas mes surrealistas este artista retomo uno de los capitulos mas importantes de el viaje al centro de la tierra','Obras desconicidas','Bodega',1939,'Obra','El despertar del bosque','d.C.');
INSERT INTO obra (id_item,material,estilo,tipo,autor) VALUES (24,'Oleo sobre tela','Oleo sobre tela','Pintura','Paul Delvaux');

INSERT INTO item (id_dpto,id_sala,fecha_ingreso,descripcion,coleccion,estado,anno,tipo,nombre,era) VALUES (2,2,'2016-07-13',' Cosiendo una vela','Obras','Bodega',1896,'Obra','Cosiendo una vela','d.C.');
INSERT INTO obra (id_item,material,estilo,tipo,autor) VALUES (25,'Oleo sobre tela','Oleo sobre tela','Pintura','Joaquin Sorolla');

INSERT INTO item (id_dpto,id_sala,fecha_ingreso,descripcion,coleccion,estado,anno,tipo,nombre,era) VALUES (2,2,'2015-07-23','Se cree que pertenecía a la Real Fuerza Aérea Canadiense y su misión fue patrullar la Costa Este de EE.UU.','Vehiculos de guerra','Bodega',1973,'Vehiculo','Hawker Hurricane','D.C');
INSERT INTO vehiculo (id_item,marca,modelo) VALUES (26,'N','Hawker Hurricane');

INSERT INTO item (id_dpto,id_sala,fecha_ingreso,descripcion,coleccion,estado,anno,tipo,nombre,era) VALUES (2,2,'2016-07-13','Casco de un soldado anónimo que participó en la batalla de Normandía en 1944','Piezas historicas','Bodega',1945,'Pieza','Casco de soldado anonimo','D.C');
INSERT INTO pieza (id_item,periodo,tipo) VALUES (27,'Segunda guerra mundial','Pieza de guerra');

INSERT INTO item (id_dpto,id_sala,fecha_ingreso,descripcion,coleccion,estado,anno,tipo,nombre,era) VALUES (2,2,'2016-07-13','La colección incluía la Cruz Victoria, la condecoración militar más alta al valor frente al enemigo.','Piezas historicas','Bodega',1945,'Pieza','Condecoraciones de Edward Ted','D.C.');
INSERT INTO pieza (id_item,periodo,tipo) VALUES (28,'Segunda guerra mundial','Pieza');

INSERT INTO item (id_dpto,id_sala,fecha_ingreso,descripcion,coleccion,estado,anno,tipo,nombre,era) VALUES (2,2,'2016-07-13','Orillas del sena en argenteuil','Obras','Bodega',1878,'Obra','Orillas del sena en Argenteuil','D.C.');
INSERT INTO obra (id_item,material,estilo,tipo,autor) VALUES (29,'Oleo sobre tela','Oleo sobre tela','Pintura','Claude Monet');

INSERT INTO item (id_dpto,id_sala,fecha_ingreso,descripcion,coleccion,estado,anno,tipo,nombre,era) VALUES (2,2,'2016-07-13','Nadie como Otto para darle nuevas dimensionalidades al cuerpo humano y esta obra es el ejemplo perfecto; con posiciones y gestos que buscaban la complejidad de las personas más allá de sus apariciones físicas','Obras desconocidas','Bodega',1925,'Obra','Tres prostituas en la calle','d.C.');
INSERT INTO obra (id_item,material,estilo,tipo,autor) VALUES (30,'Oleo sobre tela','Oleo sobre tela','Pintura','Otto Dix');

INSERT INTO item (id_dpto,id_sala,fecha_ingreso,descripcion,coleccion,estado,anno,tipo,nombre,era) VALUES (2,2,'2016-07-13',' El viaducto de Starruca','Obras','Bodega',1846,'Obra','El viaducto de Starruca','D.C.');
INSERT INTO obra (id_item,material,estilo,tipo,autor) VALUES (31,'Oleo sobre tela','Oleo sobre tela','Pintura','Jasper Francis');