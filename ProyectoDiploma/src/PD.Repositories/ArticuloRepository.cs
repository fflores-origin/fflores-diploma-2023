using Microsoft.Extensions.Configuration;
using PD.DataAccess.Interfaces;
using PD.Entities;
using PD.Repositories.Interfaces;

namespace PD.Repositories
{
    public class ArticuloRepository : Repository<ArticuloListaDTO>, IArticuloRepository
    {
        private readonly IConfiguration _configuration;
        private readonly IConnection _connection;

        public ArticuloRepository(IConfiguration configuration, IConnection connection)
            : base(connection)
        {
            _configuration = configuration;
            _connection = connection;
        }
    }
}