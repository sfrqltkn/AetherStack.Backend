using AetherStack.Backend.Application.Common.Responses;
using AetherStack.Backend.Application.DTOs.Users;
using MediatR;

namespace AetherStack.Backend.Application.Features.Queries.Users.GetUserById
{
    public class GetUserByIdQueryRequest : IRequest<SuccessDetails<UserDto>>
    {
        public int Id { get; set; }
    }
}
