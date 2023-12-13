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
INSERT INTO Categoria(Id, Nombre) VALUES
('AA174E45-E3C1-4F4A-A961-10671FE79761','Articulo')
,('882F8085-B15A-41DE-A905-124893068B8E','Libros')

GO
CREATE TABLE Articulo (
	[Id] uniqueidentifier not null primary key default(newid()),
	[Nombre] VARCHAR(100),
	[Codigo] VARCHAR(100),
	[Descripcion] VARCHAR(200),
	[Imagen] VARCHAR(200) default(''),
	[Marca] VARCHAR(100) default(''),
	[PrecioUnitario] money default(0),
	[CategoriaId] uniqueidentifier,
	
	CONSTRAINT  FK_Articulo_Categoria FOREIGN KEY (CategoriaId) REFERENCES Categoria([Id]),
)

GO
CREATE TABLE Lista (
	[Id] uniqueidentifier not null primary key default(newid()),
	[Nombre] varchar(100),
	[Porcentaje] money
)

GO
CREATE TABLE ListaArticulo (
	[Id] uniqueidentifier not null default(newid()),
	[ArticuloId] uniqueidentifier not null default(newid()),
	[ListaId] uniqueidentifier not null default(newid()),
	[Precio] money not null
	
	CONSTRAINT PK_ListaArticulo PRIMARY KEY(Id, ArticuloId, ListaId),
	CONSTRAINT FK_ListaArticulo_Articulo FOREIGN KEY (ArticuloId) REFERENCES Articulo([Id]),
	CONSTRAINT FK_ListaArticulo_Lista FOREIGN KEY (ListaId) REFERENCES Lista([Id]),
)

insert into Lista (Nombre, Porcentaje) values('Publico', 10.0)


GO
CREATE TABLE TipoDocumento (
	[Id] uniqueidentifier not null primary key default(newid()),
	[Nombre] varchar(100)
)

INSERT INTO TipoDocumento(Id, Nombre) VALUES
('F7269908-A6F5-470F-8260-0B6DBDED3DB7', 'DNI')
,('F94AD59A-22C2-417A-A884-23421F649EE0', 'CUIL')
,('BBA8F733-3C22-4D3F-8165-69D875A49343', 'LE')


GO
CREATE TABLE TipoCliente (
	[Id] uniqueidentifier not null primary key default(newid()),
	[Tipo] nvarchar(3),
	[Nombre] nvarchar(100)
)

INSERT INTO TipoCliente(Id,Tipo,Nombre) values 
('181D2E10-5D4C-42D4-AC92-9E3D3ED1823D', 'CF' ,'Consumidor Final')
,('190C4F9B-F250-44A9-85E1-B40F75150BC1', 'RI' ,'Responsable Inscripto')

GO
CREATE TABLE Cliente (
	[Id] uniqueidentifier not null primary key default(newid()),
	[Nombre] nvarchar(100),
	[Documento] varchar(12),
	[Direccion] varchar(300),
	[Email] nvarchar(200),
	[Telefono] nvarchar(30),
	[TipoDocumentoId] uniqueidentifier not null,
	[TipoClienteId] uniqueidentifier not null,
	
	CONSTRAINT FK_ClienteTipoCliente FOREIGN KEY (TipoClienteId) REFERENCES TipoCliente([Id]),
	CONSTRAINT FK_ClienteTipoDocumento FOREIGN KEY (TipoDocumentoId) REFERENCES TipoDocumento([Id]),
)

-- # start MULTI-IDIOMA

GO
CREATE TABLE Idioma (
	[Id] uniqueidentifier not null primary key default(newid()),
	[Nombre] nvarchar(50) not null,
	[IsoCode] varchar(50) not null,
	[IsDefault] bit not null default(0)
)

INSERT INTO Idioma(Id, Nombre, IsoCode, IsDefault) VALUES
('948F36EC-1ADB-4437-AE83-F76C6AD4058F','Espanol','es',1 )
,('AD4B2622-1857-4BDB-8822-4851A6D6BDB8','Inlges','en',0 )

GO
CREATE TABLE Etiqueta (
	[Id] uniqueidentifier not null primary key default(newid()),
	[Nombre] varchar(50) not null
)

GO
CREATE TABLE Traduccion (
	[IdiomaId] uniqueidentifier not null default(newid()),
	[EtiquetaId] uniqueidentifier not null default(newid()),
	[Valor] varchar(200),
	
	CONSTRAINT PK_Traduccion PRIMARY KEY(IdiomaId,EtiquetaId),
	CONSTRAINT FK_Traduccion_Idioma FOREIGN KEY (IdiomaId) REFERENCES Idioma([Id]),
	CONSTRAINT FK_Traduccion_Etiqueta FOREIGN KEY (EtiquetaId) REFERENCES Etiqueta([Id]),
)

