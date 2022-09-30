using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    public class Plane //(int speed, int height, string name)
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
        private int speed;
        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                if (value > 0 && value <= 1000)
                {
                    speed = value;
                }
                else 
                {
                    speed = 700;
                }
            }
        }
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