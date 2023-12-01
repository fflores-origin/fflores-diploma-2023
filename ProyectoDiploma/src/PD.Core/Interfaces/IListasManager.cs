using PD.Entities;

namespace PD.Core.Interfaces
{
    public interface IListasManager
    {
        IList<Lista> GetAll();
        Lista Save(Lista lista);
    }
}