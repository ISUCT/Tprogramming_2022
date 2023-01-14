using KornilichRpgSage.enums;
using KornilichRpgSage.interfaces;

namespace KornilichRpgSage.entities;

public class Archer : IHero
{
    public int Health { get; set; }
    public int MaxHealth { get; set; }
    public int Power { get; set; }
    public string Name { get; set; }

    public string ClassName { get; set; }

    public EffectEnum Effect { get; set; }

    private bool IsFireArrowsWasUse { get; set; }= false;

    public bool UseAbility(IHero attacked)
    {
        var random = new Random().Next(10);
        if (random > 6 && IsFireArrowsWasUse == false)
        {
            Console.WriteLine($"{Name} использовал суперспособность горящие стрелы");
            attacked.Effect = EffectEnum.Fire;
            IsFireArrowsWasUse = true;
            return true;
        }

        return false;
    }
}