using Microsoft.AspNetCore.Identity;
using NHibernate.Util;

namespace Mango.Services.AuthAPI.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; } = string.Empty;
    }
}
