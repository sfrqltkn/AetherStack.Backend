using AetherStack.Backend.Application.Common.Responses;
using MediatR;

namespace AetherStack.Backend.Application.Features.Commands.Auth.ConfirmEmail
{
    public class ConfirmEmailCommandRequest : IRequest<SuccessDetails>
    {
        public int UserId { get; set; }
        public string Token { get; set; } = string.Empty;

    }
}
