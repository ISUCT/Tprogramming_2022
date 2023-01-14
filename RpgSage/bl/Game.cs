using KornilichRpgSage.factory;
using KornilichRpgSage.handlers;

namespace KornilichRpgSage;

public class Game
{
    public void Start()
    {
        var playersCount = PlayersCountHandler.GetPlayersCount();
        var players = HeroesFactory.GenerateHeroes(playersCount); // генерируем список игроков

        for (var i = 0; i < (int)Math.Log2(playersCount); i++) // по формуле мы считаем количество раундов
        {
            Console.WriteLine($"НАЧАЛСЯ РАУНД {i + 1}");
            Console.WriteLine("----------------------");
            players = Fight.Round(players); // здесь происходит ранунд у бойцов
            Console.WriteLine("----------------------");
        }
    }
}
