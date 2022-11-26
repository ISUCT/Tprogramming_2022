namespace CourseApp
{
    using System;
    using System.Collections.Generic;

    public class players
    {
        private readonly Random random = new Random();
        private List<string> Archive = new List<string>()
        {
         "Артур", "Кристофер", "Антон", "Диана", "Виктория", "Степан", "Зерко", "Мариэлла", "Виктор", "Зашеир", "Хасеир",
        "Малдор", "Корси", "Ева", "Нарри", "Рис", "Эльза", "Александр", "Михаил", "Иван", "Марк","Гром", "Петр", "Мрамор",
        "Салко", "Верш", "Пир", "Арнольд", "Эдик", "Егор", "Грек", "Святик",
        };

        private List<Player> host = new List<Player>();

        public List<Player> AddAtList(int players)
        {
            while (host.Count < players)
            {
                switch (random.Next(0, 3))
                {
                    case 0:
                        host.Add(new Archer(Archive[random.Next(0, 20)], random.Next(100, 130), random.Next(10, 20)));
                        break;
                    case 1:
                        host.Add(new Cavalier(Archive[random.Next(0, 20)], random.Next(100, 130), random.Next(10, 20)));
                        break;
                    case 2:
                        host.Add(new Magician(Archive[random.Next(0, 20)], random.Next(100, 130), random.Next(10, 20)));
                        break;
                }
            }

            return host;
        }
    }
}