using System.Collections.Generic;

namespace LojaMargun_Domain.Entities
{
    public class Category : EntityBase
    {
        public string Name { get; set; }
        public bool Active { get; set; }
        //public virtual IEnumerable<Product> Products { get; set; }
    }
}
