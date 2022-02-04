using LojaMargun_Domain.Core.Interfaces.Services;
using LojaMargun_Domain.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LojaMargun_Application.Services
{
    public class UserService : IUserService
    {
        public Task Add(UserDTO userDTO)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<UserDTO>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<UserDTO> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task Remove(UserDTO userDTO)
        {
            throw new System.NotImplementedException();
        }

        public Task Update(UserDTO userDTO)
        {
            throw new System.NotImplementedException();
        }
    }
}
