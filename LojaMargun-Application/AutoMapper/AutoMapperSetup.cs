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
            CreateMap<ProductDTO, Product>();
            CreateMap<CategoryDTO, Category>();
            #endregion

            #region EntityToDTO
            CreateMap<Product, ProductDTO>();
            CreateMap<Category, CategoryDTO>();
            #endregion
        }
    }
}
