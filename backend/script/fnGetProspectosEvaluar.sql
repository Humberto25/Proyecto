CREATE FUNCTION fnGetProspectosEvaluar()
RETURNS TABLE
AS
RETURN
    SELECT 
        id,
        nombreProspecto,
		primerAp,
		segundoAp,
		calle,
		numero,
		colonia,
		codigoPostal,
		telefono,
		rfc,
		estatus,
		Observaciones
    FROM
        dbo.tbProspectos
	where estatus='Enviado'