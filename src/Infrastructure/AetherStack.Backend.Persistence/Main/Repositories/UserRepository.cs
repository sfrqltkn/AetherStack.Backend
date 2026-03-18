using AetherStack.Backend.Application.Abstractions.Persistence.Repositories;
using AetherStack.Backend.Domain.Identity;
using AetherStack.Backend.Persistence.Main.Context;
using Microsoft.EntityFrameworkCore;

namespace AetherStack.Backend.Persistence.Main.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly MainDbContext _context;

        public UserRepository(MainDbContext context)
        {
            _context = context;
        }

        public async Task<IList<User>> GetAllUsersAsync(CancellationToken cancellationToken = default)
        {
            return await _context.Users
                                     .AsNoTracking()
                                     .ToListAsync(cancellationToken);
        }
    }
}
