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
IF OBJECT_ID('Categorias', 'U') IS NOT NULL 
  DROP TABLE Categorias; 
GO
create table Categorias (
	[Id] uniqueidentifier not null primary key default(newid()),
	[Nombre] VARCHAR(100),
)

GO
IF OBJECT_ID('Articulos', 'U') IS NOT NULL 
  DROP TABLE Articulos; 
GO
create table Articulos (
	[Id] uniqueidentifier not null primary key default(newid()),
	[Nombre] VARCHAR(100),
	[Codigo] VARCHAR(100),
	[Descripcion] VARCHAR(200),
	--[CategoriaId] uniqueidentifier
)

GO
IF OBJECT_ID('Listas', 'U') IS NOT NULL 
  DROP TABLE Listas; 
GO
create table Listas (
	[Id] uniqueidentifier not null primary key default(newid()),
	[Nombre] varchar(100)
)

GO
IF OBJECT_ID('TipoDocumentos', 'U') IS NOT NULL 
  DROP TABLE TipoDocumentos; 
GO
create table TipoDocumentos (
	[Id] uniqueidentifier not null primary key default(newid()),
	[Nombre] varchar(100)
)
INSERT INTO TipoDocumentos(Id, Nombre) VALUES('F7269908-A6F5-470F-8260-0B6DBDED3DB7', 'DNI')
INSERT INTO TipoDocumentos(Id, Nombre) VALUES('F94AD59A-22C2-417A-A884-23421F649EE0', 'CUIL')
INSERT INTO TipoDocumentos(Id, Nombre) VALUES('BBA8F733-3C22-4D3F-8165-69D875A49343', 'LE')


GO
IF OBJECT_ID('Clientes', 'U') IS NOT NULL 
  DROP TABLE Clientes; 
GO
create table Clientes (
	[Id] uniqueidentifier not null primary key default(newid()),
	[Nombre] varchar(100),
	[Documento] varchar(12),
	[TipoDocumentoId] uniqueidentifier
)


IF OBJECT_ID('Usuario', 'U') IS NOT NULL 
  DROP TABLE Usuario; 
GO
create table Usuario (
	[Id] uniqueidentifier not null primary key default(newid()),
)