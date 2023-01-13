using System;

namespace CourseApp
{
    public abstract class Animals
    {
        public Animals(string name, string size, int age, string colour, string genus)
        {
            Name = name;
            Size = size;
            Age = age;
            Colour = colour;
            Genus = genus;
        }

        public string Name { get; set; }
        public string Size { get; set; }
        public int Age { get; set; }
        public string Colour { get; set; }
        public string Genus { get; set; }  

    }
}