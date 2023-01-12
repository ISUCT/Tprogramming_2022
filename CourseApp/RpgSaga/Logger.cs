namespace CourseApp.RpgSaga;

using System;
using CourseApp.RpgSaga.Players;
using CourseApp.RpgSaga.States;

public class Logger 
{
    public void PrintStart()
    {
        Console.WriteLine("\nПриветствуем в RPG SAGA!");
    }

    public void PrintWrongNumber()
    {
        Console.WriteLine("Неправильное число!");
    }

    public void PrintNumberPlayers()
    {
        Console.WriteLine("Выберите число игроков:");
    }

    public void PrintTour(int numberTour)
    {
        Console.WriteLine($"Кон {numberTour}.\n");
    }

    public void PrintVersus(Player firstPlayer, Player secondPlayer)
    {
        Console.WriteLine($"({firstPlayer.ClassName}) {firstPlayer.Name} vs ({secondPlayer.ClassName}) {secondPlayer.Name}");
    }

    public void PrintAttack(Player playerAttack, Player playerDefend)
    {
        Console.WriteLine($"({playerAttack.ClassName}) {playerAttack.Name} наносит урон {playerAttack.Strength} противнику ({playerDefend.ClassName}) {playerDefend.Name}");
    }

    public void PrintUltimate(Player playerAttack, Player playerDefend)
    {
        if (playerAttack.ClassName == "Маг")
        {
            Console.WriteLine($"({playerAttack.ClassName}) {playerAttack.Name} использует ({playerAttack.Power.Name}) на противника ({playerDefend.ClassName}) {playerDefend.Name}");
        }
        else if (playerAttack.ClassName == "Рыцарь")
        {
            Console.WriteLine($"({playerAttack.ClassName}) {playerAttack.Name} использует ({playerAttack.Power.Name}) и наносит урон {playerAttack.Strength} противнику ({playerDefend.ClassName}) {playerDefend.Name}");
        }
        else if (playerAttack.ClassName == "Лучник")
        {
            Console.WriteLine($"({playerAttack.ClassName}) {playerAttack.Name} использует ({playerAttack.Power.Name}) и поджигает противника ({playerDefend.ClassName}) {playerDefend.Name}");
        }
    }

    public void PrintEffect(Player player)
    {
        foreach (var effect in player.MyStates)
        {
            if (effect is Stun)
            {
                Console.WriteLine($"({player.ClassName}) {player.Name} пропускает ход!");
            }

            if (effect is LongDamage longDamage)
            {
                Console.WriteLine($"({player.ClassName}) {player.Name} получает урон {longDamage.Factor}");
            }
        }
    }

    public void PrintDefeat(Player loser)
    {
        Console.WriteLine($"({loser.ClassName}) {loser.Name} погибает! \n\n");
    }

    public void PrintEnd(Player winner)
    {
        Console.WriteLine($"({winner.ClassName}) {winner.Name} побеждает! \nThe END...");
    }
}