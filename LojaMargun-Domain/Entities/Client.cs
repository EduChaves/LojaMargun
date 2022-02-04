using System.Collections.Generic;

namespace LojaMargun_Domain.Entities
{
    public class Client : EntityBase
    {
        public string Name { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public bool Active { get; set; }
    }
}
