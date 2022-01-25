using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace LojaMargun_Domain.Entities
{
    public class User : IdentityUser<string>
    {
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Password { get; set; }
    }
}
