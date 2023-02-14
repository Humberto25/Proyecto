CREATE PROCEDURE spUpdatePromotores
@id int,
@estatus varchar(10),
@Observaciones varchar(400)
AS
BEGIN
	update dbo.tbProspectos set estatus=@estatus, Observaciones=@Observaciones
	where id=@id
END
