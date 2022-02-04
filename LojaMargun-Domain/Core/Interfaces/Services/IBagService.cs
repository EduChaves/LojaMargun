using LojaMargun_Domain.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LojaMargun_Domain.Core.Interfaces.Services
{
    public interface IBagService
    {
        Task Add(BagDTO bagDTO);
        Task Update(BagDTO bagDTO);
        Task Remove(BagDTO bagDTO);
        Task<BagDTO> GetById(int id);
        Task<IEnumerable<BagDTO>> GetAll();
    }
}
