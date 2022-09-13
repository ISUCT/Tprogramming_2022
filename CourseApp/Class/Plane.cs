namespace CourseApp
{
    public abstract class Plane
    {
        private int numberWings;

        public Plane()
        {
        }

        public Plane(int numberWings)
        {
            this.numberWings = numberWings;
        }

        public abstract void TakeSpeed();

        public abstract void Movement();

        public abstract void GetInfo();
    }
}
