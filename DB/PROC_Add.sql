use MascotasDB
go
create procedure  Mascota_Add
@Nombre nvarchar(100),
@FechaNacimiento date,
@Observacines nvarchar(max),
@SoporteEmocional bit,
@Lazarillo bit,
@IDTipo int

AS 

insert into Mascotas (Nombre,FechaNacimiento,Observaciones,SoporteEmocional,Lazarillo, Activo,IDTipo)
values (@Nombre,@FechaNacimiento,@Observacines,@SoporteEmocional, @Lazarillo,1,@IDTipo)