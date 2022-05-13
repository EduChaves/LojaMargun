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
    public class ItemService : IItemService
    {
        private readonly IItemRepository _itemRepository;
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ItemService(IItemRepository itemRepository, IProductRepository productRepository, IMapper mapper)
        {
            _itemRepository = itemRepository;
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task Add(ItemDTO itemDTO)
        {
            var item = _mapper.Map<Item>(itemDTO);
            //await _productRepository.Add(item.Product);
            await _itemRepository.Add(item);
        }

        public async Task<IEnumerable<ItemDTO>> GetAll()
        {
            var item = await _itemRepository.GetAll().ToListAsync();
            return _mapper.Map<IEnumerable<ItemDTO>>(item);
        }

        public Task<ItemDTO> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task Remove(ItemDTO itemtDTO)
        {
            throw new System.NotImplementedException();
        }

        public Task Update(ItemDTO itemDTO)
        {
            throw new System.NotImplementedException();
        }
    }
}
