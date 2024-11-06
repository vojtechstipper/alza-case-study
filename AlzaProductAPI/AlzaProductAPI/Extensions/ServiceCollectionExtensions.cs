using AlzaProduct.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace AlzaProductAPI.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContextFactory<AlzaDbContext>(
            options => options.UseSqlServer(configuration.GetConnectionString("Database"),
            sqlServerOptionsAction: sqlOptions => sqlOptions.EnableRetryOnFailure().UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery)));

        return services;
    }
}
