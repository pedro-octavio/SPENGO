# SPENGO
SPENGO is a software of control spents.
## PREREQUESITES
### BACKEND
* [MySql](https://www.mysql.com/)
* [.Net Core](https://dotnet.microsoft.com/download)
### FRONTEND
* [Angular](https://angular.io/)
* [Node.JS](https://nodejs.org/)
* [Yarn](https://yarnpkg.com/)
## CONFIGURING THE PROJECT
### BACKEND
1) Install necessary packges:
> Executing the "Restore NuGet Packges" in Visual Studio, or dotnet restore in prompt command in project "Backend/"
2) Add your connection string in *"Backend/SPENGO.API/appsettings.Development.json"*
3) Execute migrations:
> Executing the "Update-Database" in Visual Studio Package Manager Console, or "ef database update" in command prompt in "Backend/SPENGO.API"
4) Run the *"Backend/SPENGO.API"*
### FRONTEND
1) Install necessary packages:
> Executing the "yarn install" in command prompt in folder "Frontend/"
2) Run project:
> Executing the "ng serve" in command prompt in folder "Frontend/"
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
### FRONTEND
* Angular 10
* Jasmine
* JavaScript
* Node.JS
* Tslint
* TypeScript
## VERSIONS
* 0.1.0 - First Commit
* 0.1.1 - Domain layer now comunic with data layer
* 0.1.2 - API created
* 0.1.3 - IOC statement added
* 0.1.4 - Database Configuration Added
* 0.2.0 - WalletsController Created
* 0.2.1 - Swagger Added
* 0.2.2 - More Swagger Addons
* 0.3.0 - CRUD Actions of Wallet Updated
* 0.3.1 - Data Annotations Changed for Fluent Api
* 0.3.2 - Get Wallets Between Start and End Date, Implemented
* 0.3.3 - Exception Handler Middleware Created
* 0.3.4 - Migrations and Seed Folders Created
* 1.0.0 - Backend Folder Created
* 1.1.0 - Angular Project Created
* 1.1.1 - Wallet Index Created
* 1.2.1 - Wallet Group and Wallet Group Item Created
## CONTRIBUITORS
* [**Pedro Octávio**](https://github.com/pedro-octavio) - *desenvolviment of project*
