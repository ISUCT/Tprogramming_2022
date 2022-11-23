namespace CourseApp.RPGSaga
{
    public class Wizard : Player
    {
        public Wizard(string name)
        {
           Name = name;
           Invisible = false;
        }

        public bool Invisible { get; set; }

        public override string ToString()
        {
            return $"(Маг) {Name}";
        }

        public override void Ultimate()
        {
            Invisible = true;
        }

        public override int GiveDamage()
        {
                return Strength;
        }

        public override void GetDamage(int damage)
        {
            if (Invisible == false)
            {
                Health -= damage;
            }
            else
            {
                Invisible = false;
                Logger.WriteLog($"{ToString()} использует неуязвимость!");
            }
        }
    }
}
