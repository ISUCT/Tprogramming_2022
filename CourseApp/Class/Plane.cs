namespace CourseApp.Class
{
    using System;

    public class Plane : Transport, ILanding
    {
        private ActionTypes actionType;

        public Plane()
            : this(0, 0, 0, 0, 0, "Plane")
        {
        }

        public Plane(double length, double height, int weight, int power, int maxSpeed, string model)
            : base(length, height, weight, power, maxSpeed, model)
        {
        }

        public string Direction { get; set; }

        public override string ToString()
        {
            return $"Plane {Model}";
        }

        public ActionTypes Takeoff()
        {
            actionType = ActionTypes.TAkeoff;
            Console.WriteLine($"{Model} taking off");
            return actionType;
        }

        public ActionTypes Landing()
        {
            actionType = ActionTypes.LAnding;
            Console.WriteLine($"{Model} going to land");
            return actionType;
        }

        public override ActionTypes Movement()
        {
            actionType = ActionTypes.Move;
            Console.WriteLine($"{Model} is moving at a speed {Speed}km/h in the {Direction}");
            return actionType;
        }
    }
}
