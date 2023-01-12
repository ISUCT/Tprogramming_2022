using CourseApp.RpgSaga.Players;

namespace CourseApp.RpgSaga.States;

public class Normal : IState
{
    public Normal(int strength, int health)
    {
        Health = health;
        Strength = strength;
    }

    public int Health { get; set; }

    public int Strength { get; set; }

    public int LastUsed { get; set; }

    public void State(Player myself)
    {
        myself.Strength = Strength;
        myself.Health = Health;
    }

    public void RestoreStrength(Player myself)
    {
        myself.Strength = Strength;
    }

    public void RestoreHealth(Player myself)
    {
        myself.Health = Health;
    }

    public void DeleteState(Player player, int round, int numberPlayer)
    {
        player.MyStates = null;
    }
}