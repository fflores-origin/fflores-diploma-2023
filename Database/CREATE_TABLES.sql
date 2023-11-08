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
CREATE TABLE Categoria (
	[Id] uniqueidentifier not null primary key default(newid()),
	[Nombre] VARCHAR(100),
)
GO
INSERT INTO Categoria(Id, Nombre) VALUES('AA174E45-E3C1-4F4A-A961-10671FE79761','Articulo')
INSERT INTO Categoria(Id, Nombre) VALUES('882F8085-B15A-41DE-A905-124893068B8E','Libros')

GO
CREATE TABLE Articulo (
	[Id] uniqueidentifier not null primary key default(newid()),
	[Nombre] VARCHAR(100),
	[Codigo] VARCHAR(100),
	[Descripcion] VARCHAR(200),
	[Imagen] VARCHAR(200) default(''),
	[CategoriaId] uniqueidentifier
)

GO
CREATE TABLE Lista (
	[Id] uniqueidentifier not null primary key default(newid()),
	[Nombre] varchar(100)
)

GO
CREATE TABLE ListaArticulo (
	[Id] uniqueidentifier not null default(newid()),
	[ArticuloId] uniqueidentifier not null default(newid()),
	[ListaId] uniqueidentifier not null default(newid()),
	[Precio] money not null
	CONSTRAINT PK_ListaArticulo PRIMARY KEY(Id, ArticuloId,ListaId)
)

go
insert into Lista (Nombre) values('Publico')


GO
CREATE TABLE TipoDocumento (
	[Id] uniqueidentifier not null primary key default(newid()),
	[Nombre] varchar(100)
)

GO
INSERT INTO TipoDocumento(Id, Nombre) VALUES('F7269908-A6F5-470F-8260-0B6DBDED3DB7', 'DNI')
INSERT INTO TipoDocumento(Id, Nombre) VALUES('F94AD59A-22C2-417A-A884-23421F649EE0', 'CUIL')
INSERT INTO TipoDocumento(Id, Nombre) VALUES('BBA8F733-3C22-4D3F-8165-69D875A49343', 'LE')


GO
CREATE TABLE Cliente (
	[Id] uniqueidentifier not null primary key default(newid()),
	[Nombre] varchar(100),
	[Documento] varchar(12),
	[TipoDocumentoId] uniqueidentifier
)

-- #start USUARIOS PERMISOS
GO
CREATE TABLE Permiso (
	[Id] uniqueidentifier not null primary key default(newid()),
	[Nombre] varchar(100),
	[TipoPermiso] varchar(100),
)

GO
CREATE TABLE Usuario (
	[Id] uniqueidentifier not null primary key default(newid()),
	[Nombre] varchar(100) not null,
	[Email] varchar (200),
	[Password] varchar(100) not null,
	[IdiomaId] uniqueidentifier
)
--Pass : Novedad.01
GO
insert into Usuario (Id, Nombre, Email,Password,IdiomaId) values('8723672E-2A7D-49E9-9817-F4727DAD7CE3','admin','admin@admin.com','0g1hLWBXrrBM05D+kxmcTEhAtqzEhyFmc4oSzLE8fDQ=','948F36EC-1ADB-4437-AE83-F76C6AD4058F')

GO
CREATE TABLE UsuarioPermiso (
	[UsuarioId] uniqueidentifier not null,
	[PermisoId] uniqueidentifier not null,
	CONSTRAINT PK_UsuarioPermiso PRIMARY KEY(UsuarioId,PermisoId)
)

GO
CREATE TABLE PermisoComponente (
	[PermisoPadreId] uniqueidentifier not null,
	[PermisoHijoId] uniqueidentifier not null,
	constraint PK_PermisoComponente primary key([PermisoPadreId], [PermisoHijoId]) 
)
-- #end USUARIOS PERMISOS

-- #start MULTI-IDIOMA
GO
CREATE TABLE Idioma (
	[Id] uniqueidentifier not null primary key default(newid()),
	[Nombre] varchar(50) not null,
	[IsoCode] varchar(50) not null,
	[IsDefault] bit not null default(0)
)

GO
INSERT INTO Idioma(Id, Nombre, IsoCode, IsDefault) VALUES('948F36EC-1ADB-4437-AE83-F76C6AD4058F','Español','es',1 )

GO
CREATE TABLE Etiqueta (
	[Id] uniqueidentifier not null primary key default(newid()),
	[Nombre] varchar(50) not null
)

-- #end MULTI-IDIOMA




----
--SPs