CREATE database SistemaVentas

Use SistemaVentas

create table Productos(
 Id_producto integer identity primary key,
 nombreProducto varchar(50),
 fechaEntrada date,
 cantidad int,
 IsActive bit,
);



create table Clientes(
 Id_cliente integer identity primary key,
 nombre varchar(50),
 apellido varchar(50),
 cedula varchar(50),
 fechaCreacion int,
 IsActive bit,
);

INSERT INTO Clientes (nombre,apellido,cedula,fechaCreacion,IsActive) VALUES ('Pedro','Medez','40226125363','1',1)


create table Orden(
 Id_orden integer identity primary key,
 ordenName varchar(50),
 fechaCreacion int,
 IsActive bit,
);

create table ListaProductoByOrden(
 ordenId int,
 clienteId int,
 fechaCreacion date,
 IsActive bit,

 FOREIGN KEY (ordenId) references Orden(Id_orden),
 FOREIGN KEY (clienteId) references Clientes(Id_cliente)
);


--FLujo crear la orden ----> una vez creada agregar productos to a orden