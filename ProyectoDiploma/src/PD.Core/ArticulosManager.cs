using Microsoft.Extensions.Configuration;
using PD.Core.Interfaces;
using PD.Entities.DTO;
using PD.Repositories.Interfaces;

namespace PD.Core
{
    public class ArticulosManager : IArticulosManager
    {
        private readonly IConfiguration _configuration;
        private readonly IArticuloRepository _repository;

        public ArticulosManager(
            IConfiguration configuration,
            IArticuloRepository repository)
        {
            _configuration = configuration;
            _repository = repository;
        }

        public List<ArticulolistaDTO> GetList()
        {
            var data = _repository.GetAll();

            throw new NotImplementedException();
        }

        //public List<ArticuloListaDTO> GetList()
        //{
        //    var data = _repository.GetAll();
        //    return data.ToList();
        //}
    }
}