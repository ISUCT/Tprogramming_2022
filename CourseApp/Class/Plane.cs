namespace CourseApp
{
    public abstract class Plane
    {
        private int length;
        private int weight;
        private int power;

        public Plane()
        {
        }

        public Plane(int length, int weight, int power)
        {
            this.length = length;
            this.weight = weight;
            this.power = power;
        }

        public abstract int GetSpeed { get; set; }

        public abstract void Movement();

        public abstract string GetInfo();
    }
}
