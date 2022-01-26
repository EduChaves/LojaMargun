using LojaMargun_Domain.Core.Interfaces.Repositories;
using LojaMargun_Domain.Entities;

namespace LojaMargun_Infrastructure.Data.Repositories
{
    public class BagRepository : Repository<Bag>, IBagRepository
    {
        private readonly Context _context;

        public BagRepository(Context context) : base(context) => _context = context;
    }
}
