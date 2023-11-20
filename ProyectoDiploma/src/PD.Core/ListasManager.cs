using PD.Core.Interfaces;
using PD.Entities;
using PD.Repositories.Interfaces;

namespace PD.Core
{
    public class ListasManager : IListasManager
    {
        private IListaRepository _listaRepository;

        public ListasManager(
            IListaRepository listaRepository)
        {
            _listaRepository = listaRepository;
        }

        public IList<Lista> GetAll()
        {
            return _listaRepository.GetAll();
        }
    }
}