using MediatR;

namespace Donate.Application.Donates.Commands.CreateDonate;

public class UpdateDonateCommand:IRequest
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string Title { get; set; }
    public string Preposition { get; set; }
    public string Where { get; set; }
    public decimal GoalSum { get; set; }
    public decimal CurrentSum { get; set; }
}