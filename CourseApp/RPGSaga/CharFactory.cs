namespace RPGSaga
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class CharFactory
    {
        public Player CreateChar(string type, string name, double maxhealth, double power)
        {
            if (type == "Knight")
            {
                return new Knight(name, maxhealth, power);
            }

            return new Bowman(name, maxhealth, power);
        }
    }
}