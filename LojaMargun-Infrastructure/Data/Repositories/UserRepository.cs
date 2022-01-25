using LojaMargun_Domain.Core.Interfaces.Repositories;
using LojaMargun_Domain.Entities;

namespace LojaMargun_Infrastructure.Data.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(Context context) : base(context)
        {
        }
    }
}
