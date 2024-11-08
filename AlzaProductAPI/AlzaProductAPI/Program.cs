using AlzaProductAPI.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddRepositories();

var app = builder.Build();

app.MigrateDatabase();

app.Run();
