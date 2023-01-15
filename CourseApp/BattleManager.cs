namespace CourseApp
{
    using System.Collections.Generic;

    public class BattleManager
    {
        private List<Entity> players;

        private EntitiesFactory entitiesFactory;

        private ILogger logger;

        public BattleManager(int playerCount, ILogger logger)
        {
            players = new List<Entity>();
            entitiesFactory = new EntitiesFactory();
            this.logger = logger;
            InitPlayers(playerCount);
        }

        public void Battle()
        {
            for (int round = 1; players.Count > 1; round++)
            {
                logger.Log($"Round {round}");
                for (int i = 1; i < players.Count; i++)
                {
                    Duel(players[i - 1], players[i]);
                    logger.Log($"---------");
                }

                RefreshPlayers();
            }
        }

        public void Duel(Entity e1, Entity e2)
        {
            while (e1.Health > 0 && e2.Health > 0)
            {
                DoEntityAction(e1, e2);
                DoEntityAction(e2, e1);
            }
        }

        public void DoEntityAction(Entity src, Entity dest)
        {
            if (src.Health <= 0)
            {
                return;
            }

            dest.AddEffect(src.MakeStep());
            int damage = dest.CheckState();
            logger.Log($"{src.Name} использует {src.ActiveAbility.AbilityName} и наносит {damage} ед. урона");
            if (dest.Health <= 0)
            {
                logger.Log($"{dest.Name} погибает");
                players.Remove(dest);
            }
        }

        public void InitPlayers(int count)
        {
            while (count > 0)
            {
                Entity e = entitiesFactory.CreateEntity();
                players.Add(e);
                count--;
            }
        }

        public void RefreshPlayers()
        {
            foreach (var p in players)
            {
                p.Refresh();
            }
        }
    }
}