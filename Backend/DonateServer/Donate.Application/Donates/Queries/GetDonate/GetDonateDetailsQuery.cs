using MediatR;

namespace Donate.Application.Donates.Queries;

public class GetDonateDetailsQuery:IRequest<DonateDetailsVm>
{
    public Guid UserId { get; set; }
    public Guid Id { get; set; }
}