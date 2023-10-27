using PD.Core.DTOs;
using PD.Core.Interfaces;
using PD.Repositories.Interfaces;

namespace PD.Core
{
    public class CategoriaManager : ICategoriaManager
    {
        private readonly ICategoriaRepository _repository;

        public CategoriaManager(
            ICategoriaRepository repository)
        {
            _repository = repository;
        }

        public IList<CategoriaDto> GetList()
        {
            throw new NotImplementedException();
        }
    }
}