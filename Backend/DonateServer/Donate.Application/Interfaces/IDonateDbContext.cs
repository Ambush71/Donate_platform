using Microsoft.EntityFrameworkCore;

namespace Donate.Application.Interfaces;

public interface IDonateDbContext
{
    DbSet<Domain.Entities.Donate> Donates { get; set; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}