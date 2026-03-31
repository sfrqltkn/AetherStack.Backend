using AetherStack.Backend.Domain.Identity;

namespace AetherStack.Backend.Application.Abstractions.Persistence.Repositories.Identity
{
    public interface IRoleRepository
    {
        Task<IList<Role>> GetAllRolesAsync(CancellationToken cancellationToken = default);

    }
}
