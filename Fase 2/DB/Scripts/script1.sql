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

alter table organizacion add numParticipantes integer default 3

update organizacion set numparticipantes = 999999 where idOrganizacion = 1


select count(*) from participanteorganizacion where idOrganizacion = 1


select * from organizacion

select idOrganizacion from organizacion where nombre = ''


select nombre from organizacion where nombre = 'asdf'

insert into organizacion(nombre) values('organizacion 3')

update organizacion set numParticipantes = organizacion.numParticipantes + 4 where idOrganizacion =4

select * from participanteOrganizacion

select idPersona from persona where email = 'master'

select * from persona

select * from organizacion

select count(*) from participanteOrganizacion where participanteOrganizacion.idOrganizacion = 1

select numParticipantes from organizacion where idOrganizacion = 1

SELECT organizacion.numParticipantes - participanteOrganizacion.count(*)
FROM organizacion
INNER JOIN participanteorganizacion ON organizacion.idOrganizacion = participanteOrganizacion.idOrganizacion
where organizacion.idOrganizacion = 1


select numParticipantes from organizacion where idOrganizacion = 1

select * from organizacion 

select * from organizacion

select idOrganizacion from organizacion where nombre ='master'

select * from persona

select * from cargo

select * from persona

create table empleado(
	idUsuario integer,
	idEmpleado integer,
	constraint empleado_fk_usuario foreign key(idUsuario) references Persona(idPersona) on update cascade on delete cascade,
	constraint empleado_fk_empleado foreign key(idEmpleado) references Persona(idPersona) on update cascade on delete cascade,
	constraint empleado_pk primary key (idUsuario, idEmpleado )
);

alter table persona add numEmpleados integer default 3

select * from persona

update persona set numEmpleados = 999999 where idPersona =1

select * from cargo

update cargo set nombre = 'Empleado' where idCargo = 3


select * from persona

update persona set idCargo = 2 where idPersona = 1

select * from empleado

insert into empleado(idUsuario, idEmpleado) values(1,2)

select * from persona

select numEmpleados from persona where idPersona = 2

select * from empleado


select count(*) from empleado where idUsuario = 1


select * from persona where contraseña = md5('asdf')

select * from persona

update persona set contraseña = md5('asdf') where idPersona = 1

select * from empleado

update persona set numEmpleados = 0 where idPersona = 4

select * from empleado

select * from persona inner join empleado on persona.idPersona = empleado.idUsuario where persona.idPersona = 1

select * from participanteOrganizacion

select idParticipanteOrganizacion from participanteOrganizacion where idPersona = 1 and idOrganizacion =3

select * from persona

select * from organizacion

select * from participanteOrganizacion

insert into participanteOrganizacion(idPersona, idOrganizacion, administrador) values (4,1,0)

update participanteOrganizacion set administrador = 0 where idparticipanteorganizacion = 2

select persona.email from persona inner join empleado on persona.idPersona = empleado.idUsuario where persona.idPersona = 1

select * from empleado

select persona.email from empleado inner join persona on persona.idPersona = empleado.idEmpleado where empleado.idUsuario = 1

select * from participanteOrganizacion

select * from organizacion 

SELECT organizacion.nombre
FROM organizacion
INNER JOIN participanteOrganizacion ON organizacion.idorganizacion = participanteOrganizacion.idOrganizacion
WHERE Participanteorganizacion.administrador = 1 AND participanteorganizacion.idPersona = 1


select * from organizacion 

select * from participanteOrganizacion  

insert into participanteOrganizacion(idPersona, idOrganizacion, administrador) values (1,2,1), (1,3,1)

select idParticipanteOrganizacion from participanteOrganizacion where idPersona = 1 and idOrganizacion = 3

select * from persona

select idParticipanteOrganizacion from participanteOrganizacion where idPersona = 1 and idOrganizacion =1


select count(*) from participanteOrganizacion where idPersona = 1 and idOrganizacion =1


select count(*) from participanteOrganizacion where idPersona = 7 and idOrganizacion = 3


select idParticipanteOrganizacion from participanteOrganizacion where idPersona = 1 and idOrganizacion =1


select * from persona a1  7

select * from organizacion orga3 3

select * from modulo

insert into modulo (nombre, precio, )

alter table modulo drop column dbpass


INSERT INTO modulo (nombre, precio) VALUES ('Inventario',150.00),('Ventas',150.00),('Compras',150.00),('Facturacion',150.00), ('Reclutamiento',150.00),('Flotas',150.00),('Blog',150.00),('Eventos',150.00),('CRM',150.00),('Descuentos',150.00)


select * from moduloAdquirido


insert into moduloAdquirido (idPersona, idOrganizacion, idModulo) values ()


select * from persona

select * from moduloAdquirido

select * from organizacion

select * from modulo

insert into moduloAdquirido (idPersona, idOrganizacion, idModulo) values ('')

select * from participanteOrganizacion where administrador = 1

select persona.idPersona from persona inner join participanteOrganizacion on persona.idPersona = participanteOrganizacion.idPersona where administrador = 1 and idOrganizacion = 5

















