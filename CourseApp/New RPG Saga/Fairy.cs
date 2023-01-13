using System.Xml.Linq;

namespace CourseApp.RPG_Saga
{
    public class Fairy : Players
    {
        public Fairy(string name)
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

            return $"{Name} феечка [{Health}HP]";
        }
    }
}
