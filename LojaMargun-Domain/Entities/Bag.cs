using System.Collections.Generic;

namespace LojaMargun_Domain.Entities
{
    public class Bag : EntityBase
    {
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public virtual IEnumerable<Product> Products { get; set; }
    }
}
