using Donate.Application.Interfaces;
using MediatR;

namespace Donate.Application.Donates.Commands.CreateCommand;

public class CreateDonateCommandHandler : IRequestHandler<CreateDonateCommand, Guid>
{
    private readonly IDonatesDbContext _dbContext;

    public CreateDonateCommandHandler(IDonatesDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Guid> Handle(CreateDonateCommand request, CancellationToken cancellationToken)
    {
        var donate = new Domain.Entities.Donate
        {
            UserId = request.UserId,
            Title = request.Title,
            Supplier = request.Supplier,
            Needs = request.Needs,
            GoalSum = request.GoalSum,
            Id = Guid.NewGuid(),
            CreateDate = DateTime.Today
        };
        await _dbContext.Donates.AddAsync(donate, cancellationToken);
        await _dbContext.SaveChangesAsync(cancellationToken);
        return donate.Id;
    }
}