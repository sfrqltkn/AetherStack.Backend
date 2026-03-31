using AetherStack.Backend.Application.Common.Responses;
using MediatR;

namespace AetherStack.Backend.Application.Features.Commands.Roles.CreateRole
{
    public class CreateRoleCommandRequest : IRequest<SuccessDetails<int>>
    {
        public string Name { get; set; } = null!;
    }
}
