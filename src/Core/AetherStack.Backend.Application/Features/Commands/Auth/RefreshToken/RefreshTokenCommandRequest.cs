using AetherStack.Backend.Application.Common.Responses;
using AetherStack.Backend.Application.DTOs.Auth;
using MediatR;
using System.Text.Json.Serialization;

namespace AetherStack.Backend.Application.Features.Commands.Auth.RefreshToken
{
    public class RefreshTokenCommandRequest : IRequest<SuccessDetails<LoginResponseDto>>
    {
        public string RefreshToken { get; set; } = null!;

        [JsonIgnore]
        public string IpAddress { get; set; } = "N/A";
    }
}