-- # end MULTI-IDIOMA


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
	[IdiomaId] uniqueidentifier,
	
	CONSTRAINT FK_UsuarioIdioma FOREIGN KEY(IdiomaId) REFERENCES Idioma([Id])
)

--INSERT User: admin Pass : Novedad.01
INSERT INTO Usuario (Id, Nombre, Email, Password, IdiomaId) 
VALUES('8723672E-2A7D-49E9-9817-F4727DAD7CE3','admin','admin@admin.com','0g1hLWBXrrBM05D+kxmcTEhAtqzEhyFmc4oSzLE8fDQ=','948F36EC-1ADB-4437-AE83-F76C6AD4058F')

GO
CREATE TABLE UsuarioPermiso (
	[UsuarioId] uniqueidentifier not null,
	[PermisoId] uniqueidentifier not null,
	
	CONSTRAINT PK_UsuarioPermiso PRIMARY KEY(UsuarioId,PermisoId),
	CONSTRAINT FK_UsuarioPermiso_Usuario FOREIGN KEY (UsuarioId) REFERENCES Usuario([Id]),
	CONSTRAINT FK_UsuarioPermiso_Permiso FOREIGN KEY (PermisoId) REFERENCES Permiso([Id]),
)

GO
CREATE TABLE PermisoComponente (
	[PermisoPadreId] uniqueidentifier not null,
	[PermisoHijoId] uniqueidentifier not null,
	constraint PK_PermisoComponente primary key([PermisoPadreId], [PermisoHijoId]) 
)
-- #end USUARIOS PERMISOS

-- #end USUARIOS PERMISOS

GO
IF OBJECT_ID('Logs', 'U') IS NOT NULL
    DROP TABLE Logs;

GO
CREATE TABLE Logs (
	[Id] uniqueidentifier not null,
	[UsuarioId] uniqueidentifier not null,
	[ValorPrevio] varchar(100),
	[NuevoValor] varchar(100),
	[Formulario] varchar(200),
	[Excepcion] varchar(max),
	
	CONSTRAINT PK_Logs PRIMARY KEY ([Id]),
	CONSTRAINT FK_Logs_Usuario FOREIGN KEY ([UsuarioId]) REFERENCES Usuario([Id]),
)

GO
IF OBJECT_ID('Pedido', 'U') IS NOT NULL
    DROP TABLE Pedido;

GO
CREATE TABLE Pedido(
    [Id] uniqueidentifier not null,
    [ClienteId] uniqueidentifier not null,
    [ListaId] uniqueidentifier not null,
    [Fecha] datetime not null,

    CONSTRAINT PK_Pedido PRIMARY KEY ([Id]),
    CONSTRAINT FK_PedidoLista FOREIGN KEY ([ListaId]) REFERENCES Lista([Id]),
    CONSTRAINT FK_PedidoCliente FOREIGN KEY ([ClienteId]) REFERENCES Cliente([Id])
);

GO
IF OBJECT_ID('PedidoDetalle', 'U') IS NOT NULL
    DROP TABLE PedidoDetalle;

GO
CREATE TABLE PedidoDetalle(
	[PedidoId] uniqueidentifier not null,
	[ArticuloId] uniqueidentifier not null,
	[Precio] money not null
	
	CONSTRAINT PK_PedidoDetalle PRIMARY KEY ([PedidoId],[ArticuloId]),
	CONSTRAINT FK_PedidoDetallePedido FOREIGN KEY ([PedidoId]) REFERENCES Pedido([Id]),
	CONSTRAINT FK_PedidoDetalleArticulo FOREIGN KEY ([ArticuloId]) REFERENCES Articulo([Id]),
);


GO
IF OBJECT_ID('Factura', 'U') IS NOT NULL
    DROP TABLE Factura;
   
GO
CREATE TABLE Factura(
	[Id] uniqueidentifier not null,
	[ClienteId] uniqueidentifier not null,
	[PedidoId] uniqueidentifier null,
	[ClienteNombre] varchar(200),
	[ClienteCuit] varchar(100),
	[IngresosBrutos] money,
	[Iva] money,
	[Total] money not null,
	
	CONSTRAINT PK_Factura PRIMARY KEY ([Id]),
	CONSTRAINT FK_FacturaCliente FOREIGN KEY ([ClienteId]) REFERENCES Cliente([Id]),
)

