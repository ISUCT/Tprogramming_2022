namespace CourseApp
{
    using System;

    public class LandlinePhone : Phone, IDisplayable
    {

        public LandlinePhone() : base("+70000000", "Проводной", 2)
        {
        }

        public LandlinePhone(string number, string name, int diagonal) : base(number, name, diagonal)
        {
        }

        public override string ToString()
        {
            return $"Проводной телефон {Name} номер:{Number}, произведен {Year}";
        }

        public override string Display()
        {
            return this.ToString();
        }

    }
}