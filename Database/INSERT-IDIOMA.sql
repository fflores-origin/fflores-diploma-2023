go
delete from Traduccion 
delete from Etiqueta 

go
declare @idEs uniqueidentifier = (select Id from Idioma i where IsoCode = 'es')
declare @idEn uniqueidentifier = (select Id from Idioma i where IsoCode = 'en')

declare @values table(etiqueta nvarchar(100), valor nvarchar(100), isoCode varchar(10),  idiomaID uniqueidentifier)

insert into @values values
('btn_menu_en', 'Ingles', 'es' , @idEs),
('btn_menu_en', 'English','en' , @idEn),
('btn_menu_es', 'Español','es' , @idEs),
('btn_menu_es', 'Spanish','en' , @idEn),
('tsc_idioma', 'Idioma', 'es', @idEs),
('tsc_idioma', 'Language', 'en', @idEn),
('lbl_producto', 'Producto', 'es', @idEs),
('lbl_producto', 'Product', 'en', @idEn),
('lbl_nombre', 'Nombre', 'es', @idEs),
('lbl_nombre', 'Name', 'en', @idEn),
('lbl_listas', 'Listas', 'es', @idEs),
('lbl_listas', 'Lists', 'en', @idEn),
('lbl_title_lista', 'Listas', 'es', @idEs),
('lbl_title_lista', 'Lists', 'en', @idEn),
('lbl_ganancia', 'Ganancia %', 'es', @idEs),
('lbl_ganancia', 'Profit %', 'en', @idEn),
('lbl_todos', 'Regenerar', 'es', @idEs),
('lbl_todos', 'ReProcess', 'en', @idEn),
('lbl_save', 'Guardar', 'es', @idEs),
('lbl_save', 'Save', 'en', @idEn),
('lbl_articulos_title', 'ARTICULOS', 'es', @idEs),
('lbl_articulos_title', 'ARTICLES', 'en', @idEn),
('lbl_imprimir_qr', 'Imprimir QRs', 'es', @idEs),
('lbl_imprimir_qr', 'Print QRs', 'en', @idEn),
('lbl_agregar', 'Agregar', 'es', @idEs),
('lbl_agregar', 'Add', 'en', @idEn),
('created', 'Creado', 'es', @idEs),
('created', 'Created', 'en', @idEn),
('btn_search', 'Buscar', 'es', @idEs),
('btn_search', 'Search', 'en', @idEn),
('updated', 'Actualizado', 'es', @idEs),
('updated', 'Updated', 'en', @idEn),

('h_name', 'NOMBRE', 'es', @idEs),
('h_name', 'NAME', 'en', @idEn),
('h_code', 'CODIGO', 'es', @idEs),
('h_code', 'CODE', 'en', @idEn),
('h_description', 'DESCRIPCIÓN', 'es', @idEs),
('h_description', 'DESCRIPTION', 'en', @idEn),
('h_image', 'IMAGEN', 'es', @idEs),
('h_image', 'IMAGE', 'en', @idEn),
('h_actions', 'ACCION', 'es', @idEs),
('h_actions', 'ACTION', 'en', @idEn),
('dgb_edit', 'EDITAR', 'es', @idEs),
('dgv_edit', 'EDIT', 'en', @idEn)



INSERT INTO Etiqueta(Nombre)
SELECT DISTINCT etiqueta from @values

DECLARE @joined table(etiquetaID uniqueidentifier, etiqueta varchar(100), idiomaID uniqueidentifier, isoCode varchar(10) )

INSERT INTO @joined
SELECT DISTINCT e.id , e.Nombre etiqueta, i.Id, i.IsoCode idioma from @values v
INNER JOIN Etiqueta e on v.etiqueta = v.etiqueta
INNER JOIN Idioma i on v.idiomaID = i.Id


insert into Traduccion 
select j.idiomaID ,j.etiquetaID, v.valor  from @joined j
inner join @values v on v.etiqueta = j.etiqueta and v.isoCode = j.isoCode


select * from Etiqueta e 
select 
		t.idiomaId,
		t.Valor, 
		t.EtiquetaId, 
		e.Nombre 
	from Traduccion t inner join Etiqueta e on t.EtiquetaId = e.Id


