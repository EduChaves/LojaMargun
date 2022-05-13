using AutoMapper;
using LojaMargun_Domain.DTOs;
using LojaMargun_Domain.Entities;

namespace LojaMargun_Application.AutoMapper
{
    public class AutoMapperSetup : Profile
    {
        public AutoMapperSetup()
        {
            #region DTOToEntity
            CreateMap<ItemDTO, Item>();
            CreateMap<CategoryDTO, Category>();
            CreateMap<ProductDTO, Product>();
            #endregion

            #region EntityToDTO
            CreateMap<Item, ItemDTO>();
            CreateMap<Category, CategoryDTO>();
            CreateMap<Product, ProductDTO>();
            #endregion
        }
    }
}
