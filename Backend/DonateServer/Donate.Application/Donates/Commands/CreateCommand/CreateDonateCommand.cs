using Donate.Domain.Entities.Enums;
using MediatR;

namespace Donate.Application.Donates.Commands.CreateCommand;

public class CreateDonateCommand : IRequest<Guid>
{
    public string Title { get; set; }
    public Supplier Supplier { get; set; }
    public Needs Needs { get; set; }
    public decimal GoalSum { get; set; }
    public Guid UserId { get; set; }
}