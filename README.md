# alza-case-study
Case study for Alza interview

## About the project
- The project uses MSSQL db which can be run via Docker container.
- The db will be automatically migrated and seeded with data after first run.
- CQRS, Mediator pattern
- Repository pattern
- Used ports: http - 5170, https - 7099

### Used nuget packages
- Asp.Versioning.Mvc
- AutoMapper
- FluentValidation.AspNetCore
- Mediator
- Microsoft.EntityFrameworkCore
- Moq
- Swashbuckle.AspNetCore

# Prerequisites
- [Docker](https://www.docker.com/)
- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)

## Setup Docker Container
navigate to folder local-development and run (the connection string for local development is already present in appsettings.Development.json)
```bash
docker compose up
```

# Run API
run the following command in the AlzaProductAPI/AlzaProductAPI project folder
```bash
dotnet run
```
the app should be app and running on http://localhost:5170

# Run Tests
run the following command in the AlzaProductAPI/AlzaProduct.Tests project folder
```bash
dotnet test
```
