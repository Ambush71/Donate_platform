using AutoMapper;
using Donate.Application.Interfaces;
using Donate.Application.Users.Queries.GetDonate;
using Donate.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Donate.Application.Users.Queries.GetUser;

public class GetUserQueryHandler : IRequestHandler<GetUserQuery, User>
{
    private readonly IDonatesDbContext _dbContext;
    private readonly IMapper _mapper;

    public GetUserQueryHandler(IDonatesDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task<User> Handle(GetUserQuery request, CancellationToken cancellationToken)
    {
        var user = await _dbContext.Users.FirstOrDefaultAsync(d => d.Id == request.Id);
        return user;
    }
}