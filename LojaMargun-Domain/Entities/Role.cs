using Microsoft.AspNetCore.Identity;

namespace LojaMargun_Domain.Entities
{
    public class Role : IdentityRole<string>
    {
        public string Description { get; set; }
    }
}
