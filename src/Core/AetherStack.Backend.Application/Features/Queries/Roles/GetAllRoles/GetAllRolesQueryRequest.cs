using AetherStack.Backend.Application.Common.Responses;
using AetherStack.Backend.Application.DTOs;
using MediatR;

namespace AetherStack.Backend.Application.Features.Queries.Roles.GetAllRoles
{
    public class GetAllRolesQueryRequest : IRequest<SuccessDetails<List<RoleDto>>>
    {
    }
}
