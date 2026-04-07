using AetherStack.Backend.Application.Common.Responses;
using MediatR;

namespace AetherStack.Backend.Application.Features.Commands.Auth.ResetPassword
{
    public class ResetPasswordCommandRequest : IRequest<SuccessDetails>
    {
        public int UserId { get; set; }
        public string ResetToken { get; set; } = string.Empty;
        public string NewPassword { get; set; } = string.Empty;
        public string ConfirmNewPassword { get; set; } = string.Empty;

    }
}
