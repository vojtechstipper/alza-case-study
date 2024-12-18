using AlzaProduct.Application;
using AlzaProductAPI.Extensions;
using AlzaProductAPI.Middlewares;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddExceptionHandler<ExceptionHandler>();
builder.Services.AddProblemDetails();
builder.Services.AddRepositories();
builder.Services.AddApplicationServices();
builder.Services.AddControllersAndVersioning();
builder.Services.AddAndConfigureSwagger();
builder.Services.AddHttpLogging(x => { });

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDevelopment();
}

app.UseHttpLogging();
app.UseExceptionHandler();
app.MigrateDatabase();
app.MapControllers();
app.Run();
