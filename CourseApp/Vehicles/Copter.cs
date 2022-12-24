namespace Vehicles
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Copter : Plane
    {
        private double diagonal;

        public Copter()
        {
            Name = "Boing737";
            Speed = 60;
            Height = 1000;
            Diagonal = 8.4;
        }

        public Copter(double diagonal)
        {
            Diagonal = diagonal;
        }

        public Copter(string name, int speed, int height)
        : base(name, speed, height)
        {
        }

        public double Diagonal
        {
            get
            {
                return diagonal;
            }

            set
            {
                if (value > 0 && value < 14)
                {
                    diagonal = value;
                }
                else
                {
                    diagonal = 7.1;
                }
            }
        }

        public void Camera()
        {
            Console.WriteLine($"Камера коптера {Name} составляет {Diagonal}");
        }

        public override string ToString()
        {
            return $"Имя коптера засекречено";
        }
    }
}