namespace LojaMargun_Domain.DTOs
{
    public class ProductDTO : DTOBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Length { get; set; }
        public string Image { get; set; }
        public double Value { get; set; }
    }
}
