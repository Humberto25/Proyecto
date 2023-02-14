CREATE PROCEDURE spInsertPromotores
@nombreProspecto varchar(50),
@primerAp varchar(30),
@segundoAp varchar(30),
@calle varchar(100),
@numero varchar(8),
@colonia varchar(100),
@codigoPostal int,
@telefono varchar(10),
@rfc varchar(13),
@estatus varchar(10)
AS
BEGIN
	INSERT INTO dbo.tbProspectos(nombreProspecto,primerAp,segundoAp,calle,numero,colonia,codigoPostal,telefono,rfc,estatus)
	VALUES(@nombreProspecto,@primerAp,@segundoAp,@calle,@numero,@colonia,@codigoPostal,@telefono,@rfc,@estatus)
	select SCOPE_IDENTITY()
END