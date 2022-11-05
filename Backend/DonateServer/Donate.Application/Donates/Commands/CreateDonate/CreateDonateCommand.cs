using MediatR;

namespace Donate.Application.Donates.Commands.CreateDonate;

public class CreateDonateCommand:IRequest<Guid>
{
    public Guid UserId { get; set; }
    public string Title { get; set; }
    public string Preposition { get; set; }
    public string Where { get; set; }
    public decimal GoalSum { get; set; }
}