namespace Vehicles
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Plane : Vehicle
    {
        private int height;

        public Plane()
        {
            Name = "Boing737";
            Speed = 800;
            Height = 8000;
        }

        public Plane(string name, int speed, int height)
        {
            Name = name;
            Speed = speed;
            Height = height;
        }

        public int Height
        {
            get
            {
                return height;
            }

            set
            {
                if (value >= 0 && value < 12000)
                {
                    height = value;
                }
                else
                {
                    height = 10000;
                }
            }
        }

        public override string Display()
        {
            return $"Название самолёта {Name}, скорость {Speed}, высота полёта {Height}";
        }

        public void Land()
        {
            this.Height = 0;
            Console.WriteLine("Самолёт {0} призелился, его высота {1}", Name, Height);
        }
    }
}