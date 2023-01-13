namespace CourseApp
{
  using System;
  using System.Collections.Generic;

  public static class Logger
  {
    public static void WriteWinner(Player winner)
    {
      Console.WriteLine($"{winner.ToString()} WIN!");
    }

    public static void WriteRound(int round)
    {
      Console.WriteLine($"ROUND {round}.");
    }

    public static void WriteFight(Player[] fightMembers)
    {
      Console.WriteLine($"{fightMembers[0].ToString()} (HP {fightMembers[0].MaxHealth}, Attack {fightMembers[0].Strength}) VS {fightMembers[1].ToString()} (HP {fightMembers[1].MaxHealth}, Attack {fightMembers[1].Strength}) ");
    }

    public static void WriteAction(Player firstP, Player secondP, Tuple<string, float> playerAction)
    {
      switch (playerAction.Item1)
      {
        case "deals damage":
          Console.WriteLine($"{firstP.ToString()} (HP {firstP.CurrentHealth}) deals damage {playerAction.Item2} to the enemy {secondP.ToString()}");
          break;
        case "Wrath of Holy Hammer":
          Console.WriteLine($"{firstP.ToString()} (HP {firstP.CurrentHealth}) applies ({playerAction.Item1}) and deals damage {playerAction.Item2} to the enemy {secondP.ToString()}");
          break;
        case "Poison Arrow":
          Console.WriteLine($"{firstP.ToString()} (HP {firstP.CurrentHealth}) applies ({playerAction.Item1}) by the enemy {secondP.ToString()}");
          break;
        case "Spell of Delusion":
          Console.WriteLine($"{firstP.ToString()} (HP {firstP.CurrentHealth}) applies ({playerAction.Item1}) by the enemy {secondP.ToString()}");
          break;
      }
    }

    public static void WriteAction(Player inputP, List<Tuple<string, float>> playerStatus)
    {
      foreach (var debaff in playerStatus)
      {
        switch (debaff.Item1)
        {
          case "Poison Arrow":
            Console.WriteLine($"{inputP.ToString()} (HP {inputP.CurrentHealth}) takes periodic damage {debaff.Item2} from ({debaff.Item1})");
            break;
          case "Spell of Delusion":
            Console.WriteLine($"{inputP.ToString()} (HP {inputP.CurrentHealth}) skips a move due to ({debaff.Item1})");
            break;
          case "PlayerIsDied":
            Console.WriteLine($"{inputP.ToString()} (HP {inputP.CurrentHealth}) died");
            Console.WriteLine();
            break;
        }
      }
    }

    public static void WriteDeath(Player inputP)
    {
      Console.WriteLine($"{inputP.ToString()} DIED");
      Console.WriteLine();
    }

    public static void WriteAction(Player inputP, Tuple<string, float> playerAction)
    {
      Console.WriteLine($"{inputP.ToString()} (HP {inputP.CurrentHealth}) applies ({playerAction.Item1}) and restored to myself {playerAction.Item2} HP");
    }
  }
}