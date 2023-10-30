using PD.Core.DTOs;
using PD.Core.Interfaces;
using PD.Core.Mappers.Interfaces;
using PD.Repositories.Interfaces;

namespace PD.Core
{
    public class CategoriaManager : ICategoriaManager
    {
        private readonly ICategoriaRepository _repository;
        private readonly ICategoriaMapper _mapper;

        public CategoriaManager(
            ICategoriaRepository repository,
            ICategoriaMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public IList<CategoriaDto> GetList()
        {
            return _mapper.Map(_repository.GetAll().ToList());
        }

        public void Save(CategoriaDto categoriaDto)
        {
            throw new NotImplementedException();
        }
    }
}