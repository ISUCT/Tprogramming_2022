namespace AutoApp
{
    public class Auto
    {
        private int speed;

        public Auto()
            : this("Car", 45, 80)
        {
        }

        public Auto(string name, int speed, int weight)
        {
            Name = name;
            Speed = speed;
            LoadingCapacity = weight;
        }

        public string Name { get; set; }

        public int LoadingCapacity { get; set; }

        public int Speed
        {
            get
            {
                return speed;
            }

            set
            {
                if (value > 0)
                {
                    this.speed = value;
                }
            }
        }

        public string Ride()
        {
            return $"Поехал автомобиль {Speed}";
        }

        public string Stop()
        {
            return "Остановился автомобиль";
        }

        public string Print()
        {
            return $"Название: {Name}  Скорость: {speed}";
        }
    }
}
