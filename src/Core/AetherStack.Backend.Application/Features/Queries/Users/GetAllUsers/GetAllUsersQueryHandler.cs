
using AetherStack.Backend.Application.Abstractions.Persistence.Repositories;
using AetherStack.Backend.Application.Common.Responses;
using AetherStack.Backend.Application.DTOs;
using AetherStack.Backend.Application.SystemMessages;
using MediatR;

namespace AetherStack.Backend.Application.Features.Queries.Users.GetAllUsers
{
    public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQueryRequest, SuccessDetails<List<UserDto>>>
    {
        private readonly IUserRepository _userRepository;

        public GetAllUsersQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<SuccessDetails<List<UserDto>>> Handle(GetAllUsersQueryRequest request, CancellationToken cancellationToken)
        {
            var users = await _userRepository.GetAllUsersAsync(cancellationToken);
           
            var userDtos = users.Select(u => new UserDto
            {
                Id = u.Id,
                UserName = u.UserName!,
                Email = u.Email!,
                FirstName = u.FirstName,
                LastName = u.LastName,
                IsActive = u.IsActive
            }).ToList();

            return ResultResponse.Success(userDtos, Response.Common.OperationSuccess);
        }
    }
}
