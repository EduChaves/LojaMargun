namespace LojaMargun_Domain.DTOs
{
    public class ItemDTO : DTOBase
    {
        public int ProductId { get; set; }
        public ProductDTO Product { get; set; }
        public int Quantity { get; set; }
        public int CategoryId { get; set; }
        public CategoryDTO Category { get; set; }
    }
}
