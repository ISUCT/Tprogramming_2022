namespace CourseApp.Class
{
    using System;

    public class Auto : Transport
    {
        private ActionTypes actionType;

        public Auto()
            : this(0, 0, 0, 0, 0, "Auto")
        {
        }

        public Auto(double length, double height, int weight, int power, int maxSpeed, string model)
            : base(length, height, weight, power, maxSpeed, model)
        {
        }

        public override string ToString()
        {
            return $"Auto {Model}";
        }

        public override ActionTypes Movement()
        {
            actionType = ActionTypes.Move;
            Console.WriteLine($"{Model} is moving at a speed {Speed}km/h");
            return actionType;
        }

        public ActionTypes Beep()
        {
            actionType = ActionTypes.BEep;
            Console.WriteLine("Beep");
            return actionType;
        }
    }
}
