namespace CourseApp.RPGsaga

using System;
using System.Collections.Generic;
using System.Linq;

public class Game
{
    public void Start()
    {
        Console.WriteLine("Введите количество игроков (число должно быть чётным):");
        int players = Convert.ToInt32(Console.ReadLine());
        if (players <= 1)
        {
            Console.WriteLine("Число игроков не может быть меньше 2");
        }
        else if (players % 2 != 0)
        {
            Console.WriteLine("Число игроков должно быть чётным!");
        }

        List<Player> playerList = PlayerListGenerator(players);
    }

    private static void Round(List<Player> playerList)
     {
        for (int i = 0; i < playerList.Count / 2; i++)
        {
            Player[] Members = { playerList[i * 2], playerList[(i * 2) + 1] };

            for (int i = 0; ; i++)
            {

            }

            for (int i = 1; i < playerList.Count; i++)
            {
                playerList.RemoveAt(i);
            }
        }
     }

    private static List<Player> PlayerListGenerator(int counter)
    {
        List<Player> playerList = new List<Player>();
        for (int i = 0; i < counter; i++)
        {
            playerList.Add(PlayerGenerator());
        }

        return playerList;
    }

    private static Player PlayerGenerator()
    {
        string[] names = { "Даламар", "Володар", "Геральд", "Вельгеброрд", "Глэстин", "Винхелт", "Грендольф", "Рэйкон", "Шапалаум", "Зорро", "Кьярос", "Йотенхел", "Кузко" };
        Random rnd = new Random();
        int health = (int)rnd.NextInt64(1, 100);
        int force = (int)rnd.NextInt64(1, 100);
        int chouse = (int)rnd.NextInt64(0, 3);
        switch (chouse)
        {
            case 0:
                return new Paladin(health, force, names[rnd.Next(names.Length)]);
            case 1:
                return new Wizard(health, force, names[rnd.Next(names.Length)]);
            case 2:
                return new Archer(health, force, names[rnd.Next(names.Length)]);
            default:
                return new Paladin(health, force, names[rnd.Next(names.Length)]);
        }
    }

}