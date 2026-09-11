# IdentityHub

A professional authentication and authorization system built with ASP.NET Core 9 and SQL Server.

IdentityHub is a portfolio project focused on building a clean, scalable, and maintainable authentication system using modern .NET technologies and layered architecture.

## 🚀 Tech Stack

- .NET 9
- ASP.NET Core Web API
- Entity Framework Core 9
- SQL Server
- Swagger / OpenAPI
- C#
- Clean Architecture principles
- Dependency Injection

## 🏗️ Project Structure

The solution is organized into separate layers to keep the application maintainable and easy to extend.

```text
IdentityHub
│
├── Api
│   ├── Controllers
│   ├── Program.cs
│   └── Api.csproj
│
├── Application
│   └── Application.csproj
│
├── Domain
│   ├── User.cs
│   └── Domain.csproj
│
└── Infrustructure
    ├── Configuration
    ├── Migrations
    └── Infrustructure.csproj
