namespace CourseApp.RPGSaga
{
    using System;
    using CourseApp.Class;

    public static class CreatePlayers
    {
        private static Random _random = new ();

        public static PlayerTypes GetHeroType()
        {
                var type = _random.Next(0, 3);
                switch (type)
                {
                    case 0:
                        return PlayerTypes.Knight;
                    case 1:
                        return PlayerTypes.Wizard;
                    case 2:
                        return PlayerTypes.Archer;
                    default:
                        return PlayerTypes.NotType;
                }
        }
    }
}
