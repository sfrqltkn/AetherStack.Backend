using Microsoft.AspNetCore.Identity;

namespace AetherStack.Backend.Domain.Identity
{
    public class Role : IdentityRole<int>
    {
        public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
    }
}
