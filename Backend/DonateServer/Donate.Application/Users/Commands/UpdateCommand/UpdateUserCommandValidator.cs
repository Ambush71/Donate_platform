using FluentValidation;

namespace Donate.Application.Donates.Commands.UpdateCommand;

public class UpdateDonateCommandValidator : AbstractValidator<UpdateDonateCommand>
{
    public UpdateDonateCommandValidator()
    {
        RuleFor(c => c.Title).NotEmpty().MaximumLength(250);
        RuleFor(c => c.Needs).NotEmpty();
        RuleFor(c => c.Supplier).NotEmpty();
        RuleFor(c => c.GoalSum).NotEmpty();
        RuleFor(c => c.UserId).NotEqual(Guid.Empty);
        RuleFor(c => c.Id).NotEqual(Guid.Empty);
    }
}