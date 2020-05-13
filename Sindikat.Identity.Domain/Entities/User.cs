using Microsoft.AspNetCore.Identity;

namespace Sindikat.Identity.Domain.Entities
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

}
