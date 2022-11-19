using Donate.Application.Common.Exceptions;
using Donate.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Donate.Application.Donates.Commands.DeleteCommand;

public class DeleteDonateCommandHandler : IRequestHandler<DeleteDonateCommand>
{
    private readonly IDonatesDbContext _dbContext;

    public DeleteDonateCommandHandler(IDonatesDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Unit> Handle(DeleteDonateCommand request, CancellationToken cancellationToken)
    {
        var entity = await _dbContext.Donates
            .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
        if (entity is null || entity.UserId != request.UserId) throw new NotFoundException(nameof(Donate), request.Id);

        _dbContext.Donates.Remove(entity);
        await _dbContext.SaveChangesAsync(cancellationToken);
        return Unit.Value;
    }
}