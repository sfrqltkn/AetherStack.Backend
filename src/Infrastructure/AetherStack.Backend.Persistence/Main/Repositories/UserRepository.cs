using AetherStack.Backend.Application.Abstractions.Persistence.Repositories;
using AetherStack.Backend.Domain.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace AetherStack.Backend.Persistence.Main.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UserManager<User> _userManager;

        public UserRepository(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IList<User>> GetAllUsersAsync(CancellationToken cancellationToken = default)
        {
            return await _userManager.Users
                                     .AsNoTracking()
                                     .ToListAsync(cancellationToken);
        }
    }
}
