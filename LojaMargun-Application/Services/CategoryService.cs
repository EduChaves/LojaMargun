using AutoMapper;
using LojaMargun_Domain.Core.Interfaces.Repositories;
using LojaMargun_Domain.Core.Interfaces.Services;
using LojaMargun_Domain.DTOs;
using LojaMargun_Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LojaMargun_Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }
        public async Task Add(CategoryDTO categoryDTO)
        {
            var value = _mapper.Map<Category>(categoryDTO);
            await _categoryRepository.Add(value);
        }

        public async Task<IEnumerable<CategoryDTO>> GetAll()
        {
            var listCategory = await _categoryRepository.GetAll().ToListAsync();
            return _mapper.Map<IEnumerable<CategoryDTO>>(listCategory);
        }

        public Task<CategoryDTO> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task Remove(CategoryDTO categoryDTO)
        {
            throw new System.NotImplementedException();
        }

        public Task Update(CategoryDTO categoryDTO)
        {
            throw new System.NotImplementedException();
        }
    }
}
