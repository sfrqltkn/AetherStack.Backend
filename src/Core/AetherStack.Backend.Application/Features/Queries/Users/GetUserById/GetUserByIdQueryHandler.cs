using AetherStack.Backend.Application.Abstractions.Infrastructure;
using AetherStack.Backend.Application.Common.Exceptions;
using AetherStack.Backend.Application.Common.Responses;
using AetherStack.Backend.Application.DTOs;
using AetherStack.Backend.Application.SystemMessages;
using MediatR;

namespace AetherStack.Backend.Application.Features.Queries.Users.GetUserById
{
    public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQueryRequest, SuccessDetails<UserDto>>
    {
        private readonly IUserService _userService;

        public GetUserByIdQueryHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<SuccessDetails<UserDto>> Handle(GetUserByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var user = await _userService.FindByIdAsync(request.Id.ToString());

            if (user is null)
                throw new NotFoundException("Kullanıcı bulunamadı.");

            var userDto = new UserDto
            {
                Id = user.Id,
                UserName = user.UserName!,
                Email = user.Email!,
                FirstName = user.FirstName,
                LastName = user.LastName,
                IsActive = user.IsActive
            };

            return ResultResponse.Success(userDto, Response.Common.OperationSuccess);
        }
    }
}
