CREATE DATABASE IF NOT EXISTS museo;
 
USE museo;
 
 
DROP TABLE IF EXISTS usuario;
 
CREATE TABLE usuario(
  id_usuario INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
  contrasenna VARCHAR(16) NOT NULL,
  nombre VARCHAR(63) NOT NULL,
  rut VARCHAR(9) NOT NULL,
  correo VARCHAR(63) UNIQUE NOT NULL,
  fecha_ingreso DATE NOT NULL,
  tipo VARCHAR(63) NOT NULL
);
 
DROP TABLE IF EXISTS departamento;
 
CREATE TABLE departamento(
  id_dpto INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
  id_usuario INT NOT NULL,
  nombre VARCHAR(63) NOT NULL,
  descripcion VARCHAR(63),
  FOREIGN KEY (id_usuario) REFERENCES usuario(id_usuario) ON DELETE RESTRICT
);

DROP TABLE IF EXISTS sala;
 
CREATE TABLE sala(
  id_sala INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
  id_dpto INT NOT NULL,
  nombre VARCHAR(63) NOT NULL,
  descripcion VARCHAR(63),
  area INT NOT NULL,
  FOREIGN KEY (id_dpto) REFERENCES departamento(id_dpto) ON DELETE RESTRICT
);
 
DROP TABLE IF EXISTS item;
 
CREATE TABLE item(
  id_item INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
  id_dpto INT NOT NULL,
  id_sala INT NOT NULL,
  nombre VARCHAR(63),
  fecha_ingreso DATE NOT NULL,
  descripcion VARCHAR(63),
  coleccion VARCHAR(63),
  estado VARCHAR(63),
  anno VARCHAR(63) NOT NULL,
  FOREIGN KEY (id_dpto) REFERENCES departamento(id_dpto) ON DELETE RESTRICT,
  FOREIGN KEY (id_sala) REFERENCES sala(id_sala) ON DELETE RESTRICT
);

DROP TABLE IF EXISTS solicitud;
 
CREATE TABLE solicitud(
  id_solicitud INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
  id_dpto INT NOT NULL,
  id_item INT NOT NULL,
  id_usuario INT NOT NULL,
  id_sala_origen INT NOT NULL,
  id_sala_destino INT NOT NULL,
  estado VARCHAR(63) NOT NULL,
  comentario VARCHAR(63),
  FOREIGN KEY (id_dpto) REFERENCES departamento(id_dpto) ON DELETE RESTRICT,
  FOREIGN KEY (id_item) REFERENCES item(id_item) ON DELETE RESTRICT,
  FOREIGN KEY (id_usuario) REFERENCES usuario(id_usuario) ON DELETE RESTRICT,
  FOREIGN KEY (id_sala_origen) REFERENCES sala(id_sala) ON DELETE RESTRICT,
  FOREIGN KEY (id_sala_destino) REFERENCES sala(id_sala) ON DELETE RESTRICT
);
 
DROP TABLE IF EXISTS registro;

CREATE TABLE registro(
  id_registro INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
  id_dpto INT NOT NULL,
  id_item INT NOT NULL,
  id_usuario INT NOT NULL,
  id_sala_origen INT NOT NULL,
  id_sala_destino INT NOT NULL,
  fecha_ingreso DATE NOT NULL,
  FOREIGN KEY (id_dpto) REFERENCES departamento(id_dpto) ON DELETE RESTRICT,
  FOREIGN KEY (id_item) REFERENCES item(id_item) ON DELETE RESTRICT,
  FOREIGN KEY (id_usuario) REFERENCES usuario(id_usuario) ON DELETE RESTRICT,
  FOREIGN KEY (id_sala_origen) REFERENCES sala(id_sala) ON DELETE RESTRICT,
  FOREIGN KEY (id_sala_destino) REFERENCES sala(id_sala) ON DELETE RESTRICT
);
 
DROP TABLE IF EXISTS documento;
 
CREATE TABLE documento(
  id_item INT UNIQUE NOT NULL,
  tipo VARCHAR(63) NOT NULL,
  autor VARCHAR(63),
  FOREIGN KEY (id_item) REFERENCES item(id_item) ON DELETE RESTRICT  
);

DROP TABLE IF EXISTS obra;
 
CREATE TABLE obra(
  id_item INT UNIQUE NOT NULL,
  material VARCHAR(63) NOT NULL,
  estilo VARCHAR(63) NOT NULL,
  tipo VARCHAR(63) NOT NULL,
  autor VARCHAR(63),
  FOREIGN KEY (id_item) REFERENCES item(id_item) ON DELETE RESTRICT  
);
 
DROP TABLE IF EXISTS pieza;
 
CREATE TABLE Pieza(
  id_item INT UNIQUE NOT NULL,
  periodo VARCHAR(63) NOT NULL,
  tipo VARCHAR(63) NOT NULL,
  FOREIGN KEY (id_item) REFERENCES item(id_item) ON DELETE RESTRICT  
);

DROP TABLE IF EXISTS vehiculo;
 
CREATE TABLE vehiculo(
  id_item INT UNIQUE NOT NULL,
  marca VARCHAR(63) NOT NULL,
  modelo VARCHAR(63) NOT NULL,
  FOREIGN KEY (id_item) REFERENCES item(id_item) ON DELETE RESTRICT  
);