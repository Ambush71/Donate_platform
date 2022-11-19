using FluentValidation;

namespace Donate.Application.Donates.Queries.GetDonate;

public class GetDonateDetailsQueryValidator : AbstractValidator<GetDonateQuery>
{
    public GetDonateDetailsQueryValidator()
    {
        RuleFor(d => d.Id).NotEqual(Guid.Empty);
        RuleFor(d => d.UserId).NotEqual(Guid.Empty);
    }
}