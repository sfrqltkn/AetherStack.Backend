using AetherStack.Backend.Application.Abstractions.Persistence.Repositories.Identity;
using AetherStack.Backend.Application.DTOs.UserRoles;
using AetherStack.Backend.Persistence.Main.Context;
using Microsoft.EntityFrameworkCore;

namespace AetherStack.Backend.Persistence.Main.Repositories.Identity
{
    public class UserRolesRepository : IUserRolesRepository
    {
        private readonly MainDbContext _context;

        public UserRolesRepository(MainDbContext context)
        {
            _context = context;
        }

        public async Task<IList<UserRolesDto>> GetAllUserRolesAsync(CancellationToken cancellationToken = default)
        {
            var query = from ur in _context.UserRoles
                        join u in _context.Users on ur.UserId equals u.Id
                        join r in _context.Roles on ur.RoleId equals r.Id
                        select new UserRolesDto
                        {
                            UserId = ur.UserId,
                            UserName = u.UserName!,
                            RoleId = ur.RoleId,
                            RoleName = r.Name!
                        };

            return await query.AsNoTracking().ToListAsync(cancellationToken);
        }
    }
}
