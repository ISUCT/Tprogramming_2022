namespace CourseApp
{
    using System;
    using System.Collections.Generic;

    public class Fight
    {
        private readonly Random random = new Random();
        private int One = 0;
        private int Two = 0;

        public Tuple<Player, Player> Play(Player host, Player warrior_rival)
        {
            while ((host.Health > 0) && (warrior_rival.Health > 0))
            {
                if ((random.Next(1, 5) == 1) && (host.Impact == false) && (One != 1))
                {
                    One = 1;
                    host.Impact = true;
                }

                if ((random.Next(1, 5) == 2) && (warrior_rival.Impact == false) && (Two != 2))
                {
                    Two = 2;
                    warrior_rival.Impact = true;
                }

                if ((host.Inactive > 0) && (host.Health > 0))
                {
                    Logger.LoggerOutput($"{host.Name} не может нанести удар и пропускает ход!");
                    host.Inactive--;
                }
                else if (host.Health > 0)
                {
                    warrior_rival.GetDamage(host.AtTheAttack(host, warrior_rival));
                    Logger.LoggerOutput($"{warrior_rival.Name} теряет {host.DamageInfo} хп от удара {host.Name}!");
                }

                if ((warrior_rival.Inactive > 0) && (warrior_rival.Health > 0))
                {
                    Logger.LoggerOutput($"{warrior_rival.Name} не может нанести удар и пропускает ход!");
                    warrior_rival.Inactive--;
                }
                else if (warrior_rival.Health > 0)
                {
                    host.GetDamage(warrior_rival.AtTheAttackRival(host, warrior_rival));
                    Logger.LoggerOutput($"{host.Name} теряет {warrior_rival.DamageInfo} хп от удара {warrior_rival.Name}!");
                }
            }

            One = 0;
            Two = 0;
            return new Tuple<Player, Player>(host, warrior_rival);
        }
    }
}