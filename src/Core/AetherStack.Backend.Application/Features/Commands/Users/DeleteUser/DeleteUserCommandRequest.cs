using AetherStack.Backend.Application.Common.Responses;
using MediatR;

namespace AetherStack.Backend.Application.Features.Commands.Users.DeleteUser
{
    public class DeleteUserCommandRequest : IRequest<SuccessDetails>
    {
        public int Id { get; set; }
    }
}
