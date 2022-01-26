using System.Collections.Generic;

namespace LojaMargun_Domain.Entities
{
    public class Product : EntityBase
    {
        public string Name { get; set; }
        public string Length { get; set; }
        public byte Image { get; set; }
        public int Active { get; set; }
        public double Value { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int BagId { get; set; }
        public Bag Bag { get; set; }
    }
}
