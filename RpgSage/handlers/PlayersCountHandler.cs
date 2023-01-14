namespace KornilichRpgSage.handlers;

public static class PlayersCountHandler
{
    public static int GetPlayersCount()
    {
        Console.WriteLine("Введите чётное положительное число, степень двойки");
        return Int32.Parse(Console.ReadLine());  // запрашиваем у пользователя число, преобразуем его в целое число и возвращаем
    }
}