# Inventory Management API

A .NET Core Web API for managing inventory items, built to demonstrate skills in C#, SQL, and secure coding for Tesla's Application Support Analyst role.

## Features
- CRUD operations for inventory items (name, quantity, location).
- Secure input validation to ensure data integrity.
- SQLite database with Entity Framework Core for persistence.
- Unit tests with xUnit for reliability.
- Comprehensive API documentation in `docs/api.md`.

## Technologies
- .NET Core 8
- C#
- ASP.NET Core
- Entity Framework Core
- SQLite
- xUnit
- Git
- Postman

## Setup
1. Install .NET 8 SDK and SQLite.
2. Clone the repo: `git clone https://github.com/yourusername/InventoryApi.git`
3. Navigate to project: `cd InventoryApi/InventoryApi`
4. Run migrations: `dotnet ef database update`
5. Start the API: `dotnet run`

## Testing
- Test endpoints with Postman (e.g., `http://localhost:5027/api/Items`).
- Run unit tests: `dotnet test` in `InventoryApi.Tests`.

## Documentation
- API details in `docs/api.md`.