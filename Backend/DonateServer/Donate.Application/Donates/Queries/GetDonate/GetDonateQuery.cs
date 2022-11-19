using MediatR;

namespace Donate.Application.Donates.Queries.GetDonate;

public class GetDonateQuery : IRequest<DonateVm>
{
    public Guid UserId { get; set; }
    public Guid Id { get; set; }
}