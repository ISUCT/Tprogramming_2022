namespace CourseApp.RPGsaga;

using System;
using System.Collections.Generic;
using System.Linq;

public class Game
{
    public void Play()
    {
        EnterNumberOfPlayers();
        List<Player> playerList = PlayerListGenerator(players);
        List<Player> winnerList = new List<Player>();
        Player winner = new Player();
        Logger.Winner(Round(List<Player> playerList));
    }

    private static void Round(List<Player> playerList)
    {
        for (int i = 0; i < playerList.Count / 2; i++)
        {
            if (playerList.Count == null)
            {
                break;
            }
            Logger.Round(i);
            Player[] Members = { playerList[i * 2], playerList[(i * 2) + 1] };
            Logger.VS(Player[] Members);
            winnerList.Add(Figth(Members));
        }
        for (int i = 1; i < playerList.Count; i++)
        {
            playerList.RemoveAt(i);
        }
        for (int i = 0; i < winnerList.Count / 2; i++)
        {
            if (winerList.Count == 1)
            {
                return winner = winerList[i * 2];
                break;
            }
            Logger.Round(i);
            Player[] Members = { winnerList[i * 2], winnerList[(i * 2) + 1] };
            Logger.VS(Player[] Members);
            winnerList.Add(Figth(Members));
        }
        for (int i = 1; i < winnerList.Count-1; i++)
        {
            winnerList.RemoveAt(i);
        }
    }

     private static Fight(Player[] Members)
    {
        for (int i = 0; ; i++)
        {
            
            Members[(i * 2) + 1].NewHealth(Members[i * 2].Damage());
            Logger.Figth(Members[i * 2].Damage());
            if (Members[(i * 2) + 1].Death())
            {
                Logger.Death(Player[] Members);
                return Members[i * 2];
                break;
            }
            else
            {
                swap = Members[i * 2];
                Members[(i * 2) + 1] = Members[i * 2];
                Members[i * 2] = swap;
            }
        }    
    }

    private static List<Player> PlayerListGenerator(int counter)
    {
        List<Player> playerList = new List<Player>();
        for (int i = 0; i < counter; i++)
        {
             Random rnd = new Random();
            int health = (int)rnd.NextInt64(1, 100);
            int force = (int)rnd.NextInt64(1, 100);
            int chouse = (int)rnd.NextInt64(0, 3);
            string[] names = { "Даламар", "Володар", "Геральд", "Вельгеброрд", "Глэстин", "Винхелт", "Грендольф", "Рэйкон", "Шапалаум", "Зорро", "Кьярос", "Йотенхел", "Кузко" };
            playerList.Add(PlayerGenerator(health, force, chouse, names[rnd.Next(names.Length));
        }

        return playerList;
    }

    private static Player PlayerGenerator(int health, int forceb, int chouse, string name)
    {
        switch (chouse)
        {
            case 0:
                return new Paladin(health, force, name);
            case 1:
                return new Wizard(health, force, name);
            case 2:
                return new Archer(health, force, name);
            default:
                return new Paladin(health, force, name);
        }
    }

    private void EnterNumberOfPlayers()
    {
        Console.WriteLine("Введите количество игроков (число должно быть чётным):");
        int players = Convert.ToInt32(Console.ReadLine());
        if (players <= 1)
        {
            Console.WriteLine("Число игроков не может быть меньше 2");
        }
        else if (players % 2 != 0)
        {
            Console.WriteLine("Число игроков должно быть чётным");
        }
    }
    public int Summa(int a, int b)
        {
            return a+b;
        }
}
