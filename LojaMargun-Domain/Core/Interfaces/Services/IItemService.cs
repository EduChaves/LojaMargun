using LojaMargun_Domain.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LojaMargun_Domain.Core.Interfaces.Services
{
    public interface IItemService 
    {
        Task Add(ItemDTO productDTO);
        Task Update(ItemDTO productDTO);
        Task Remove(ItemDTO productDTO);
        Task<ItemDTO> GetById(int id);
        Task<IEnumerable<ItemDTO>> GetAll();
    }
}
