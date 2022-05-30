using Microsoft.AspNetCore.Identity;

namespace Projekt.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
       public ICollection<Offer>? Offers { get; set; }
    }
}