GO
IF OBJECT_ID('FacturaDetalle', 'U') IS NOT NULL
    DROP TABLE FacturaDetalle;

create table FacturaDetalle(
	[FacturaId] uniqueidentifier not null,
	[ArticuloId] uniqueidentifier not null,
	[ArticuloNombre] varchar(500),
	[Cantidad] int not null,
	[Precio] money not null,
	
	CONSTRAINT PK_FacturaDetalle PRIMARY KEY ([FacturaId],[ArticuloId]),
	CONSTRAINT FK_FacturaDetalleFactura FOREIGN KEY ([FacturaId]) REFERENCES Factura([Id]),
	CONSTRAINT FK_FacturaDetalleArticulo FOREIGN KEY ([ArticuloId]) REFERENCES Articulo([Id]),
)

--------------------------------------------------------------------
-- SPs
--------------------------------------------------------------------

GO
CREATE OR ALTER PROCEDURE ListaCreate(
@Id UNIQUEIDENTIFIER,
@Nombre varchar(100),
@Porcentaje money)
AS
BEGIN 
	INSERT INTO Lista
	(Id, Nombre, Porcentaje)
	VALUES(@Id, @Nombre, @Porcentaje);

	INSERT INTO ListaArticulo (ArticuloId, ListaId, Precio)
	SELECT 
		Id as ArticuloId , 
		@id as ListaId, 
		((a.PrecioUnitario * (@Porcentaje /100)) + a.PrecioUnitario) as Precio 
	from Articulo a

END

GO
CREATE OR ALTER PROCEDURE ListaUpdate(
@Id UNIQUEIDENTIFIER,
@Nombre varchar(100),
@Porcentaje money)
AS
BEGIN 
	UPDATE Lista
	SET Nombre=@Nombre, Porcentaje=@Porcentaje
	WHERE Id=@Id;

	UPDATE LA
	SET LA.Precio = (A.PrecioUnitario * (L.Porcentaje /100)) + A.PrecioUnitario
	FROM ListaArticulo LA
	JOIN Articulo A ON LA.ArticuloId = A.Id
	JOIN Lista L ON LA.ListaId = L.Id
	WHERE L.Id = @Id

END



GO
CREATE OR ALTER PROCEDURE PedidoSave(
@Id UNIQUEIDENTIFIER,
@ClienteId UNIQUEIDENTIFIER,
@ListaId UNIQUEIDENTIFIER,
@Fecha datetime)
AS
BEGIN 
	INSERT INTO Pedido
	(Id, ClienteId, ListaId, Fecha)
	VALUES(@Id, @ClienteId, @ListaId, @Fecha);
END

GO
CREATE OR ALTER PROCEDURE PedidoDetalleSave(
@PedidoId UNIQUEIDENTIFIER,
@ArticuloId UNIQUEIDENTIFIER,
@Precio DECIMAL)
AS
BEGIN 
	INSERT INTO PedidoDetalle
	(PedidoId, ArticuloId, Precio)
	VALUES(@PedidoId, @ArticuloId, @Precio);
END

GO
CREATE OR ALTER PROCEDURE PedidoUpdate(
@Id UNIQUEIDENTIFIER,
@ClienteId UNIQUEIDENTIFIER,
@ListaId UNIQUEIDENTIFIER)
AS
BEGIN 
	UPDATE Pedido
	SET ClienteId=@ClienteId, ListaId=@ListaId
	WHERE Id=@Id;
END

GO
CREATE OR ALTER PROCEDURE PedidoDetalleUpdate(
@PedidoId UNIQUEIDENTIFIER,
@ArticuloId UNIQUEIDENTIFIER,
@Precio DECIMAL)
AS
BEGIN 
	UPDATE PedidoDetalle
	SET Precio=@Precio
	WHERE PedidoId=@PedidoId AND ArticuloId=@ArticuloId;
END


GO
CREATE OR ALTER PROCEDURE PedidosGetAll
AS
BEGIN
	SELECT 
		p.Id,
		p.ClienteId,
		p.ListaId,
		c.Nombre,
		c.Documento,
		c.Direccion,
		c.Email,
		c.Telefono,
		c.TipoDocumentoId,
		td.Nombre as TipoDocumentoNombre,
		c.TipoClienteId,
		tc.Nombre as TipoClienteNombre,
		l.Nombre NombreLista, 
		l.Porcentaje  
	from Pedido p
	join Cliente c on c.Id = p.ClienteId
	join TipoCliente tc on tc.Id = c.TipoClienteId
	join TipoDocumento td on td.Id = c.TipoDocumentoId
	join Lista l on l.Id = p.ListaId
	
	SELECT 
		pd.PedidoId,
		pd.Precio,
		a.Id as ArticuloId,
		a.Nombre,
		a.Codigo,
		a.Descripcion , 
		a.Imagen ,
		a.Marca ,
		a.PrecioUnitario ,
		a.CategoriaId ,
		c.Nombre as CategoriaNombre
	from PedidoDetalle pd
	join Articulo a on a.Id = pd.ArticuloId
	join Categoria c on c.Id = a.CategoriaId 
	
