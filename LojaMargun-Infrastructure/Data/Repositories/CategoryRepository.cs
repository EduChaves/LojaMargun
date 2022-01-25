using LojaMargun_Domain.Core.Interfaces.Repositories;
using LojaMargun_Domain.Entities;

namespace LojaMargun_Infrastructure.Data.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(Context context) : base(context)
        {
        }
    }
}
