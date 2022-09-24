namespace CourseApp
{
    using System;

    public class Phone
    {
        private float diaonal;

        public Phone(): this("Untitled", 0)
        {
            Console.WriteLine("Default Phone Constructor");
        }

        public Phone(string name, float diagonal)
        {
            Console.WriteLine("Phone Constructor with Parameters");
            Name = name;
            Diagonal = diagonal;
        }

        public string Name { get; set; }

        public float Diagonal
        {
            get
            {
                return diaonal;
            }

            set
            {
                if (value > 0 && value < 20)
                {
                    this.diaonal = value;
                }
            }
        }

        public virtual string GetDisplay()
        {
            return $"Phone {Name}";
        }
    }
}