CREATE TABLE tbProspectos(
	id int not null primary key identity(1,1),
    nombreProspecto varchar(50) NOT NULL,
    primerAp varchar(30) NOT NULL,
    segundoAp varchar(30),
    calle varchar(100) NOT NULL,
    numero varchar(8) NOT NULL,
    colonia varchar(100) NOT NULL,
    codigoPostal int NOT NULL,
    telefono varchar(10) NOT NULL,
	rfc varchar(13) NOT NULL,
	estatus varchar(10) NOT NULL,
	Observaciones varchar(400),
);