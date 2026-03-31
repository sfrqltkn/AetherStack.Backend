using AetherStack.Backend.Application.Common.Responses;
using MediatR;

namespace AetherStack.Backend.Application.Features.Commands.UserRoles.AddRoleToUser
{
    public class AddRoleToUserCommandRequest : IRequest<SuccessDetails>
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
    }
}
