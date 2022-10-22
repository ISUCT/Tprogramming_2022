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

# Phones Store

Существуют телефоны, которые могут осуществлять голосовой вызов, у них появляются методы - принять вызов, завершить вызов, позвонить. 
Существуют сотовые телефоны, которые могут отправить сообщение, принять сообщение, отправить сообщение, а так сбросить вызов.
Существуют смартфоны (различающиеся операционной системой), определяются диагональю экрана, можно установить и запустить приложение
Все телефоны могут быть представлены в магазине.

Phone:
  Number {get; set;} 
    AcceptCall()
    CloseCall()
    MakeCall(phoneNumber)
  
  CellPhone:
    PlayMusic()
    SendMessage(number, message)
    GetMessage() -> message
    DeclineCall() 
    
    Smarphone
      Diagonal {get; set;}
      OsType {get; set;} 
      ConnectToInternet()
      InstallApp()
      StartApp()
      UninstallApp()

      Iphone14:
        lidar()
      Redmi14:
        Wallet()
      