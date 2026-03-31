using AetherStack.Backend.Application.Common.Responses;
using AetherStack.Backend.Application.DTOs.UserRoles;
using MediatR;

namespace AetherStack.Backend.Application.Features.Queries.UserRoles.GetAllUserRoles
{
    public class GetAllUserRolesQueryRequest : IRequest<SuccessDetails<List<UserRolesDto>>>
    {
    }
}
