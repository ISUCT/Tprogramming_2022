using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    class Copter : Plane
    {
        private float diagonal;
        public float Diagonal
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
                    diagonal = 7;
                }
            }
        }
        public void Camera()
        {
            Console.WriteLine($"Камера коптера {Name} составляет {Diagonal}");
        }
    }
}