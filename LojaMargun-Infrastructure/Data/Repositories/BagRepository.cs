using LojaMargun_Domain.Core.Interfaces.Repositories;
using LojaMargun_Domain.Entities;

namespace LojaMargun_Infrastructure.Data.Repositories
{
    public class BagRepository : Repository<Bag>, IBagRepository
    {
        public BagRepository(Context context) : base(context)
        {
        }
    }
}
