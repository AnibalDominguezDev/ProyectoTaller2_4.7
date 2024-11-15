CREATE DATABASE taller2cs;

use taller2cs;

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
	estadoUsuario INT NOT NULL,
	fecha_alta DATETIME DEFAULT (getdate()),
	CONSTRAINT PK_USUARIO PRIMARY KEY (id_usuario),
	CONSTRAINT FK_ROL FOREIGN KEY (rol_id) REFERENCES rol_usuario(id_rol),
	CONSTRAINT DNI_UNIQUE UNIQUE (dni),
	CONSTRAINT USER_UNIQUE UNIQUE (usuario)
);

insert into usuarios(nombre,apellido,dni,telefono,direccion,usuario,contrasena,rol_id,estadoUsuario)
values ('Juan','Perez','13242142','3214213214','Av Lavalle 123','admin','admin',2,1),
	   ('Martin','Lopez','23123142','12423122','Buenos Aires 1200','vendedor','vendedor',1,1),
		('Julian','Fernandez','32123212','14212321','Salta 1300','supervisor','supervisor',3,1);

CREATE TABLE categoria_productos(
	id_categoria INT IDENTITY,
	nombre VARCHAR(30) NOT NULL,
	CONSTRAINT PK_CATEGORIA_PRODUCTOS PRIMARY KEY(id_categoria),
	CONSTRAINT NOMBRE_UNIQUE UNIQUE(nombre)
);

insert into categoria_productos values('Remeras');

CREATE TABLE marcas(
	id_marca INT IDENTITY,
	nombre VARCHAR(50) UNIQUE NOT NULL,
	CONSTRAINT PK_MARCA PRIMARY KEY (id_marca),
);

insert into marcas(nombre) values ('adidas');

CREATE TABLE proveedores(
	id_proveedor INT IDENTITY,
	nombre VARCHAR(50) UNIQUE NOT NULL,
	direccion VARCHAR(80) NOT NULL,
	telefono VARCHAR (30) NOT NULL,
	email VARCHAR (60) NOT NULL,
	estado_proveedor INT NOT NULL DEFAULT (1),
	CONSTRAINT PK_PROVEEDOR PRIMARY KEY (id_proveedor),
);

insert into proveedores (nombre,direccion,telefono,email,estado_proveedor) values ('proveedor1','San Martin 1600','32142132','prov@mail.com',1);

CREATE TABLE productos(
	id_producto INT IDENTITY,
	nombre VARCHAR(30) NOT NULL,
	descripcion VARCHAR (100) NOT NULL,
	precio FLOAT NOT NULL,
	stock INT NOT NULL,
	stock_minimo INT NOT NULL,
	id_categoria INT NOT NULL,
	id_marca INT NOT NULL,
	id_proveedor INT NOT NULL,
	create_at DATETIME DEFAULT(getdate()),
	estado_producto INT NOT NULL,
	cod_producto VARCHAR(40) NOT NULL,
	CONSTRAINT PK_PRODUCTO PRIMARY KEY (id_producto),
	CONSTRAINT FK_CATEGORIA_PRODUCTO FOREIGN KEY (id_categoria) REFERENCES categoria_productos(id_categoria),
	CONSTRAINT FK_PRODUCTO_MARCA FOREIGN KEY (id_marca) REFERENCES marcas (id_marca),
	CONSTRAINT FK_PRODUCTO_PROVEEDOR FOREIGN KEY (id_proveedor) REFERENCES proveedores (id_proveedor),
	CONSTRAINT CODPRODUCTO_UNIQUE UNIQUE(cod_producto)
);

insert into productos (nombre,descripcion,precio,stock,stock_minimo,id_categoria,id_marca,id_proveedor,estado_producto,cod_producto)
values ('Remera adidas negra','Remera xl adidas',12000,12,4,1,1,1,1,'remAdidasNegra');


CREATE TABLE clientes(
	id_cliente INT IDENTITY,
	nombre VARCHAR(30) NOT NULL,
	apellido VARCHAR(40) NOT NULL,
	dni VARCHAR(12) NOT NULL,
	telefono VARCHAR(30),
	direccion VARCHAR(80) NOT NULL,
	correo VARCHAR(60) NOT NULL,
	estado_cliente INT NOT NULL,
	create_at DATETIME DEFAULT(getdate()),
	CONSTRAINT PK_CLIENTE PRIMARY KEY (id_cliente)
);

insert into clientes (nombre,apellido,dni,telefono,direccion,correo,estado_cliente) values ('Pedro','Ramirez','1321421','3121421232','Las heras 1200','pedro@mail.com',1);

create table metodo_pago(
id_metodopago INT IDENTITY,
descripcion VARCHAR (40) NOT NULL,
CONSTRAINT PK_METODOPAGO PRIMARY KEY (id_metodopago)
);

insert into metodo_pago (descripcion) values ('Efectivo'),('Tarjeta Credito / Debito'), ('MercadoPago');

CREATE TABLE ventas(
	id_venta INT IDENTITY,
	id_cliente INT NOT NULL,
	id_usuario INT NOT NULL,
	fecha DATETIME DEFAULT(getdate()) NOT NULL,
	precio_total FLOAT NOT NULL,
	id_metodoPago INT NOT NULL,
	CONSTRAINT PK_VENTA PRIMARY KEY (id_venta),
	CONSTRAINT FK_CLIENTE_VENTA FOREIGN KEY(id_cliente) REFERENCES clientes(id_cliente), 
	CONSTRAINT FK_USUARIO_VENTA FOREIGN KEY(id_usuario) REFERENCES usuarios(id_usuario),
	CONSTRAINT FK_METODOPAGO_VENTA FOREIGN KEY (id_metodoPago) REFERENCES metodo_pago(id_metodoPago)
);

insert into ventas (id_cliente,id_usuario,precio_total,id_metodoPago) values (1,1,12000,1), (1,1,24000,1);

CREATE TABLE venta_detalle(
	id_detalle_venta INT IDENTITY,
	id_venta INT NOT NULL,
	id_producto INT NOT NULL,
	cantidad INT NOT NULL,
	precio DECIMAL(18,2) NOT NULL,
	CONSTRAINT PK_DETALLE_VENTA PRIMARY KEY(id_detalle_venta),
	CONSTRAINT FK_VENTA_DETALLE_VENTA FOREIGN KEY(id_venta) REFERENCES ventas(id_venta),
	CONSTRAINT FK_PRODUCTO_VENTA FOREIGN KEY(id_producto) REFERENCES productos(id_producto)
);

insert into venta_detalle(id_venta,id_producto,cantidad,precio) values (1,1,1,12000), (1,1,2,12000);




