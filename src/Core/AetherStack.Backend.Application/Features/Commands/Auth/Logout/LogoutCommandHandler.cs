using AetherStack.Backend.Application.Abstractions.Infrastructure.Token;
using AetherStack.Backend.Application.Abstractions.Presentation;
using AetherStack.Backend.Application.Common.Exceptions;
using AetherStack.Backend.Application.Common.Responses;
using AetherStack.Backend.Application.SystemMessages;
using MediatR;

namespace AetherStack.Backend.Application.Features.Commands.Auth.Logout
{
    public class LogoutCommandHandler : IRequestHandler<LogoutCommandRequest, SuccessDetails>
    {
        private readonly ITokenService _tokenService;
        private readonly IRequestContext _requestContext;

        public LogoutCommandHandler(ITokenService tokenService, IRequestContext requestContext)
        {
            _tokenService = tokenService;
            _requestContext = requestContext;
        }

        public async Task<SuccessDetails> Handle(LogoutCommandRequest request, CancellationToken cancellationToken)
        {
            if (_requestContext.UserId is null)
                throw new UnauthorizedException("Oturum bilgisi bulunamadı.");

            await _tokenService.RevokeAllAsync(_requestContext.UserId.Value);

            return ResultResponse.Success(Response.Common.OperationSuccess);
        }
    }
}
