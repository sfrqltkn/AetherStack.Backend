using AetherStack.Backend.Application.Common.Responses;
using AetherStack.Backend.Application.DTOs.Auth;
using MediatR;

namespace AetherStack.Backend.Application.Features.Commands.Auth.Login
{
    public class LoginCommandRequest : IRequest<SuccessDetails<LoginResponseDto>>
    {
        public string EmailOrUsername { get; set; } = null!;
        public string Password { get; set; } = null!;

    }
}
