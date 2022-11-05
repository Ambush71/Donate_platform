using Donate.Application.Interfaces;
using MediatR;

namespace Donate.Application.Donates.Commands.CreateDonate;

public class CreateDonateCommandHandler:IRequestHandler<CreateDonateCommand, Guid>
{
    private readonly IDonateDbContext _dbContext;

    public CreateDonateCommandHandler(IDonateDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Guid> Handle(CreateDonateCommand request, CancellationToken cancellationToken)
    {
        var donate = new Domain.Entities.Donate()
        {
            UserId = request.UserId,
            Title = request.Title,
            Preposition = request.Preposition,
            Destination = request.Where,
            GoalSum = request.GoalSum,
            Id = Guid.NewGuid(),
            CreationDate = DateTime.Now,
            EditDate = null
        };
        await _dbContext.Donates.AddAsync(donate, cancellationToken);
        await _dbContext.SaveChangesAsync(cancellationToken);
        return donate.Id;
    }
}