using LojaMargun_Domain.Core.Interfaces.Repositories;
using LojaMargun_Domain.Entities;
using System.Threading.Tasks;

namespace LojaMargun_Infrastructure.Data.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly Context _context;

        public ProductRepository(Context context) : base(context)
        {
        }
       
    }
}
