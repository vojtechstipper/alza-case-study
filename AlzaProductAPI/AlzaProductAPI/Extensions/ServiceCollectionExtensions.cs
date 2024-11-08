using AlzaProduct.Abstractions;
using AlzaProduct.Domain.Entities.Products;
using AlzaProduct.Infrastructure;
using AlzaProduct.Infrastructure.Repositories;
using Asp.Versioning;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

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
        services.AddScoped<IProductRepository, ProductRepository>();
        return services;
    }

    public static IServiceCollection AddAndConfigureSwagger(this IServiceCollection services)
    {
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "Alza Product API - V1", Version = "v1.0" });
            c.SwaggerDoc("v2", new OpenApiInfo { Title = "Alza Product API - V2", Version = "v2.0" });
        });

        services.ConfigureSwaggerGen(options => options.CustomSchemaIds(x => x.FullName));

        return services;
    }

    public static IServiceCollection AddControllersAndVersioning(this IServiceCollection services)
    {
        services.AddApiVersioning(options =>
        {
            options.DefaultApiVersion = new ApiVersion(1, 0);
            options.AssumeDefaultVersionWhenUnspecified = true;
            options.ReportApiVersions = true;
            options.ApiVersionReader = ApiVersionReader.Combine(
                new UrlSegmentApiVersionReader(),
                new HeaderApiVersionReader("X-Api-Version")
            );
        }).AddApiExplorer(options =>
        {
            options.GroupNameFormat = "'v'VVV";
            options.SubstituteApiVersionInUrl = true;
        });
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        return services;
    }
}
