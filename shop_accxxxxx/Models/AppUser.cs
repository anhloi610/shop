using Microsoft.AspNetCore.Identity;

namespace shop_accxxxxx.Models
{
    public class AppUser : IdentityUser
    {
        public DateTime CreateDate { get; set; }
        public DateTime LastLoginDate { get; set; }
    }
}
