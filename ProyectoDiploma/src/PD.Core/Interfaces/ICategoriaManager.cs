using PD.Core.DTOs;

namespace PD.Core.Interfaces
{
    public interface ICategoriaManager
    {
        public IList<CategoriaDto> GetList();

        void Save(CategoriaDto categoriaDto);
    }
}