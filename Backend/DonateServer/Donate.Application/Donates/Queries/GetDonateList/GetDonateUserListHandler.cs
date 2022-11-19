using AutoMapper;
using AutoMapper.QueryableExtensions;
using Donate.Application.Donates.Queries.GetDonate;
using Donate.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Donate.Application.Donates.Queries.GetDonateList;

public class GetDonateUserListHandler : IRequestHandler<GetDonateListQuery, DonateListVm>
{
    private readonly IDonatesDbContext _dbContext;
    private readonly IMapper _mapper;

    public GetDonateUserListHandler(IMapper mapper, IDonatesDbContext dbContext)
    {
        _mapper = mapper;
        _dbContext = dbContext;
    }

    public async Task<DonateListVm> Handle(GetDonateListQuery request, CancellationToken cancellationToken)
    {
        if (request.UserId == Guid.Empty)
        {
            var donatesQuery =
                await _dbContext.Donates
                    .ProjectTo<DonateVm>(_mapper.ConfigurationProvider)
                    .ToListAsync(cancellationToken: cancellationToken);
            return new DonateListVm { Donates = donatesQuery };
        }
        var donatesUserQuery = await _dbContext.Donates
            .Where(d => d.UserId == request.UserId)
            .ProjectTo<DonateVm>(_mapper.ConfigurationProvider)
            .ToListAsync(cancellationToken);
        return new DonateListVm { Donates = donatesUserQuery };
    }
}