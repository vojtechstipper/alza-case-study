using AlzaProduct.Abstractions;
using AlzaProduct.Infrastructure;
using AlzaProduct.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

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

    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        return services;
    }
}
