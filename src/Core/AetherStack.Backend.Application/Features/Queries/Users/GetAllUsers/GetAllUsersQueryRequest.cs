using AetherStack.Backend.Application.Common.Responses;
using AetherStack.Backend.Application.DTOs;
using MediatR;

namespace AetherStack.Backend.Application.Features.Queries.Users.GetAllUsers
{
    public class GetAllUsersQueryRequest : IRequest<SuccessDetails<List<UserDto>>>
    {
    }
}
