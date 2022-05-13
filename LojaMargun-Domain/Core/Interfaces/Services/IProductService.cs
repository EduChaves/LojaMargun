using LojaMargun_Domain.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LojaMargun_Domain.Core.Interfaces.Services
{
    public interface IProductService 
    {
        Task Add(ProductDTO productDTO);
        Task Update(ProductDTO productDTO);
        Task Remove(ProductDTO productDTO);
        Task<ProductDTO> GetById(int id);
        Task<IEnumerable<ProductDTO>> GetAll();
    }
}
