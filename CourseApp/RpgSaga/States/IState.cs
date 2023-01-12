using CourseApp.RpgSaga.Players;

namespace CourseApp.RpgSaga.States;

public interface IState
{
    int LastUsed { get; set; }

    void State(Player player);

    void DeleteState(Player player, int round, int numberPlayer);
}