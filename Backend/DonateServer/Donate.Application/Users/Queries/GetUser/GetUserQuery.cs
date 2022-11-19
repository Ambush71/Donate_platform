using Donate.Domain.Entities;
using MediatR;

namespace Donate.Application.Users.Queries.GetDonate;

public class GetUserQuery : IRequest<User>
{
    public Guid Id { get; set; }
}