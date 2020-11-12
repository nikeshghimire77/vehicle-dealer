# Vehicle Dealer Application

> This will allow admin to manage the vehicle and user to see the listed vehicles

## General commands

Applying migration and Updating Database

```bash
-- Remove existing database
dotnet ef database drop -p Infrastructure/ -s API/

-- Remove existing migrations
dotnet ef migrations remove -p Infrastructure/ -s API/

-- Apply migrations
dotnet ef migrations add InitialCreate -p Infrastructure/ -s API/ -o Data/Migrations

-- Database update
dotnet ef database update -p Infrastructure/ -s API/
```
