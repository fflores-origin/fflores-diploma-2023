GO
USE master

GO 
IF EXISTS(SELECT name FROM sys.databases WHERE name = 'DomainDB')
BEGIN
	DECLARE @kill varchar(8000) = '';  
	SELECT @kill = @kill + 'kill ' + CONVERT(VARCHAR(5), session_id) + ';'  
	FROM sys.dm_exec_sessions
	WHERE database_id  = db_id('DomainDB')
	EXEC(@kill);
	DROP DATABASE DomainDB
END

GO
CREATE DATABASE DomainDB

GO
USE DomainDB

GO
create table Categoria (
	[Id] uniqueidentifier not null primary key default(newid()),
	[Nombre] VARCHAR(100),
)
GO
INSERT INTO Categoria(Id, Nombre) VALUES('AA174E45-E3C1-4F4A-A961-10671FE79761','Libreria')
INSERT INTO Categoria(Id, Nombre) VALUES('882F8085-B15A-41DE-A905-124893068B8E','Libros')

GO
create table Articulo (
	[Id] uniqueidentifier not null primary key default(newid()),
	[Nombre] VARCHAR(100),
	[Codigo] VARCHAR(100),
	[Descripcion] VARCHAR(200),
	[Imagen] VARCHAR(200) default(''),
	[CategoriaId] uniqueidentifier
)

GO
create table Lista (
	[Id] uniqueidentifier not null primary key default(newid()),
	[Nombre] varchar(100)
)

GO
create table TipoDocumento (
	[Id] uniqueidentifier not null primary key default(newid()),
	[Nombre] varchar(100)
)

GO
INSERT INTO TipoDocumento(Id, Nombre) VALUES('F7269908-A6F5-470F-8260-0B6DBDED3DB7', 'DNI')
INSERT INTO TipoDocumento(Id, Nombre) VALUES('F94AD59A-22C2-417A-A884-23421F649EE0', 'CUIL')
INSERT INTO TipoDocumento(Id, Nombre) VALUES('BBA8F733-3C22-4D3F-8165-69D875A49343', 'LE')


GO
create table Cliente (
	[Id] uniqueidentifier not null primary key default(newid()),
	[Nombre] varchar(100),
	[Documento] varchar(12),
	[TipoDocumentoId] uniqueidentifier
)

GO
create table Permiso (
	[Id] uniqueidentifier not null primary key default(newid()),
	[Nombre] varchar(100),
	[TipoPermiso] varchar(100),
)

GO
create table Usuario (
	[Id] uniqueidentifier not null primary key default(newid()),
	[Nombre] varchar(100),
	[Email] varchar (200),
	[Contrasenia] varchar(100),
	[IdiomaId] uniqueidentifier
)

GO
create table UsuarioPermiso (
	[UsuarioId] uniqueidentifier not null,
	[PermisoId] uniqueidentifier not null,

	CONSTRAINT PK_UsuarioPermiso PRIMARY KEY(UsuarioId,PermisoId)
)