using Donate.Application.Donates.Queries.GetDonate;
using FluentValidation;

namespace Donate.Application.Users.Queries.GetUser;

public class GetUserQueryValidator : AbstractValidator<GetDonateQuery>
{
    public GetUserQueryValidator()
    {
        RuleFor(d => d.Id).NotEqual(Guid.Empty);
    }
}