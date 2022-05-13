using System;

namespace LojaMargun_Domain.DTOs
{
    public class SaleDTO : DTOBase
    {
        public int BagId { get; set; }
        public BagDTO Bag { get; set; }
        public int AddressId { get; set; }
        public AddressDTO Address { get; set; }
        public DateTime SaleDate { get; set; }
        public double Payment { get; set; }
    }
}
