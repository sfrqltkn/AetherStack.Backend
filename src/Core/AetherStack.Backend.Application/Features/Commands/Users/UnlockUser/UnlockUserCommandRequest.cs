
using AetherStack.Backend.Application.Common.Responses;
using MediatR;

namespace AetherStack.Backend.Application.Features.Commands.Users.UnlockUser
{
    public class UnlockUserCommandRequest : IRequest<SuccessDetails>
    {
        public int Id { get; set; }
    }
}
