namespace PD.Repositories.Interfaces
{
    public interface IRepository<T> where T : class
    {
        T Get(Guid id);

        IQueryable<T> GetAll();

        T Save(T entity);

        T Update(T entity);

        void Delete(Guid id);
    }
}