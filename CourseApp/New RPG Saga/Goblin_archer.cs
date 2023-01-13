using System.Xml.Linq;

namespace CourseApp.RPG_Saga
{
    public class Goblin_archer : Players
    {
        public Goblin_archer(string name)
            : base(name)
        {
            Name = name;
        }

        public override string ToString()
        {
            if (Health < 0)
            {
                Health = 0;
            }

            return $"{Name} Гоблин-лучник [{Health}HP]";
        }
    }
}
