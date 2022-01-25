using LojaMargun_Domain.Core.Interfaces.Repositories;
using LojaMargun_Domain.Entities;

namespace LojaMargun_Infrastructure.Data.Repositories
{
    public class RoleRepository : Repository<Role>, IRoleRepository
    {
        public RoleRepository(Context context) : base(context)
        {
        }
    }
}
