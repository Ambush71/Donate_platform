using FluentValidation;

namespace Donate.Application.Donates.Commands.DeleteCommand;

public class DeleteDonateCommandValidator : AbstractValidator<DeleteDonateCommand>
{
    public DeleteDonateCommandValidator()
    {
        RuleFor(c => c.UserId).NotEqual(Guid.Empty);
        RuleFor(c => c.Id).NotEqual(Guid.Empty);
    }
}