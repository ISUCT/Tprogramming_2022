namespace CourseApp
{
  using System;
  using System.Collections.Generic;
  using System.Linq;

  public class Game
  {
    private enum TypePlayer
    {
      Archer,
      Paladin,
      Warlock,
      Shaman,
    }

    public static void Start()
    {
      int number = Members();
      List<Player> playerList = GeneratorPlayerList(number);
      GameProgress(playerList);
    }

    private static void GameProgress(List<Player> playerList)
    {
      for (int i = 1; playerList.Count != 1; i++)
      {
        Logger.WriteRound(i);
        Round(playerList);
      }

      Logger.WriteWinner(playerList[0]);
    }

    private static void Round(List<Player> playerList)
    {
      for (int i = 0; i < playerList.Count / 2; i++)
      {
        Player[] fightMembers = { playerList[i * 2], playerList[(i * 2) + 1] };
        Logger.WriteFight(fightMembers);
        playerList[i * 2] = Fight(fightMembers);
      }

      for (int i = 1; i < playerList.Count; i++)
      {
        playerList.RemoveAt(i);
      }
    }

    private static Player Fight(Player[] fightMembers)
    {
      for (int i = 0; true; i++)
      {
        var playerStatus = fightMembers[i % 2].CheckStatus();
        Logger.WriteAction(fightMembers[i % 2], playerStatus);
        bool checkDeath = fightMembers[i % 2].CheckDeath();
        if (checkDeath)
        {
          fightMembers[(i + 1) % 2].Update();
          return fightMembers[(i + 1) % 2];
        }

        if (playerStatus.Contains(Tuple.Create("Spell of Delusion", .0f)))
        {
          continue;
        }

        Tuple<string, float> playerAction = RandomAction(fightMembers[i % 2]);
        Logger.WriteAction(fightMembers[i % 2], fightMembers[(i + 1) % 2], playerAction);
        if (playerAction.Item1 != "deals damage")
        {
          if (playerAction.Item1 == "Divine Healing")
          {
            Logger.WriteAction(fightMembers[i % 2], playerAction);
          }
          else
          {
            fightMembers[(i + 1) % 2].SetDebaff(playerAction.Item1);
          }
        }

        checkDeath = fightMembers[(i + 1) % 2].GetDamage(playerAction.Item2);
        if (checkDeath)
        {
          Logger.WriteDeath(fightMembers[(i + 1) % 2]);
          fightMembers[i % 2].Update();
          return fightMembers[i % 2];
        }
      }
    }

    private static Tuple<string, float> RandomAction(Player inputP)
    {
      Random rnd = new Random();
      int chosen = rnd.Next(0, 4);
      switch (chosen)
      {
        case 0:
          return inputP.Ability();
        default:
          return inputP.Attack();
      }
    }

    private static int Members()
    {
      while (true)
      {
        Console.WriteLine("Enter an even number of players:");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number <= 0)
        {
          Console.WriteLine("The number of players must be greater than 0!");
        }
        else if (number % 2 != 0)
        {
          Console.WriteLine("The number of players must be even!");
        }
        else
        {
          return number;
        }
      }
    }

    private static List<Player> GeneratorPlayerList(int count)
    {
      List<Player> playerList = new List<Player>();
      for (int i = 0; i < count; i++)
      {
        playerList.Add(GenerationPlayers());
      }

      return playerList;
    }

    private static Player GenerationPlayers()
    {
      List<Player> members = new List<Player>();
      Random rnd = new Random();
      List<string> nameplayers = new List<string> { "Misaki", "Gozgones", "Mimebat", "Keapir", "Brorup", "Ornoenan", "Gavienus", "Khochoids", "Higashi", "Strogek", "Amriel", "Gulheim", "Ibota", "Urgoz", "Acves", "Gartiapal", "Katrina", "Stoveod" };
      int hp = rnd.Next(80, 101);
      int power = rnd.Next(20, 31);
      string name = nameplayers.ElementAt(rnd.Next(nameplayers.Count));
      switch ((TypePlayer)rnd.Next(0, 4))
      {
        case TypePlayer.Archer:
          return new Archer(hp, power, name);
        case TypePlayer.Paladin:
          return new Paladin(hp, power, name);
        case TypePlayer.Warlock:
          return new Warlock(hp, power, name);
        case TypePlayer.Shaman:
          return new Shaman(hp, power, name);
        default:
          return new Shaman(hp, power, name);
      }
    }
  }
}