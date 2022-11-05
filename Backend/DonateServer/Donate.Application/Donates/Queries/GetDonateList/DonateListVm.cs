using MediatR;

namespace Donate.Application.Donates.Queries.GetDonateList;

public class DonateListVm
{
    public List<DonateLookupDto> Donates { get; set; }
}