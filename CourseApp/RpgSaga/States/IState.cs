namespace CourseApp.RpgSaga.States;

using CourseApp.RpgSaga.Players;

public interface IState
{
    int LastUsed { get; set; }

    void State(Player player);

    void DeleteState(Player player, int round, int numberPlayer);
}