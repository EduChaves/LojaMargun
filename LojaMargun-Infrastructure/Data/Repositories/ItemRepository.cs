using LojaMargun_Domain.Core.Interfaces.Repositories;
using LojaMargun_Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace LojaMargun_Infrastructure.Data.Repositories
{
    public class ItemRepository : Repository<Item>, IItemRepository
    {
        private readonly Context _context;

        public ItemRepository(Context context) : base(context) => _context = context;

        //public override async Task Add(Item entity)
        //{
            
        //    await _context.AddAsync(entity);
        //    await _context.SaveChangesAsync();
            
        //}
    }
}
