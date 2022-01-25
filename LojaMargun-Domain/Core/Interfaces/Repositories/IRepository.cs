using System.Linq;

namespace LojaMargun_Domain.Core.Interfaces.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);
        IQueryable<TEntity> GetAll();
        TEntity GetById(int id);
    }
}
