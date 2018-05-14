/*insert de documentos */
INSERT INTO item (id_dpto,id_sala,fecha_ingreso,descripcion,coleccion,estado,anno,tipo,nombre,era) VALUES (1,1,'2017-05-25','cartas de las hermanas frank a amigas en estados unidos','documentos historicos','en exhibicion',1942,'documento','cartas de ana frank','D.C');
INSERT INTO documento (id_item,tipo,autor) VALUES (1,'documento historico','Ana frank');

INSERT INTO item (id_dpto,id_sala,fecha_ingreso,descripcion,coleccion,estado,anno,tipo,nombre,era) VALUES (1,1,'2017-05-25','tratado de paz y amistad entre chile y peru(copia)','documentos historicos','en exhibicion',1884,'documento','tratado de paz chile peru','D.C');2
INSERT INTO documento (id_item,tipo,autor) VALUES (2,'documento historico','N');

INSERT INTO item (id_dpto,id_sala,fecha_ingreso,descripcion,coleccion,estado,anno,tipo,nombre,era) VALUES (1,1,'2017-06-30','documento que contiene el acta de matrimonio de adolf hitler y eva broun','documentos historicos',en exhibicion,1945,'documento','acta de matrimonio de hitler','D.C');
INSERT INTO documento (id_item,tipo,autor) VALUES (3,'documento','anonimo');

