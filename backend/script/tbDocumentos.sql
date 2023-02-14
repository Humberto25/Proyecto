create table tbDocumentos(
	id int not null primary key identity(1,1),
	idProspecto int not null,
	documento varbinary(max) NOT NULL,
	extension varchar(5),
	nombreDocumento varchar(200) NOT NULL,
);
