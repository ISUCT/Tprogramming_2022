using KornilichRpgSage.enums;

namespace KornilichRpgSage.interfaces;

public interface IHero
{
    public int Health { get; set; }
    public string ClassName { get; set; }
    public int Power { get; set; }
    public string Name { get; set; }
    public int MaxHealth { get; set; }
    public EffectEnum Effect { get; set; }
    bool UseAbility(IHero attacked);
}