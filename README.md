# SPENGO
SPENGO is a software of control spents.
## PREREQUESITES
* [.Net Core](https://dotnet.microsoft.com/download)
* [MySql](https://www.mysql.com/)
## CONFIGURING THE PROJECT
1) Install necessary packges:
> Executing the "Restore NuGet Packges" in Visual Studio, or dotnet restore in root directory
2) Add your connection string in SPENGO.API/appsettings.Development.json
3) Execute migrations:
> Executing the "Update-Database" in Visual Studio Package Manager Console, or "ef database update" in command prompt
4) Run the SPENGO.API
## TECNOLOGIES USED
### BACKEND
* Asp .Net Core
* Autofac
* Automapper
* C#
* Entity Framework Core
* Fluent Validator
* MediatR
* .Net Core
* Swagger
## VERSIONS
* 0.1.0 - First Commit
* 0.1.1 - Domain layer now comunic with data layer
* 0.1.2 - API created
* 0.1.3 - IOC statement added
* 0.1.4 - Database Configuration Added
* 0.2.0 - WalletsController Created
* 0.2.1 - Swagger Added
## CONTRIBUITORS
* [**Pedro Octávio**](https://github.com/pedro-octavio) - *desenvolviment of project*
