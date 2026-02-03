# CarsListWeb (ASP.NET MVC Core 8.0) — Codex starter file

## What we build
Create a web app called **CarsListWeb** using **ASP.NET MVC Core 8**.  
The app displays a list of cars (Model, Year, MinPrice, MaxPrice) loaded from a packaged JSON file inside the project.

## Example data
JSON format (root object contains `Repositories` array):

```json
{
  "Repositories": [
    { "Model": "Mazda",  "Year": 2020, "MinPrice": 20000, "MaxPrice": 30000 },
    { "Model": "Toyota", "Year": 2019, "MinPrice": 18000, "MaxPrice": 25000 },
    { "Model": "Honda",  "Year": 2021, "MinPrice": 22000, "MaxPrice": 32000 }
  ]
}
'''

## Unit tests (IMPORTANT)

- All unit tests MUST be created in a dedicated test project, not inside the production app project.
- Test project location: `Tests/CarLists.Tests/`
- Framework: xUnit
- Do NOT add xUnit packages to the production project.
- Do NOT create any `Program.cs` / entry point in test code.
