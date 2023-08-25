using PD.Entities;
using PD.Repositories.Interfaces;

namespace PD.Repositories
{
    public class Repository<T> : IRepository<T> where T : EntidadBase
    {
        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public T Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T Save(T entity)
        {
            throw new NotImplementedException();
        }

        public T Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}