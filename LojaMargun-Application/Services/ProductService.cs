using AutoMapper;
using LojaMargun_Domain.Core.Interfaces.Repositories;
using LojaMargun_Domain.Core.Interfaces.Services;
using LojaMargun_Domain.DTOs;
using LojaMargun_Domain.Entities;
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
            var product = _mapper.Map<Product>(productDTO);
            await _productRepository.Add(product);
        }

        public Task<IEnumerable<ProductDTO>> GetAll()
        {
            throw new System.NotImplementedException();
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
