create table cargo(
	idCargo serial,
	nombre varchar(25),
	constraint cargo_pk primary key(idCargo)
);
insert into cargo(nombre) values ('Usuario Ninty'), ('Administrador');

select * from cargo

create table Persona(
	idPersona serial,
	dpi bigint unique,
	nombres varchar(25),
	apellidos varchar(25),
	organizacion varchar(25),
	contraseña text,
	nacimiento date,
	residencia varchar(75),
	idCargo integer,
	constraint persona_pk primary key (idPersona),
	constraint persona_fk_cargo foreign key (idCargo) references cargo(idCargo)	
);

insert into Persona(dpi, nombres, apellidos, organizacion, contraseña, nacimiento, residencia, idCargo, email)
values (1234567890123, 'Admin1 NOmbre','Admin1 Apellido', 'Ninty', md5('asdf'), '1995/12/31', 'Su casa!', 2 , 'correo1')

select *, cargo.nombre from persona inner join cargo on persona.idCargo = cargo.idCargo

select * from persona

update persona set nombres = 'nombresAdmin' where idPersona = 1

select nombres as "gua" from persona where idPersona = 1

SELECT idPersona AS "id" FROM persona WHERE email = 'correo1' AND contraseña = MD5('asdf')

select * from cargo

select persona.*, cargo.nombre as "cargo" from persona inner join cargo on cargo.idCargo = persona.idCargo

alter table persona add email varchar(35) not null unique

drop table persona

drop table persona


create table Persona(
	idPersona serial,
	dpi bigint unique,
	nombres varchar(25) not null default 'Desconocido',
	apellidos varchar(25) not null default 'Desconocido',
	organizacion varchar(25) not null default 'Desconocido',
	contraseña text not null,
	nacimiento date default '1900/01/01',
	residencia varchar(75) default 'Desconocido',
	idCargo integer default 1,
	email varchar(50) not null unique,
	constraint persona_pk primary key (idPersona),
	constraint persona_fk_cargo foreign key (idCargo) references cargo(idCargo)	
);

SELECT *
FROM persona

insert into persona(dpi, nombre, apellidos, email, contraseña) values ()








