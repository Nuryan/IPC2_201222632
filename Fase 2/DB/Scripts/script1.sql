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
	constraint persona_fk_cargo foreign key (idCargo) references cargo(idCargo) on update cascade on delete cascade
);

SELECT *
FROM persona

insert into persona(dpi, nombres, apellidos, email, contraseña) values ()

select nombres from persona where email = 'correo1'

select * from persona
update persona set idCargo = 2 where idPersona = 1

INSERT INTO persona(dpi, nombres, apellidos, email, contraseña) 
VALUES (1231231230,'nombres','apellidos','email', MD5('contraseña'))


select * from cargo

select idcargo from persona where email = 'correo1'

create table organizacion(
	idOrganizacion serial,
	nombre varchar(50) unique not null,
	fechaInscripcion TIMESTAMP DEFAULT now(),
	constraint organizacion_pk primary key(idOrganizacion)
);

insert into organizacion(nombre) values('organizacion1'),('organizacion2')

select * from organizacion

create table participanteOrganizacion(
	idParticipanteOrganizacion serial,
	idPersona int,
	idOrganizacion int,
	administrador int,
	constraint participanteOrganizacion_fk_Persona foreign key (idPersona) references Persona(idPersona)on update cascade on delete cascade,
	constraint participanteOrganizacion_fk_Organizacion foreign key (idOrganizacion) references Organizacion(idOrganizacion)on update cascade on delete cascade,
	constraint participanteOrganizacion_pk primary key(idPersona, idOrganizacion)
);


select * from cargo

insert into cargo (nombre) values ('UsuarioFinal')


update persona set contraseña = MD5('01234') where email = 'correoAp1'

select * from persona where contraseña = MD5('asdf')

create table Modulo(
	idModulo serial,
	nombre varchar(25) unique not null,
	precio float not null default 0.0,
	dbIP varchar(21) not null,
	dbNombre varchar(25) not null unique,
	dbUsuario varchar(25) not null,
	dbPass varchar(100) not null,
	descripcion varchar(150) not null default 'Pendiente de agregar',
	constraint modulo_pk primary key(idModulo) 
);

create table moduloAdquirido(
	idModuloAdquirido serial,
	idPersona integer,
	idOrganizacion integer,
	idModulo integer,
	fechaCompra TIMESTAMP DEFAULT now(),	
	recontratos integer not null default 0,
	constraint moduloAdquirido_fk_Persona foreign key(idPersona) references Persona(idPersona)on update cascade on delete cascade,
	constraint moduloAdquirido_fk_Organizacion foreign key(idOrganizacion) references Organizacion(idOrganizacion)on update cascade on delete cascade,
	constraint moduloAdquirido_fk_Modulo foreign key(idModulo) references Modulo(idModulo)on update cascade on delete cascade,
	constraint moduloAdquirido_pk primary key(idPersona, idOrganizacion, idModulo)
	
);

select * from modulo

insert into modulo (nombre, precio, dbip, dbnombre, dbusuario, dbpass, descripcion)

select * from organizacion

update organizacion set nombre = 'Ninty' where idOrganizacion = 1

select * from persona

update persona set nombres = 'master', apellidos = 'master', email = 'master' where idPersona = 1

select * from participanteOrganizacion;
select * from organizacion


insert into participanteOrganizacion(idPersona, idOrganizacion, administrador) values(1,1,1)

































