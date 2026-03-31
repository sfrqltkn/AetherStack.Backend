using AetherStack.Backend.Application.Abstractions.Infrastructure;
using AetherStack.Backend.Application.Common.Exceptions;
using AetherStack.Backend.Application.Common.Responses;
using AetherStack.Backend.Application.DTOs;
using AetherStack.Backend.Application.SystemMessages;
using MediatR;

namespace AetherStack.Backend.Application.Features.Queries.Roles.GetRoleById
{
    public class GetRoleByIdQueryHandler : IRequestHandler<GetRoleByIdQueryRequest, SuccessDetails<RoleDto>>
    {
        private readonly IRoleService _roleService;

        public GetRoleByIdQueryHandler(IRoleService roleService)
        {
            _roleService = roleService;
        }

        public async Task<SuccessDetails<RoleDto>> Handle(GetRoleByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var role = await _roleService.FindByIdAsync(request.Id.ToString());

            if (role is null)
                throw new NotFoundException("Role bulunamadı.");

            var roleDto = new RoleDto { Id = role.Id, Name = role.Name! };

            return ResultResponse.Success(roleDto, Response.Common.OperationSuccess);
        }
    }
}
