

select * from persona

select * from cliente

create table 

drop table cliente

create table Cliente(
	idCliente serial,
	nit bigint not null,
	nombre varchar(75),
	idPersona integer,
	constraint cliente_pk primary key(idCliente),
	constraint cliente_fk_Persona foreign key (idPersona) references Persona(idPersona) on delete cascade on update cascade
);

create table Proveedor (
	idProveedor serial,
	telefono bigint default '00000000',
	organizacion varchar(50) default 'Desconocida',
	nombre varchar(75) default 'Pendiente de agregar',
	observaciones varchar(150) default 'Ninguna',
	idPersona integer,
	constraint proveedor_pk primary key(idProveedor),
	constraint proveedor_fk_Persona foreign key (idPersona) references Persona(idPersona) on delete cascade on update cascade
);

select * from cliente

insert into cliente (nit, nombre, idPersona) values(456123, 'cliente1', 1)

select cliente.nombre from cliente inner join persona on cliente.idPersona = persona.idPersona where cliente.idPersona = 1

delete from cliente where nit =456123 and idPersona = 1

select * from proveedor

insert into proveedor(nombre, telefono, organizacion, idPersona) values ('proveedor1', 789456123, 'organizacion1', 1)

select * from cliente















