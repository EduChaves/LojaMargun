using System;

namespace LojaMargun_Domain.Entities
{
    public class Sale : EntityBase
    {
        public int BagId { get; set; }
        public Bag Bag { get; set; }
        public string ClientId { get; set; }
        public Client Client { get; set; }
        public DateTime BuyDate { get; set; }
        public double Value { get; set; }
    }
}
