using Microsoft.EntityFrameworkCore;
namespace Donate.Application.Interfaces;

public interface IDonatesDbContext
{
    DbSet<Domain.Entities.Donate> Donates { get; set; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}