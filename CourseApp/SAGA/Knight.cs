namespace CourseApp
{
    using System;

    public class Knight : Player
    {
        private bool powerAtack;

        public Knight(int health, int strength, string name)
            : base(health, strength, name, "Удар возмездия", 1)
            {
                powerAtack = false;
            }

        public override string ToString()
        {
            return "(Рыцарь) " + Name;
        }

        public override float Attack() // если была применена способность сильного удара, то возвращаем усиленный урон
        {
            if (powerAtack)
            {
                powerAtack = false;
                return (float)Math.Round(Strength * 1.3);
            }
            else
            {
                return Strength;
            }
        }

        public override string Ability() // если была применена способность возвращаем название способности и устанавливаем флаг в "истина"
        {
            AbilityLeft--;
            powerAtack = true;
            return AbilityName;
        }
    }
}