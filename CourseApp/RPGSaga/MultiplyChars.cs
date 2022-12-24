namespace RPGSaga
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class MultiplyChars
    {
        private List<Player> heros;

        public List<Player> CreateN(int n)
        {
            heros = new List<Player>();
            var factory = new CharFactory();
            for (int i = 1; i <= n; i++)
            {
                Random r = new Random();
                double maxhealth = r.Next(1, 100);
                double power = r.Next(1, 10);
                var getname = new GetName();
                string name = getname.RandomName();
                heros.Add(factory.CreateChar("Bowman", name, maxhealth, power));
            }

            return heros;
        }
    }
}