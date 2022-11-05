using Donate.Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Donate.Persistence;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration["DbConnection"];
        var dbServerVersion = configuration["serverVersion"];
        services.AddDbContext<DonateDbContext>(o =>
            o.UseMySql(connectionString, new MySqlServerVersion(dbServerVersion)));
        services.AddScoped<IDonateDbContext, DonateDbContext>();
        return services;
    }
}