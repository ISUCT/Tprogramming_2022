namespace Vehicles
{
    using System;

    public class Phone
    {
        private float diagonal;

        public Phone(string name, float diagonal)
        {
            Name = name;
            Diagonal = diagonal;
        }

        public string Name { get; set; }

        public float Diagonal
        {
            get
            {
                return diagonal;
            }

            set
            {
                if (value > 0 && value < 20)
                {
                    this.diagonal = value;
                }
            }
        }

        public void Show()
        {
            Console.WriteLine($"{Name} with diagonal {diagonal}");
        }
    }
}