using Donate.Domain.Entities.Enums;
using MediatR;

namespace Donate.Application.Donates.Commands.UpdateCommand;

public class UpdateDonateCommand : IRequest
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public Supplier Supplier { get; set; }
    public Needs Needs { get; set; }
    public decimal GoalSum { get; set; }
    public Guid UserId { get; set; }
}