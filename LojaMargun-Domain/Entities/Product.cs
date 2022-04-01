namespace LojaMargun_Domain.Entities
{
    public class Product : EntityBase
    {
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public int Quantity { get; set; }
        public bool Active { get; set; }
    }

}
