using KornilichRpgSage.enums;
using KornilichRpgSage.interfaces;

namespace KornilichRpgSage;

public static class Fight
{
    public static List<IHero> Round(List<IHero> players)
    {
        var winners = new List<IHero>();
        while (players.Count > 1)
        {
            var random = new Random();
            var firstPlayer = players[random.Next(players.Count)];
            players.Remove(firstPlayer);
            var secondPlayer = players[random.Next(players.Count)];
            players.Remove(secondPlayer);

            winners.Add(HeroesFight(firstPlayer, secondPlayer)); // добавляем в список победителей
        }
        return winners;
    }

    private static IHero HeroesFight(IHero firstPlayer, IHero secondPlayer)
    {

        // вывод информации о сражение двух героев
        Console.WriteLine("");
        Console.WriteLine($"{firstPlayer.ClassName} {firstPlayer.Name} сражается с {secondPlayer.ClassName} {secondPlayer.Name}");
        Console.WriteLine("");

        IHero attacker = firstPlayer;
        IHero attacked = secondPlayer;
        do
        {
            if (attacker.Effect == EffectEnum.Fire)
            {
                attacker.Health -= 2;
                Console.WriteLine($"{attacker.Name} горит и получает урон 2");
            }

            if (attacker.Effect == EffectEnum.Skip)
            {
                (attacker, attacked) = (attacked, attacker);
                Attack(attacked, attacker);
                attacker.Effect = EffectEnum.None;
            }
            else if (!attacker.UseAbility(attacked))
            {
                Attack(attacker, attacked);
            }

            (attacker, attacked) = (attacked, attacker);

        } while (firstPlayer.Health > 0 && secondPlayer.Health > 0);


        if (firstPlayer.Health <= 0)
        {
            Console.WriteLine($"Победил {firstPlayer.ClassName}  {secondPlayer.Name}");
            Console.WriteLine("");
            secondPlayer.Health = secondPlayer.MaxHealth;
            firstPlayer.Effect = EffectEnum.None;
            return secondPlayer;
        }
        Console.WriteLine("");
        Console.WriteLine($"Победил {firstPlayer.ClassName} {firstPlayer.Name}");
        Console.WriteLine("");
        firstPlayer.Health = firstPlayer.MaxHealth;
        firstPlayer.Effect = EffectEnum.None;
        return firstPlayer;
    }

    private static void Attack(IHero attacker, IHero attacked)
    {
        Console.WriteLine($"{attacker.Name}  ({attacker.Health}) атакует {attacked.Name} ({attacked.Health})");
        attacked.Health -= attacker.Power;
    }
}