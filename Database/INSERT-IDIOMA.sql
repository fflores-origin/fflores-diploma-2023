
declare @idIdiomaEs uniqueidentifier = (select Id from Idioma i where IsoCode = 'es')
declare @idIdiomaEn uniqueidentifier = (select Id from Idioma i where IsoCode = 'en')

declare @value varchar(100) = 'btn_menu_en'

insert into Etiqueta(Nombre) values(@value)

declare @idEtiquetaIdioma uniqueidentifier =  (select Id from Etiqueta e where e.Nombre = @value)

insert into Traduccion(IdiomaId, EtiquetaId, Valor) VALUES(@idIdiomaEs, @idEtiquetaIdioma, 'Ingles')
insert into Traduccion(IdiomaId, EtiquetaId, Valor) VALUES(@idIdiomaEn, @idEtiquetaIdioma, 'English')


select 
		t.idiomaId,
		t.Valor, 
		t.EtiquetaId, 
		e.Nombre 
	from Traduccion t inner join Etiqueta e on t.EtiquetaId = e.Id

	
-- select * from Usuario u 



-- SELECT top(1) u.*, i.Nombre , i.IsoCode , i.IsDefault 
-- FROM Usuario u
-- join Idioma i on u.IdiomaId = i.Id 
-- WHERE Nombre = @username


