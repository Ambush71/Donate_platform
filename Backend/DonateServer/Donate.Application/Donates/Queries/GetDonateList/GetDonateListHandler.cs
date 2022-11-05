using AutoMapper;
using AutoMapper.QueryableExtensions;
using Donate.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Donate.Application.Donates.Queries.GetDonateList;

public class GetDonateListHandler:IRequestHandler<GetDonateListQuery,DonateListVm>
{
    private readonly IDonateDbContext _dbContext;
    private readonly IMapper _mapper;

    public GetDonateListHandler(IMapper mapper, IDonateDbContext dbContext)
    {
        _mapper = mapper;
        _dbContext = dbContext;
    }

    public async Task<DonateListVm> Handle(GetDonateListQuery request, CancellationToken cancellationToken)
    {
        var donatesQuery = await _dbContext.Donates
            .Where(d => d.UserId == request.UserId)
            .ProjectTo<DonateLookupDto>(_mapper.ConfigurationProvider).ToListAsync();
        return new DonateListVm { Donates = donatesQuery };
    }
}