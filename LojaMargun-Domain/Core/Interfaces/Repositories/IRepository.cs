using System.Linq;
using System.Threading.Tasks;

namespace LojaMargun_Domain.Core.Interfaces.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task Add(TEntity entity);
        Task Update(TEntity entity);
        Task Remove(TEntity entity);
        IQueryable<TEntity> GetAll();
        Task<TEntity> GetById(int id);
    }
}
