using DonateIdentity.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DonateIdentity.Data;

public class AuthDbContext:IdentityDbContext<AppUser>
{
    public AuthDbContext(DbContextOptions options):base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<AppUser>(e => e.ToTable(name:"Users"));
        builder.Entity<IdentityRole>(e => e.ToTable(name: "Roles"));
        builder.Entity<IdentityUserRole<string>>(e => e.ToTable(name: "UserRoles"));
        builder.Entity<IdentityUserClaim<string>>(e => e.ToTable(name: "UserClaim"));
        builder.Entity<IdentityUserLogin<string>>(e => e.ToTable(name: "UserLogins"));
        builder.Entity<IdentityUserToken<string>>(e => e.ToTable(name: "UserTokens"));
        builder.Entity<IdentityRoleClaim<string>>(e => e.ToTable(name: "RoleClaims"));

        builder.ApplyConfiguration(new AppUserConfiguration());
    }
}