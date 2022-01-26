using LojaMargun_Domain.Core.Interfaces.Repositories;
using LojaMargun_Domain.Entities;

namespace LojaMargun_Infrastructure.Data.Repositories
{
    public class ClientRepository : Repository<Client>, IClientRepository
    {
        private readonly Context _context;
     
        public ClientRepository(Context context) : base(context) => _context = context;
    }
}
