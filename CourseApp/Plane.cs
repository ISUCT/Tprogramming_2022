using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    class Plane //(int speed, int height, string name)
    {
        public string Name { get; set; }
        private int height;
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value >= 0 && value < 1000)
                {
                    height = value;
                }
                else 
                {
                    height = 500;
                }
            }
        }
        private int speed;
        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                if (value > 0 && value < 1000)
                {
                    speed = value;
                }
                else 
                {
                    speed = 500;
                }
            }
        }
        public Plane()
        {
            Name = "Boing737";
            Speed = 800;
            Height = 1800;
        }
        public void Display() 
        {
            Console.WriteLine($"Название самолёта {Name}, скорость {Speed}, высота полёта {Height}");
        }
        public void Land()
        {
            this.Height = 0;
            Console.WriteLine("Самолёт {0} призелился, его высота {1}", Name, Height);
        }
    }
}
