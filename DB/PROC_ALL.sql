
use MascotasDB
go
create proc  Mascota_All
as 
select a.ID,
Nombre,
FechaNacimiento,
Observaciones,
SoporteEmocional,
Lazarillo,
t.ID,
t.Tipo
from Mascotas as a
inner join Tipos as t on t.ID = a.IDTipo
where Activo=1 
order by a.ID ASC