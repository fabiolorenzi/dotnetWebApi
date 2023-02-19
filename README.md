To install NuGet Packages:

dotnet add package {PACKAGENAME} --version {VERSION}


Installed packages

Microsoft.EntityFrameworkCore 7.0.3
Microsoft.EntityFrameworkCore.Tools
Pomelo.EntityFrameworkCore.MySql


To create db and tables:

dotnet tool install --global dotnet-ef --version 6.*
dotnet ef migrations add {NAMEMIGRATIONS}
dotnet ef database update


To create a migration:

dotnet ef migrations add {NAMEMIGRATIONS}
dotnet ef database update