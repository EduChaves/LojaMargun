using LojaMargun_Domain.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LojaMargun_Domain.Core.Interfaces.Services
{
    public interface ISaleService 
    {
        Task Add(SaleDTO saleDTO);
        Task Update(SaleDTO saleDTO);
        Task Remove(SaleDTO saleDTO);
        Task<SaleDTO> GetById(int id);
        Task<IEnumerable<SaleDTO>> GetAll();
    }
}
