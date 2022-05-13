using System.Collections.Generic;

namespace LojaMargun_Domain.DTOs
{
    public class BagDTO : DTOBase
    {
        public int ProductId { get; set; }
        public double TotalValue { get; set; }
        public virtual IEnumerable<ProductDTO> Products { get; set; }
    }
}
