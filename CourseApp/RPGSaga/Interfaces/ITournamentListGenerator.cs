namespace CourseApp.RPGSaga.Interfaces
{
    using System.Collections.Generic;
    using CourseApp.RPGSaga.Heroes;

    public interface ITournamentListGenerator
    {
        int ListSize { get; set; }

        List<Player> GenerateTournamentList();
    }
}