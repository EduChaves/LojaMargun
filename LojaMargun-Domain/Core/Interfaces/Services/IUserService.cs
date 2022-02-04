using LojaMargun_Domain.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LojaMargun_Domain.Core.Interfaces.Services
{
    public interface IUserService 
    {
        Task Add(UserDTO userDTO);
        Task Update(UserDTO userDTO);
        Task Remove(UserDTO userDTO);
        Task<UserDTO> GetById(int id);
        Task<IEnumerable<UserDTO>> GetAll();
    }
}
