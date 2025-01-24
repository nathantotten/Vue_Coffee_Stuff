The following is taking from this [MS Learn](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-9.0&tabs=visual-studio-code) page

# Get set up for Scaffolding
```bash

dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet tool uninstall -g dotnet-aspnet-codegenerator
dotnet tool install -g dotnet-aspnet-codegenerator
dotnet tool update -g dotnet-aspnet-codegenerator
```
will add the required nuget packages for code-gen wizardry.

# Controller scaffolding
```bash
  dotnet aspnet-codegenerator controller -name < controller name > -async -api -m < model name > -dc < Db context name > -outDir < folder relative to project root >
```
Where:
- controller name is the name of the controller, and it will auto search for anything ending in Controller.cs
- model name is the model to base the Db table off of and add to context.
- Db context name is the ...Context.cs that you made or it will make one using the model.
- for --outDir specify the folder relative to the top level of the project. So I might want  
  a folder called /Controllers/CoffeeMachines that stores the scaffolded controller

Example Usage:
```bash
  dotnet aspnet-codegenerator controller -name CoffeeMachinesController -async -api -m CoffeeMachine -dc CoffeeApiContext -outDir Controllers/CoffeeMachines
```

The generated code:

- Marks the class with the [ApiController] attribute. This attribute indicates that the controller responds to web API requests.   
For information about specific behaviors that the attribute enables, see Create web APIs with ASP.NET Core.  
- Uses DI to inject the database context (TodoContext) into the controller. The database context is used in each of the CRUD methods in the controller.

# Remove shit from repo
`git rm -r --cached < thing you want gone >`

