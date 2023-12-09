﻿namespace PD.Entities
{
    public class Articulo : BaseEntity
    {
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }

        public string Marca { get; set; }

        //public Guid MarcaId { get; set; }
        public decimal PrecioUnitario { get; set; }

        public Guid CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

        //public Marca Marca { get; set; }

        public bool HasImage() => !string.IsNullOrEmpty(Imagen);
    }
}