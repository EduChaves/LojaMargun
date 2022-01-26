using LojaMargun_Domain.Core.Interfaces.Repositories;
using LojaMargun_Domain.Entities;

namespace LojaMargun_Infrastructure.Data.Repositories
{
    public class SaleRepository : Repository<Sale>, ISaleRepository
    {
        private readonly Context _context;

        public SaleRepository(Context context) : base(context) => _context = context;
    }
}
