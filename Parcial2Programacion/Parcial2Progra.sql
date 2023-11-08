CREATE DATABASE BDParcial2BryanAlexisDuranDuran;
GO
USE BDParcial2BryanAlexisDuranDuran;
GO

CREATE TABLE Cliente (
  IdCliente INT PRIMARY KEY IDENTITY,
  Nombre VARCHAR(30) NOT NULL,
  Apellido VARCHAR(30) NOT NULL,
  Departamento VARCHAR(22),
  Municipio VARCHAR(22)
)

select * from Cliente;

Insert Into Cliente(Nombre,Apellido,Departamento,Municipio)
values ('Mario','Mendoza','La Paz','Olcuilta');


Insert Into Cliente(Nombre,Apellido,Departamento,Municipio) 
values('Bryan','Duran','San Salvador','Olcuilta');