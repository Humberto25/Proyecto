CREATE FUNCTION fnGetDocumentos(@id int)
RETURNS TABLE
AS
RETURN
    SELECT 
       id,
	   idProspecto,
	   documento,
	   extension,
	   nombreDocumento
    FROM
        dbo.tbDocumentos
	WHERE 
		idProspecto=@id
