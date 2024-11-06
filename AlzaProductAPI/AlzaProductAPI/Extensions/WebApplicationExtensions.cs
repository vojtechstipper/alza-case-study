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
}
