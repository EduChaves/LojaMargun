using LojaMargun_Domain.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LojaMargun_Domain.Core.Interfaces.Services
{
    public interface ICategoryService
    {
        Task Add(CategoryDTO categoryDTO);
        Task Update(CategoryDTO categoryDTO);
        Task Remove(CategoryDTO categoryDTO);
        Task<CategoryDTO> GetById(int id);
        Task<IEnumerable<CategoryDTO>> GetAll();
    }
}
