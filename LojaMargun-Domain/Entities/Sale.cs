using System;

namespace LojaMargun_Domain.Entities
{
    public class Sale : EntityBase
    {
        public int BagId { get; set; }
        public Bag Bag { get; set; }
        public DateTime SaleDate { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }
        public string Payment { get; set; }
        public double TotalValue { get; set; }
    }
}
