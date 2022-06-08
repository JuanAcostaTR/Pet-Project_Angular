
use MascotasDB
go
create proc  Mascota_All
as 
select a.ID,
Nombre,
FechaNacimiento,
Observaciones,
CASE WHEN SoporteEmocional = 1 THEN 'true' ELSE 'false' end as SoporteEmocional,
CASE WHEN Lazarillo = 1 THEN 'true' ELSE 'false' end as Lazarillo,
CASE WHEN Activo = 1 THEN 'true' ELSE 'false' end as Activo,
t.ID,
t.Tipo
from Mascotas as a
inner join Tipos as t on t.ID = a.IDTipo
where Activo=1 
order by a.ID ASC
