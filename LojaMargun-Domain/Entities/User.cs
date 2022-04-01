using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace LojaMargun_Domain.Entities
{
    public class User : IdentityUser<string>
    {
        public string Password { get; set; }
        public int RoleId { get; set; }
    }
}
