using AetherStack.Backend.Application.Abstractions.Infrastructure;
using AetherStack.Backend.Application.Common.Exceptions;
using AetherStack.Backend.Application.Common.Responses;
using AetherStack.Backend.Application.SystemMessages;
using MediatR;

namespace AetherStack.Backend.Application.Features.Commands.Users.DeleteUser
{
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommandRequest, SuccessDetails>
    {
        private readonly IUserService _userService;

        public DeleteUserCommandHandler(IUserService userService)
        {
            _userService = userService;
        }
        public async Task<SuccessDetails> Handle(DeleteUserCommandRequest request, CancellationToken cancellationToken)
        {
            var user = await _userService.FindByIdAsync(request.Id.ToString());
            if (user is null)
                throw new NotFoundException("Silinmek istenen kullanıcı sistemde bulunamadı.");

            var result = await _userService.DeleteAsync(user);

            if (!result.Succeeded)
            {
                var errors = string.Join(" | ", result.Errors.Select(e => e.Description));
                throw new OperationFailedException($"Kullanıcı silinirken hata meydana geldi: {errors}");
            }

            return ResultResponse.Success(Response.Common.OperationSuccess);
        }
    }
}
