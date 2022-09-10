using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    class Plane (int speed, int height, string plane)
    {
        Speed = speed
            get;
            set
            {
                if (Speed > 0 && Speed < 10000)
                {
                    
                }
            };
        }
        public int Height { get; set; }
        public string Name { get; set; }
        public Plane()
        {
            Name = "Boing737";
            Speed = 800;
            Height = 1800;
            
        }
    }
}
