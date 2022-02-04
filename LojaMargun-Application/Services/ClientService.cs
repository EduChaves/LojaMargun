using LojaMargun_Domain.Core.Interfaces.Services;
using LojaMargun_Domain.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LojaMargun_Application.Services
{
    public class ClientService : IClientService
    {
        public Task Add(ClientDTO clientDTO)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<ClientDTO>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<ClientDTO> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task Remove(ClientDTO clientDTO)
        {
            throw new System.NotImplementedException();
        }

        public Task Update(ClientDTO clientDTO)
        {
            throw new System.NotImplementedException();
        }
    }
}
