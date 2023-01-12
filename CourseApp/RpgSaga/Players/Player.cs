namespace CourseApp.RpgSaga.Players;

using System.Collections.Generic;
using System.Linq;
using CourseApp.RpgSaga.States;
using CourseApp.RpgSaga.Powers;

public abstract class Player
{
    public Player(string name, int strength, int health)
    {
        Name = name;
        Strength = strength;
        Health = health;

        NormalState = new Normal(Strength, Health);
    }

    public string Name { get; set; }

    public int Strength { get; set; }

    public int Health { get; set; }

    public IPower Power { get; set; }

    public List<IState> MyStates { get; set; } = new List<IState>();

    public IState NormalState { get; set; }

    public string ClassName { get; set; }

    public void TakingDamage(int damage)
    {
        Health -= damage;
    }

    public void AttackEnemy(Player enemy)
    {
        enemy.TakingDamage(Strength);
    }

    public bool CanUltimate()
    {
        return Power.CanSpell();
    }

    public void Ultimate(Player myself, Player enemy, int round)
    {
        Power.Spell(myself, enemy, round);
    }

    public void State(Player myself)
    {
        if (MyStates.Count != 0)
        {
            foreach (var effect in MyStates)
            {
                effect.State(myself);
            }
        }
    }

    public void DeleteState(Player myself, int round, int numberPlayer)
    {
        if (MyStates.Count != 0)
        {
            foreach (var state in MyStates.ToList())
            {
                state.DeleteState(myself, round, numberPlayer);
            }
        }
    }

    public void RestoreAfterBattle()
    {
        if (NormalState is Normal normal)
        {
            Health = normal.Health;
            Strength = normal.Strength;
        }

        Power.UsedCount = 0;

        MyStates.Clear();
    }
}