namespace CourseApp.RPGSaga
{
    public class Archer : Player
    {
        private bool ult = false;

        public Archer(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"(Лучник) {Name}";
        }

        public override void Ultimate()
        {
            if (ult == true)
            {
                GiveDamage();
            }
            else
            {
                ult = true;
            }
        }

        public override int GiveDamage()
        {
            if (ult == false)
            {
                return Strength;
            }
            else
            {
                return Strength + 2;
            }
        }
    }
}