INSERT INTO item (id_dpto,id_sala,fecha_ingreso,descripcion,coleccion,estado,anno,tipo,nombre,era) VALUES (1,1,'2017-06-30','Instrumento de Rendición de
Todas las fuerzas alemanas en Holanda, en el noroeste de Alemania incluyendo todas las islas, y en Dinamarca ','documentos historicos','en exhibicion',1945,'documento','acta de rendicion alemana','D.C');
INSERT INTO documento (id_item,tipo,autor) VALUES (4,'documento','N');

INSERT INTO item (id_dpto,id_sala,fecha_ingreso,descripcion,coleccion,estado,anno,tipo,nombre,era) VALUES (1,1,'2017-06-30','Instrumento de Rendición de
Todas las fuerzas Japonesas ','documentos historicos','en exhibicion',1945,'documento','acta de rendicion japonesa','D.C');
INSERT INTO documento (id_item,tipo,autor) VALUES (5,'documento','N');

INSERT INTO item (id_dpto,id_sala,fecha_ingreso,descripcion,coleccion,estado,anno,tipo,nombre,era) VALUES (1,1,'2016-05-04','Acuerdo de Asistencia Mutua entre el Reino Unido y Polonia.','documentos historicos','en exhibicion',1939,'documento','Acuerdo Anglo-Polaco de Ayuda Mutua','D.C');
INSERT INTO documento (id_item,tipo,autor) VALUES (6,'documento','N');

INSERT INTO item (id_dpto,id_sala,fecha_ingreso,descripcion,coleccion,estado,anno,tipo,nombre,era) VALUES (1,1,'2015-06-13','Intercambio de notas diplomáticas entre el Secretario de Estado de Estados Unidos, Cordell Hull, y al Embajador Británico Marqués de Lothian, acordando el intercambio de destructores obsoletos por bases militares en las posesiones británicas.','documentos historicos','en exhibicion',1940,'documento','Acuerdo de Bases por Destructores','D.C');
INSERT INTO documento (id_item,tipo,autor) VALUES (7,'documento','N');

/*insert de vehiculo*/
INSERT INTO item (id_dpto,id_sala,fecha_ingreso,descripcion,coleccion,estado,anno,tipo,nombre,era) VALUES (3,2,'2016-05-04','era un pequeño vehículo sobre orugas y guiado por cable, utilizado por el Ejército alemán durante la Segunda Guerra Mundial. Entre las fuerzas Aliadas, era llamado tanque escarabajo','vehiculos de guerra','en exhibicion',1939,'vehiculo','Goliath','D.C');
INSERT INTO vehiculo (id_item,marca,modelo) VALUES (8,'Borgward','N');

INSERT INTO item (id_dpto,id_sala,fecha_ingreso,descripcion,coleccion,estado,anno,tipo,nombre,era) VALUES (3,2,'2017-04-23',' El Ectomobile o Ecto 1 es un Cadillac Miller “Lymo Style, Ambulance Conversión”. El diseño original del vehículo fue de Steven Dane; la conversión del vehículo tuvo un costo de $4,800 dólares. ','vehiculos famosos','en exhibicion',1959,'vehiculo','ecto 1','D.C');
INSERT INTO vehiculo (id_item,marca,modelo) VALUES (9,'Cadillac ','Miller Meteor');

INSERT INTO item (id_dpto,id_sala,fecha_ingreso,descripcion,coleccion,estado,anno,tipo,nombre,era) VALUES (3,2,'2015-07-23','El DeLorean original es un modelo creado por el constructor John DeLorean, con carrocería de acero inoxidable, el primer prototipo del auto se presentó en octubre de 1976','vehiculos famosos','en exhibicion',1981,'vehiculo','Time Machine','D.C');
INSERT INTO vehiculo (id_item,marca,modelo) VALUES (10,'DeLorean','DMC12');

INSERT INTO item (id_dpto,id_sala,fecha_ingreso,descripcion,coleccion,estado,anno,tipo,nombre,era) VALUES (3,2,'2015-07-23','Dentro de la historia, Herbie es un vochito de carreras con mente propia, cuenta con el número 53 y tiene placas vintage de California con las letras y dígitos: QFP 857.','vehiculos famosos','en exhibicion',1963,'vehiculo','Herbie','D.C');
INSERT INTO vehiculo (id_item,marca,modelo) VALUES (11,'VW','Deluxe');

INSERT INTO item (id_dpto,id_sala,fecha_ingreso,descripcion,coleccion,estado,anno,tipo,nombre,era) VALUES (3,2,'2015-07-23','Filme protagonizado por el legendario Steve Mc Queen, quien encarnó al policía Frank Bullitt. El filme fue estrenado el 17 de octubre de 1968. En el 2008 Ford Motor Company produjo un nuevo modelo para celebrar el 40 aniversario de la película.','vehiculos famosos','en exhibicion',1968,'vehiculo','Mustang Bullit','D.C');
INSERT INTO vehiculo (id_item,marca,modelo) VALUES (12,'Ford','Mustang GT');

INSERT INTO item (id_dpto,id_sala,fecha_ingreso,descripcion,coleccion,estado,anno,tipo,nombre,era) VALUES (3,2,'2015-07-23','El coche más memorable de la película, el Pursuit Special negro de Max, era una versión GT351 limitada del Ford XB Falcon Hardtop de 1973, modificado por el director artístico de la película, Jon Dowding.','vehiculos famosos','en exhibicion',1973,'vehiculo','Pursuit Special','D.C');
INSERT INTO vehiculo (id_item,marca,modelo) VALUES (13,'Ford','Falcon Interceptor');

/*insert de piezas*/

INSERT INTO item (id_dpto,id_sala,fecha_ingreso,descripcion,coleccion,estado,anno,tipo,nombre,era) VALUES (4,3,'2016-07-13','Hacha del Faraón Ahmose, Egipto, 1539-1514 a.C.','piezas historicas','en exhibicion',1539,'pieza','Hacha del Faraón Ahmose','A.C');
INSERT INTO pieza (id_item,periodo,tipo) VALUES (14,'antiguo egipto','pieza egipcia');

INSERT INTO item (id_dpto,id_sala,fecha_ingreso,descripcion,coleccion,estado,anno,tipo,nombre,era) VALUES (4,3,'2016-07-13','Dedo artificial proveniente del Antiguo Egipto, probablemente la primera prótesis médica.','piezas historicas','en exhibicion',1540,'pieza','Dedo artificial egipcio','A.C');
INSERT INTO pieza (id_item,periodo,tipo) VALUES (15,'antiguo egipto','pieza egipcia');

INSERT INTO item (id_dpto,id_sala,fecha_ingreso,descripcion,coleccion,estado,anno,tipo,nombre,era) VALUES (4,3,'2016-07-13','Casco corintio de la Batalla de Maraton (490 a.C.), hallado en 1834 con la calavera en su interior.','piezas historicas','en exhibicion',1834,'pieza','casco corintio','A.C');
INSERT INTO pieza (id_item,periodo,tipo) VALUES (16,'490 a.c','pieza romana');

INSERT INTO item (id_dpto,id_sala,fecha_ingreso,descripcion,coleccion,estado,anno,tipo,nombre,era) VALUES (4,3,'2016-07-13','Corona del Emperador Bizantino Constantino Monomachos, 1042 d.C.','piezas historicas','en exhibicion',1042,'pieza','Corona del Emperador Bizantino ','D.C');
INSERT INTO pieza (id_item,periodo,tipo) VALUES (17,'1042 DC','pieza');

/*insert de obras*/

INSERT INTO item (id_dpto,id_sala,fecha_ingreso,descripcion,coleccion,estado,anno,tipo,nombre,era) VALUES (2,4,'2016-07-13','Patrocinio de San José
, 1744.','obras chilenas','en exhibicion',1744,'obra','Patrocinio de San José','D.C');
INSERT INTO obra (id_item,material,estilo,tipo,autor) VALUES (18,'Oleo sobre tela','Oleo sobre tela','pintura','Gaspar Miguel de Berrio');

INSERT INTO item (id_dpto,id_sala,fecha_ingreso,descripcion,coleccion,estado,anno,tipo,nombre,era) VALUES (2,4,'2016-07-13','Bernardo O’Higgins, Director Supremo
, 1821','obras chilenas','en exhibicion',1821,'obra','Bernardo O’Higgins','D.C');
INSERT INTO obra (id_item,material,estilo,tipo,autor) VALUES (19,'Oleo sobre tela','Oleo sobre tela','pintura','José Gil de Castro y Morales');

INSERT INTO item (id_dpto,id_sala,fecha_ingreso,descripcion,coleccion,estado,anno,tipo,nombre,era) VALUES (2,4,'2016-07-13',' El Huaso y la lavandera
, 1835','obras chilenas','en exhibicion',1835,'obra','El huaso y la lavandera','D.C');
INSERT INTO obra (id_item,material,estilo,tipo,autor) VALUES 20,'Oleo sobre tela','Oleo sobre tela','pintura','Johann Moritz Rugendas');

INSERT INTO item (id_dpto,id_sala,fecha_ingreso,descripcion,coleccion,estado,anno,tipo,nombre,era) VALUES (2,4,'2016-07-13',' Retrato de Julia Codesido de Mora','obras chilenas','en exhibicion',1846,'obra','Retrato de Julia Codesido de Mora','D.C');
INSERT INTO obra (id_item,material,estilo,tipo,autor) VALUES (21,'Oleo sobre tela','Oleo sobre tela','pintura','Raymond Monvoisin');




