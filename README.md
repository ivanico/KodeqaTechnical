# KodeqaTechnical

# Overview

Build a small C# (.NET Core) microservice for managing the products inventory. The service
should expose the products CRUD (Create-Read-Update-Delete) REST endpoints.
Focus on clean, well-structured code rather than full documentation or exhaustive features.

# Requirements

.NET 10
SQL Server Express

# Setup

1. Restore NuGet packages.
2. Run `ProductsDB.sql` in SQL Server to create database and seed data.
3. Run the project
4. Test it on Swagger: https://localhost:{port}/swagger/index.html or with Postman: https://localhost:{port}/products
