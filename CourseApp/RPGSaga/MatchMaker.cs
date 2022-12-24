namespace RPGSaga
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class MatchMaker
    {
        public MatchMaker()
        {
            var multiplyheros = new MultiplyChars();
            heros = multiplyheros.CreateN(N);
        }
        private int N = 4;
        List<Player> heros;
        public void Match()
        {
            for (int i = 1; i <= N; i += 2)
            {
                heros[i].Greetings();
                heros[i + 1].Greetings();
                BattleMaker.Battle(heros[i], heros[i + 1]);
/*              return Battle(heros[i], heros[i + 1]); */
            }
        }
    }
}