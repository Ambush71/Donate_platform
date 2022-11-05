using AutoMapper;
using Donate.Application.Common.Exceptions;
using Donate.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Donate.Application.Donates.Queries;

public class GetDonateQueryHandler : IRequestHandler<GetDonateDetailsQuery, DonateDetailsVm>
{
    private readonly IDonateDbContext _dbContext;
    private readonly IMapper _mapper;

    public GetDonateQueryHandler(IDonateDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task<DonateDetailsVm> Handle(GetDonateDetailsQuery request, CancellationToken cancellationToken)
    {
        var entity = await _dbContext.Donates.FirstOrDefaultAsync(d => d.Id == request.Id, cancellationToken);
        if (entity is null || entity.UserId != request.UserId)
        {
            throw new NotFoundException(nameof(Donate), request.Id);
        }

        return _mapper.Map<DonateDetailsVm>(entity);
    }
}