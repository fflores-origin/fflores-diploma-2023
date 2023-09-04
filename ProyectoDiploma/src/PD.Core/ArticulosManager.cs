using Microsoft.Extensions.Configuration;
using PD.Core.Interfaces;
using PD.Entities;
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

        public List<Articulo> GetAll()
        {
            var data = _repository.GetAll();
            return data.ToList();
        }
    }
}