CREATE DATABASE Parcial2Ras;
USE master
GO
CREATE LOGIN usrparcial2 WITH PASSWORD='12345678',
	DEFAULT_DATABASE=Parcial2Ras,
	CHECK_EXPIRATION=OFF,
	CHECK_POLICY=ON
GO
USE Parcial2Ras
GO
CREATE USER usrparcial2 FOR LOGIN usrparcial2
GO
ALTER ROLE db_owner ADD MEMBER usrparcial2
GO
CREATE TABLE  serie (
  id int NOT NULL PRIMARY KEY IDENTITY(1,1),
  titulo varchar(250) NOT NULL,
  sinopsis varchar(5000) NOT NULL,
  director varchar(100) NOT NULL,
  duracion int NOT NULL,
  fechaestreno date NOT NULL,
  estado smallint NOT NULL
); 
