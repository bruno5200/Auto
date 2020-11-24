CREATE DATABASE Parking
GO
USE Parking
GO
CREATE TABLE autos
(
	auto_id		INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
	placa			NVARCHAR (10)	NOT NULL,
	dir				NVARCHAR (100)	NOT NULL,
	descripción		NVARCHAR (140),
	marca			NVARCHAR (40),
	color			NVARCHAR (40)
)
GO
CREATE TABLE Usuarios
(
	usuario_id INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
	nombre_usuario NVARCHAR (144)	NOT NULL,
	cedula_usuario NVARCHAR (12)
)
GO
CREATE TABLE tiempo 
(
	tiempo_id		INT IDENTITY (1,1) PRIMARY KEY NOT NULL, 
	usuario_id		INT				NOT NULL, 
	auto_id			INT				NOT NULL,
	inicio			DATETIME		NOT NULL,
	fin				DATETIME,
	estado			BIT				NOT NULL,
CONSTRAINT Relacion_a_Usuarios FOREIGN KEY (usuario_id) REFERENCES usuarios (usuario_id),
CONSTRAINT Relacion_a_Autos FOREIGN KEY (auto_id) REFERENCES autos (auto_id)
)
GO