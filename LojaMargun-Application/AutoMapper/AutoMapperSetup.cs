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
            CreateMap<CategoryDTO, Category>();
            CreateMap<ProductDTO, Product>();
            #endregion

            #region EntityToDTO
            CreateMap<Category, CategoryDTO>();
            CreateMap<Product, ProductDTO>();
            #endregion
        }
    }
}
