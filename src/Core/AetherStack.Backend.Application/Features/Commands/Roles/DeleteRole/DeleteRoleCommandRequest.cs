using AetherStack.Backend.Application.Common.Responses;
using MediatR;

namespace AetherStack.Backend.Application.Features.Commands.Roles.DeleteRole
{
    public class DeleteRoleCommandRequest : IRequest<SuccessDetails>
    {
        public int Id { get; set; }
    }
}
