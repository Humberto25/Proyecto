CREATE PROCEDURE spInsert_Documentos
@idProspecto int,
@documento varbinary(max),
@extension varchar(5),
@nombreDocumento varchar(200)
AS
BEGIN
	INSERT INTO dbo.tbDocumentos(idProspecto,documento,extension,nombreDocumento)
	VALUES(@idProspecto,@documento,@extension,@nombreDocumento)
END
