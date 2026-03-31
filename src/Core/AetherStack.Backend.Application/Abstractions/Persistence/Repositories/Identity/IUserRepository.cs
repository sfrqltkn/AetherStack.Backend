using AetherStack.Backend.Domain.Identity;

namespace AetherStack.Backend.Application.Abstractions.Persistence.Repositories.Identity
{
    public interface IUserRepository
    {
        Task<IList<User>> GetAllUsersAsync(CancellationToken cancellationToken = default);
    }
}
