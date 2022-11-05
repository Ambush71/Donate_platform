using Donate.Application.Common.Exceptions;
using Donate.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Donate.Application.Donates.Commands.CreateDonate;

public class UpdateDonateCommandHandler:IRequestHandler<UpdateDonateCommand>
{
    private readonly IDonateDbContext _dbContext;

    public UpdateDonateCommandHandler(IDonateDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Unit> Handle(UpdateDonateCommand request, CancellationToken cancellationToken)
    {
        var entity = await _dbContext.Donates.
            FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
        if (entity is null || entity.UserId != request.UserId)
        {
            throw new NotFoundException(nameof(Donate), request.Id);
        }

        entity.Preposition = request.Preposition;
        entity.Title = request.Title;
        entity.Destination = request.Where;
        entity.GoalSum = request.GoalSum;
        entity.EditDate = DateTime.Now;

        await _dbContext.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}