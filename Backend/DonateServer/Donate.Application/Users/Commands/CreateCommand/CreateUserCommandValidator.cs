using Donate.Application.Donates.Commands.CreateCommand;
using FluentValidation;

namespace Donate.Application.Authentication.Commands.CreateCommand;

public class CreateUserCommandValidator : AbstractValidator<CreateDonateCommand>
{
    public CreateUserCommandValidator()
    {
        RuleFor(c => c.Title).NotEmpty().MaximumLength(250);
        RuleFor(c => c.Supplier).NotEmpty();
        RuleFor(c => c.Needs).NotEmpty();
        RuleFor(c => c.GoalSum).NotEmpty();
        //RuleFor(c => c.UserId).NotEqual(Guid.Empty);
    }
}