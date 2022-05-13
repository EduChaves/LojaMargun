
namespace LojaMargun_Domain.DTOs
{
    public class ProductDTO : DTOBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Length { get; set; }
        public string Image { get; set; }
        public decimal Value { get; set; }
        public bool Active { get; set; }
        public int CategoryId { get; set; }
        public CategoryDTO Category { get; set; }
    }
}
