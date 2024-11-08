using AlzaProductAPI.Extensions;
using AlzaProduct.Application;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddRepositories();
builder.Services.AddApplicationServices();
builder.Services.AddControllers();

var app = builder.Build();

app.MigrateDatabase();
app.MapControllers();

app.Run();
