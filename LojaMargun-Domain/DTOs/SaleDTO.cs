using System;

namespace LojaMargun_Domain.DTOs
{
    public class SaleDTO
    {
        public int BagId { get; set; }
        public BagDTO Bag { get; set; }
        public DateTime BuyDate { get; set; }
        public string Cep { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string AddressEndNumber { get; set; }
        public string Complement { get; set; }
        public double TotalValue { get; set; }
    }
}
