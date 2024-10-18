CREATE DATABASE TALLER2CS;

use TALLER2CS;



CREATE TABLE rol_usuario(
	id_rol INT IDENTITY,
	nombre VARCHAR(30) NOT NULL,
	CONSTRAINT PK_ROL PRIMARY KEY (id_rol),
);

INSERT INTO rol_usuario (nombre) VALUES ('Vendedor'),('Administrador'),('Supervisor');


CREATE TABLE usuarios(
	id_usuario INT IDENTITY, 
	nombre VARCHAR(30) NOT NULL,
	apellido VARCHAR(30) NOT NULL,
	dni INT NOT NULL,
	telefono VARCHAR (30),
	direccion VARCHAR(100),
	usuario VARCHAR(40) NOT NULL,
	contrasena VARCHAR (200) NOT NULL,
	rol_id INT NOT NULL,
	fecha_alta DATETIME DEFAULT (getdate()),
	CONSTRAINT PK_USUARIO PRIMARY KEY (id_usuario),
	CONSTRAINT FK_ROL FOREIGN KEY (rol_id) REFERENCES rol_usuario(id_rol),
	CONSTRAINT DNI_UNIQUE UNIQUE (dni),
	CONSTRAINT USER_UNIQUE UNIQUE (usuario)
);


Select * from usuarios


