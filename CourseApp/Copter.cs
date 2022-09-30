using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    public class Copter : Plane
    {
        private double diagonal;
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

        public Copter()
        {
            Name = "Boing737";
            Speed = 800;
            Height = 8000;
            Diagonal = 8.4;
        }
        public Copter(double diagonal)
        {
            Diagonal = diagonal;
        }
        public void Camera()
        {
            Console.WriteLine($"Камера коптера {Name} составляет {Diagonal}");
        }
    }
}