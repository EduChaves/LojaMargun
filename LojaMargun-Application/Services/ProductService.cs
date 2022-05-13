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
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task Add(ProductDTO productDTO)
        {
            var item = _mapper.Map<Product>(productDTO);
            //await _productRepository.Add(item.Product);
            await _productRepository.Add(item);
        }

        public async Task<IEnumerable<ProductDTO>> GetAll()
        {
            var product = await _productRepository.GetAll().ToListAsync();
            return _mapper.Map<IEnumerable<ProductDTO>>(product);
        }

        public Task<ProductDTO> GetById(int id)
        {
            throw new System.NotImplementedException();
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
