using KornilichRpgSage.enums;
using KornilichRpgSage.interfaces;

namespace KornilichRpgSage.entities;

public class Mage : IHero
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
            attacked.Effect = EffectEnum.Skip;
            Console.WriteLine($"{Name} использовал суперспособность оглушение");
            return true;
        }
        return false;
    }
}