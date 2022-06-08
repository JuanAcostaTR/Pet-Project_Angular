use MascotasDB
go
create proc  Mascota_Delete
@ID int

AS 

Update Mascotas 
set Activo = 0 
where ID = @ID