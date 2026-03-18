using AetherStack.Backend.Application.Common.Responses;
using MediatR;

namespace AetherStack.Backend.Application.Features.Commands.Users.CreateUser
{
    public class CreateUserCommandRequest : IRequest<SuccessDetails<int>>
    {
        public string UserName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
