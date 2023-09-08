using Microsoft.Extensions.Configuration;
using PD.Core.DTO;
using PD.Core.Interfaces;
using PD.Core.Mappers.Interfaces;
using PD.Repositories.Interfaces;

namespace PD.Core
{
    public class ArticulosManager : IArticulosManager
    {
        private readonly IConfiguration _configuration;
        private readonly IArticuloRepository _repository;
        private readonly IArticulosMapper _articuloMapper;

        public ArticulosManager(
            IConfiguration configuration,
            IArticuloRepository repository,
            IArticulosMapper articuloMapper)
        {
            _configuration = configuration;
            _repository = repository;
            _articuloMapper = articuloMapper;
        }

        public List<ArticuloListaDTO> GetList() 
            => _articuloMapper.GetArticuloListas(_repository.GetAll().ToList());
    }
}