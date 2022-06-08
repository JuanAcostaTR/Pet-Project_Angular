
create DataBAse MascotasDB
go
use MascotasDB
CREATE TABLE Tipos(
ID int NOT NULL,
Tipo nvarchar(100),
PRIMARY KEY (ID)
);

CREATE TABLE Mascotas (
    ID int IDENTITY(1,1),  
    Nombre nvarchar(50) NOT NULL,
    FechaNacimiento DateTime,
	Observaciones nvarchar(255) NULL,
	SoporteEmocional bit NOT NULL,
	Lazarillo bit NOT NULL,
	Activo bit NOT NULL,
	IDTipo int NOT NULL,
    PRIMARY KEY (ID)
);


ALTER TABLE Mascotas
ADD CONSTRAINT FK_MascotasTipo
FOREIGN KEY (IDTipo) REFERENCES Tipos(ID);
