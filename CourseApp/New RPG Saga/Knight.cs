using System.Xml.Linq;

namespace CourseApp.RPG_Saga
{
    public class Knight : Players
    {
        public Knight(string name)
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

            return $"{Name} рыцарь [{Health}HP]";
        }

        public override int Punch()
        {
            if (Ult == true)
            {
                Logger.WriteLog("Рыцарь взывает к силе своего меча!");
                return (int)(Strength * 1.3);
            }

            return Strength;
        }

        public override void Ultimate()
        {
            Ult = true;
            Punch();
            Ult = false;
        }
    }
}