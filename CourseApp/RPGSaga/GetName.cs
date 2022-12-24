namespace RPGSaga
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class GetName
    {
        private List<string> namelist = new List<string>() { "Артур", "Ланселот", "Гавейн", "Мерлин", "Арагорн", "Боромир", "Гимли", "Леголас", "Робин" };

        public string RandomName()
        {
            Random r = new Random();
            return namelist[r.Next(0, namelist.Count)];
        }
    }
}
