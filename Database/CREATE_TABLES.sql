GO
IF OBJECT_ID('Articulos', 'U') IS NOT NULL 
  DROP TABLE Articulos; 
GO
create table Articulos (
	[Id] uniqueidentifier not null primary key default(newid()),
	[Nombre] VARCHAR(100),
	[Codigo] VARCHAR(100),
	[Descripcion] VARCHAR(200),
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
IF OBJECT_ID('TipoDocumento', 'U') IS NOT NULL 
  DROP TABLE TipoDocumento; 
GO
create table TipoDocumento (
	[Id] uniqueidentifier not null primary key default(newid()),
	[Nombre] varchar(100)
)
INSERT INTO TipoDocumento(Id, Nombre) VALUES('F7269908-A6F5-470F-8260-0B6DBDED3DB7', 'DNI')
INSERT INTO TipoDocumento(Id, Nombre) VALUES('F94AD59A-22C2-417A-A884-23421F649EE0', 'CUIL')
INSERT INTO TipoDocumento(Id, Nombre) VALUES('BBA8F733-3C22-4D3F-8165-69D875A49343', 'LE')

