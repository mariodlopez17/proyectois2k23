create database if not exists `colchoneria`;
use `colchoneria`;

create table if not exists `tbl_Moneda`(
	id int primary key auto_increment,
	nombre VARCHAR(50) not null,
	simbolo VARCHAR(5) not null,
    estado tinyint not null
);

CREATE TABLE if not exists `tbl_TipoPago` (
	id INT PRIMARY KEY auto_increment,
	nombre VARCHAR(50) not null,
    descripcion VARCHAR(100) not null,
	estado tinyint not null
);
/*
CREATE TABLE if not exists `Pago`(
  id INT PRIMARY KEY auto_increment,
  id_factura INT not null,
  id_tipoPago INT not null,
  fecha_pago DATE not null,
  monto float not null,
  FOREIGN KEY (id_factura) REFERENCES EncabezadoFactura(id_encabezado),
  FOREIGN KEY (id_tipoPago) REFERENCES TipoPago(id)
);
*/