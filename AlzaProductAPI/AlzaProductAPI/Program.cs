using AlzaProductAPI.Extensions;
using AlzaProduct.Application;
using AlzaProductAPI.Middlewares;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddExceptionHandler<ExceptionHandler>();
builder.Services.AddProblemDetails();
builder.Services.AddRepositories();
builder.Services.AddApplicationServices();
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
builder.Services.ConfigureSwaggerGen(options =>
{
    options.CustomSchemaIds(x => x.FullName);
});

var app = builder.Build();
app.UseExceptionHandler();
app.MigrateDatabase();
app.MapControllers();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.Run();
