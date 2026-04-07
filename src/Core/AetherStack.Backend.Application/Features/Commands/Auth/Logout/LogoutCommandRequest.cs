using AetherStack.Backend.Application.Common.Responses;
using MediatR;

namespace AetherStack.Backend.Application.Features.Commands.Auth.Logout
{
    public class LogoutCommandRequest : IRequest<SuccessDetails>
    {
        public int UserId { get; set; }
    }
}
