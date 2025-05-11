# Inventory Management API

A .NET Core Web API for managing inventory items, built to demonstrate skills for Tesla's Application Support Analyst role.

## Features
- CRUD operations for inventory items (name, quantity, location).
- SQLite database with Entity Framework Core.
- Input validation for secure endpoints.
- Unit tests with xUnit.

## Setup
1. Install .NET 8 SDK and SQLite.
2. Clone the repo: `git clone https://github.com/yourusername/InventoryApi.git`
3. Run migrations: `dotnet ef database update`
4. Run the app: `dotnet run`

## Technologies
- .NET Core 8
- ASP.NET Core Web API
- Entity Framework Core
- SQLite
- xUnit

## Testing
- Use Postman to test API endpoints.
- Run unit tests: `dotnet test`-