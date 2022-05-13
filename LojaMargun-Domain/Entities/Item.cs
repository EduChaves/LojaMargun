namespace LojaMargun_Domain.Entities
{
    public class Item : EntityBase
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int Quantity { get; set; }
        public bool Active { get; set; }
    }

}
