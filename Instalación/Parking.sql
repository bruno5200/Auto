CREATE DATABASE Parking
GO
USE Parking
GO
CREATE TABLE autos
(
	auto_id			BIGINT IDENTITY (1,1) PRIMARY KEY NOT NULL,
	placa			NVARCHAR (10)	UNIQUE NOT NULL,
	dir				NVARCHAR (100)	NOT NULL,
	tipo			NVARCHAR (140),
	marca			NVARCHAR (40),
	color			NVARCHAR (40)
)
GO
CREATE TABLE usuarios
(
	usuario_id		BIGINT IDENTITY (1,1) PRIMARY KEY NOT NULL,
	nombre			NVARCHAR (160)	NOT NULL,
	cedula			NVARCHAR (12)	UNIQUE	NOT NULL
)
GO
CREATE TABLE tiempo 
(
	tiempo_id		BIGINT IDENTITY (1,1) PRIMARY KEY NOT NULL, 
	usuario_id		BIGINT			NOT NULL, 
	auto_id			BIGINT			NOT NULL,
	inicio			DATETIME		NOT NULL,
	fin				DATETIME,
	estado			BIT				NOT NULL,
CONSTRAINT Relacion_a_Usuarios FOREIGN KEY (usuario_id) REFERENCES usuarios (usuario_id),
CONSTRAINT Relacion_a_Autos FOREIGN KEY (auto_id) REFERENCES autos (auto_id)
)
GO

CREATE PROC ListarActivos
AS
	SELECT u.nombre AS 'Nombre',  u.cedula AS 'CI', a.placa AS 'Matrícula', a.marca AS 'Modelo', a.color AS 'Color', a.tipo AS 'Tipo', t.inicio AS 'Inicio', t.fin AS 'Final', t.estado AS 'Estado'
	FROM tiempo AS t
	join autos AS a ON t.auto_id = a.auto_id
	join usuarios AS u ON t.usuario_id = u.usuario_id
	where t.estado = 1
GO

CREATE PROC ListarArchivo
AS
	SELECT u.nombre AS 'Nombre',  u.cedula AS 'CI', a.placa AS 'Matrícula', a.marca AS 'Modelo', a.color AS 'Color', a.tipo AS 'Tipo', t.inicio AS 'Inicio', t.fin AS 'Final', t.estado AS 'Estado'
	FROM tiempo AS t
	join autos AS a ON t.auto_id = a.auto_id
	join usuarios AS u ON t.usuario_id = u.usuario_id
	where t.estado = 0
GO

CREATE PROC idUser
@cedula NVARCHAR (12)
AS
	SELECT u.usuario_id
	FROM usuarios AS u
	where @cedula = cedula
GO

CREATE PROC idAuto
@placa NVARCHAR (10)
AS
	SELECT a.auto_id
	FROM autos AS a
	where @placa = placa
GO

CREATE PROC ActualizarAuto
	@auto_id	BIGINT,
	@placa		NVARCHAR (10),
	@dir		NVARCHAR (100),
	@tipo		NVARCHAR (140),
	@marca		NVARCHAR (40),
	@color		NVARCHAR (40)
AS
	UPDATE autos set placa = @placa, dir = @dir, tipo = @tipo, marca = @marca, color = @color
	WHERE @auto_id = auto_id
GO

CREATE PROC AgregarTiempo
	@usuario_id	BIGINT,
	@auto_id	BIGINT,
	@inicio		DATETIME,
	@estado		BIT
AS
	INSERT INTO tiempo VALUES (@usuario_id, @auto_id, @inicio, NULL, @estado)
GO
drop proc AgregarTiempo
CREATE PROC AgregarUsuario
	@nombre		NVARCHAR (160),
	@cedula		NVARCHAR (12)
AS
	INSERT INTO usuarios VALUES (@nombre, @cedula)
GO

CREATE PROC ObtenerAuto
AS
	SELECT TOP 1 placa, dir, auto_id FROM autos order by auto_id desc
GO