END

GO
CREATE OR ALTER PROCEDURE PedidosGet(
@Id UNIQUEIDENTIFIER
)
AS
BEGIN
	
	SELECT 
		p.Id,
		p.ClienteId,
		p.ListaId,
		c.Nombre,
		c.Documento,
		c.Direccion,
		c.Email,
		c.Telefono,
		c.TipoDocumentoId,
		td.Nombre as TipoDocumentoNombre,
		c.TipoClienteId,
		tc.Nombre as TipoClienteNombre,
		l.Nombre NombreLista, 
		l.Porcentaje  
	from Pedido p
	join Cliente c on c.Id = p.ClienteId
	join TipoCliente tc on tc.Id = c.TipoClienteId
	join TipoDocumento td on td.Id = c.TipoDocumentoId
	join Lista l on l.Id = p.ListaId
	WHERE p.Id = @id
	
	SELECT 
		pd.PedidoId,
		pd.Precio,
		a.Id as ArticuloId,
		a.Nombre,
		a.Codigo,
		a.Descripcion , 
		a.Imagen ,
		a.Marca ,
		a.PrecioUnitario ,
		a.CategoriaId ,
		c.Nombre as CategoriaNombre
	from PedidoDetalle pd
	join Articulo a on a.Id = pd.ArticuloId
	join Categoria c on c.Id = a.CategoriaId 
	WHERE pd.PedidoId = @id
	
END

GO
CREATE OR ALTER PROCEDURE TraduccionGetAllByIdioma
@id UNIQUEIDENTIFIER
AS
BEGIN
	SELECT 
		t.IdiomaId,
		t.Valor, 
		t.EtiquetaId, 
		e.Nombre 
	FROM Traduccion t 
		INNER JOIN Etiqueta e ON t.EtiquetaId = e.Id
	WHERE t.IdiomaId = @id
END

GO
CREATE OR ALTER PROCEDURE ClienteGetAll
AS
BEGIN
	SELECT 
		c.*, 
		tc.Tipo TipoCliente, 
		tc.Nombre TipoClienteNombre,
		td.Nombre TipoDocumentoNombre
	FROM Cliente c 
	JOIN TipoCliente tc on tc.Id = c.TipoClienteId 
	JOIN TipoDocumento td on td.Id = c.TipoDocumentoId 
END


GO
CREATE OR ALTER PROCEDURE ClienteCreate(
	@Id uniqueidentifier,
	@Nombre nvarchar(100),
	@Documento varchar(12),
	@Direccion varchar(300),
	@Email nvarchar(200),
	@Telefono nvarchar(30),
	@TipoDocumentoId uniqueidentifier,
	@TipoClienteId uniqueidentifier
)
AS
BEGIN
	INSERT INTO DomainDB.dbo.Cliente
	(Id, Nombre, Documento, Direccion, Email, Telefono, TipoDocumentoId, TipoClienteId)
    VALUES(@Id, @Nombre, @Documento, @Direccion, @Email, @Telefono, @TipoDocumentoId, @TipoClienteId)
END

GO
CREATE OR ALTER PROCEDURE ClienteUpdate(
	@Id uniqueidentifier,
	@Nombre nvarchar(100),
	@Documento varchar(12),
	@Direccion varchar(300),
	@Email nvarchar(200),
	@Telefono nvarchar(30),
	@TipoDocumentoId uniqueidentifier,
	@TipoClienteId uniqueidentifier)
AS
BEGIN
	UPDATE Cliente
	SET 
		Nombre=@Nombre, 
		Documento=@Documento, 
		Direccion=@Direccion, 
		Email=@Email, 
		Telefono=@Telefono, 
		TipoDocumentoId=@TipoDocumentoId, 
		TipoClienteId=@TipoClienteId
    WHERE Id=@Id;
END

GO
CREATE OR ALTER PROCEDURE PatenteGetAll
AS 
BEGIN 
	SELECT * FROM Permiso p where p.TipoPermiso is not null
END

GO
CREATE OR ALTER PROCEDURE FamiliaGetAll
AS 
BEGIN 
	SELECT * FROM Permiso p where p.TipoPermiso is null
END
