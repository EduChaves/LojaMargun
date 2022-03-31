namespace LojaMargun_Domain.DTOs
{
    public class ProductDTO
    {
        public string Name { get; set; }
        public string Length { get; set; }
        public string Image { get; set; }
        public double Value { get; set; }
        public int CategoryId { get; set; }
        public CategoryDTO Category { get; set; }
    }
}
