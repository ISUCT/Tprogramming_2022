using KornilichRpgSage.enums;
using KornilichRpgSage.interfaces;

namespace KornilichRpgSage.entities;

public class Knight : IHero
{
    public int Health { get; set; }
    public int MaxHealth { get; set; }
    public int Power { get; set; }
    public string Name { get; set; }

    public string ClassName { get; set; }

    public EffectEnum Effect { get; set; }

    public bool UseAbility(IHero attacked)
    {
        var random = new Random().Next(10);
        if (random > 7)
        {
            attacked.Health -= (int)(Power * 1.3);
            Console.WriteLine($"{Name} использовал суперспособность удар возмездия и наносит {(int)(Power * 1.3)} урона");
            return true;
        }

        return false;
    }
}