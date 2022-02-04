using LojaMargun_Domain.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LojaMargun_Domain.Core.Interfaces.Services
{
    public interface IClientService 
    {
        Task Add(ClientDTO clientDTO);
        Task Update(ClientDTO clientDTO);
        Task Remove(ClientDTO clientDTO);
        Task<ClientDTO> GetById(int id);
        Task<IEnumerable<ClientDTO>> GetAll();
    }
}
