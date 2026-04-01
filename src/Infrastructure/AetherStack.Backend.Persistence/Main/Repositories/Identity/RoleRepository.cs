using AetherStack.Backend.Application.Abstractions.Persistence.Repositories.Identity;
using AetherStack.Backend.Domain.Identity;
using AetherStack.Backend.Persistence.Main.Context;
using Microsoft.EntityFrameworkCore;

namespace AetherStack.Backend.Persistence.Main.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly MainDbContext _context;

        public RoleRepository(MainDbContext context)
        {
            _context = context;
        }

        public async Task<IList<Role>> GetAllRolesAsync(CancellationToken cancellationToken = default)
        {
            return await _context.Roles
                  .AsNoTracking()
                  .ToListAsync(cancellationToken);
        }
    }
}
