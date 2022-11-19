using Donate.Application.Donates.Queries.GetDonate;
using FluentValidation;

namespace Donate.Application.Donates.Queries.GetDonateList;

public class GetDonateUserListQueryValidator : AbstractValidator<GetDonateQuery>
{
    public GetDonateUserListQueryValidator()
    {
        RuleFor(d => d.Id).NotEqual(Guid.Empty);
        //RuleFor(d => d.UserId).NotEqual(Guid.Empty);
    }
}