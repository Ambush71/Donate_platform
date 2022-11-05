using Donate.Application.Interfaces;
using Microsoft.EntityFrameworkCore;
namespace Donate.Persistence;

public class DonateDbContext:DbContext, IDonateDbContext
{
    public DbSet<Domain.Entities.Donate> Donates { get; set; }

    public DonateDbContext(DbContextOptions<DonateDbContext> options):base(options) { }
    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     modelBuilder.ApplyConfiguration(null);
    //
    // }
}