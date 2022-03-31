namespace LojaMargun_Domain.Entities
{
    public class Product : EntityBase
    {
        public string Name { get; set; }
        public string Length { get; set; }
        public string Image { get; set; }
        public int Active { get; set; }
        public double Value { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public int BagId { get; set; }
        public virtual Bag Bag { get; set; }
    }
}
