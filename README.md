# Tprogramming 2021

Master branch :)

`docker volume create --name=mssqldata`

### Adding migrations

To create initial migration in the console please add the following commands. First of all you need to install migration [tools](https://docs.microsoft.com/ru-ru/ef/core/cli/dotnet).

```
dotnet tool install --global dotnet-ef
dotnet tool update --global dotnet-ef
```
Restart you terminal/VScode - and check the following command in terminal.
```
dotnet ef
```

**Note!** If you faced with issues ant the command was not executed - check you environmental variables. For windows in `Path` variable you should be able to see

```
%USERPROFILE%\.dotnet\tools
```

Execute next command strictly in the `WebApplication` folder

```
dotnet add package Microsoft.EntityFrameworkCore.Design
```

Finally you may work with migration (from `WebApplication` folder). The following command will create initial migration.

```
dotnet ef migrations add InitialMigration
```