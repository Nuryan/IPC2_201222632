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

insert into Persona(dpi, nombres, apellidos, organizacion, contraseña, nacimiento, residencia, idCargo)
values (1234567890123, 'Admin1 NOmbre','Admin1 Apellido', 'Ninty', md5('asdf'), '1995/12/31', 'Su casa!', 2 )

select *, cargo.nombre from persona inner join cargo on persona.idCargo = cargo.idCargo

select * from persona

select nombres as "gua" from persona where idPersona = 1






