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
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, ICategoryRepository categoryRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task Add(ProductDTO productDTO)
        {
            var item = _mapper.Map<Product>(productDTO);
            await _productRepository.Add(item);
        }

        public async Task<IEnumerable<ProductDTO>> GetAll()
        {
            var product = await _productRepository.GetAll().ToListAsync();
            return _mapper.Map<IEnumerable<ProductDTO>>(product);
        }

        public async Task<ProductDTO> GetById(int id)
        {
            var product = await _productRepository.GetById(id);
            product.Category = await _categoryRepository.GetById(product.CategoryId);

            return _mapper.Map<ProductDTO>(product);
        }

        public Task Remove(ProductDTO productDTO)
        {
            throw new System.NotImplementedException();
        }

        public Task Update(ProductDTO productDTO)
        {
            throw new System.NotImplementedException();
        }
    }
}
