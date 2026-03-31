using AetherStack.Backend.Application.Common.Responses;
using MediatR;
using System.Text.Json.Serialization;

namespace AetherStack.Backend.Application.Features.Commands.Users.LockUser
{
    public class LockUserCommandRequest : IRequest<SuccessDetails>
    {
        [JsonIgnore]
        public int Id { get; set; }
        public int? DurationInHours { get; set; }
    }
}
