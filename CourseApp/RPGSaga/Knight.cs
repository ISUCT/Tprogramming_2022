namespace CourseApp.RPGSaga
{
    using System;

    public class Knight : Player
    {
        private bool ult = false;

        public Knight(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"(Рыцарь) {Name}";
        }

        public override void Ultimate()
        {
            ult = true;
        }

        public override int GiveDamage()
        {
            if (ult == false)
            {
                return Strength;
            }
            else
            {
                ult = false;
                return (int)Math.Round(Strength * 1.3);
            }
        }
    }
}
