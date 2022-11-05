using MediatR;

namespace Donate.Application.Donates.Commands.DeleteCommand;

public class DeleteDonateCommand:IRequest
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
}