using System.Collections.Generic;

namespace LojaMargun_Domain.DTOs
{
    public class BagDTO
    {
        public int ClientId { get; set; }
        public ClientDTO Client { get; set; }
        public virtual IEnumerable<ProductDTO> Products { get; set; }
    }
}
