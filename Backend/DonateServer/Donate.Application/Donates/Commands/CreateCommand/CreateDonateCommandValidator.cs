using FluentValidation;

namespace Donate.Application.Donates.Commands.CreateCommand;

public class CreateDonateCommandValidator : AbstractValidator<CreateDonateCommand>
{
    public CreateDonateCommandValidator()
    {
        RuleFor(c => c.Title).NotEmpty().MaximumLength(250);
        RuleFor(c => c.Supplier).NotEmpty();
        RuleFor(c => c.Needs).NotEmpty();
        RuleFor(c => c.GoalSum).NotEmpty();
        //RuleFor(c => c.UserId).NotEqual(Guid.Empty);
    }
}