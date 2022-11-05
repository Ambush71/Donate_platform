using MediatR;

namespace Donate.Application.Donates.Queries.GetDonateList;

public class GetDonateListQuery:IRequest<DonateListVm>
{
    public Guid UserId { get; set; }
}