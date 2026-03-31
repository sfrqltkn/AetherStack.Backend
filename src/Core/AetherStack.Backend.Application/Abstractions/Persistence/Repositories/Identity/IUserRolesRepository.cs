using AetherStack.Backend.Application.DTOs.UserRoles;

namespace AetherStack.Backend.Application.Abstractions.Persistence.Repositories.Identity
{
    public interface IUserRolesRepository
    {
        Task<IList<UserRolesDto>> GetAllUserRolesAsync(CancellationToken cancellationToken = default);
    }
}
