using System.Collections.Generic;

namespace LojaMargun_Domain.Entities
{
    public class Bag : EntityBase
    {
        public int ProductId { get; set; }
        public double TotalVale { get; set; }
        public virtual Sale Sale { get; set; }
        public virtual IEnumerable<Item> Products { get; set; }
    }
}
