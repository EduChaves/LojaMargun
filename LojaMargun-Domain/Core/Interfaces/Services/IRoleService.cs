using LojaMargun_Domain.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LojaMargun_Domain.Core.Interfaces.Services
{
    public interface IRoleService 
    {
        Task Add(RoleDTO roleDTO);
        Task Update(RoleDTO roleDTO);
        Task Remove(RoleDTO roleDTO);
        Task<RoleDTO> GetById(int id);
        Task<IEnumerable<RoleDTO>> GetAll();
    }
}
