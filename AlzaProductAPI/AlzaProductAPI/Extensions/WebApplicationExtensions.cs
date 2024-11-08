using AlzaProduct.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace AlzaProductAPI.Extensions;

public static class WebApplicationExtensions
{
    public static WebApplication MigrateDatabase(this WebApplication app)
    {
        using (var scope = app.Services.CreateScope())
            scope.ServiceProvider.GetRequiredService<AlzaDbContext>()?.Database.Migrate();

        return app;
    }

    public static WebApplication UseDevelopment(this WebApplication app)
    {
        app.UseSwagger();
        app.UseSwaggerUI(c =>
        {
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "Alza Product API - V1");
            c.SwaggerEndpoint("/swagger/v2/swagger.json", "Alza Product API - V2");
        });

        return app;
    }
}
