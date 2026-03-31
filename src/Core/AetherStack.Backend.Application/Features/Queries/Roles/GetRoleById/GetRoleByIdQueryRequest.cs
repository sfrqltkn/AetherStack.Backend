using AetherStack.Backend.Application.Common.Responses;
using AetherStack.Backend.Application.DTOs.Roles;
using MediatR;

namespace AetherStack.Backend.Application.Features.Queries.Roles.GetRoleById
{
    public class GetRoleByIdQueryRequest : IRequest<SuccessDetails<RoleDto>>
    {
        public int Id { get; set; }
    }
}
