use MascotasDB
go
create proc  Mascota_Update
@ID int,
@Nombre nvarchar(100),
@FechaNacimiento date,
@Observacines nvarchar(max),
@SoporteEmocional bit,
@Lazarillo bit,
@IDTipo int

AS 

Update Mascotas 
set Nombre =@Nombre ,
FechaNacimiento=@FechaNacimiento,
Observaciones=@Observacines,
SoporteEmocional=@SoporteEmocional,
Lazarillo=@Lazarillo,
IDTipo=@IDTipo
where ID = @ID