namespace CourseApp
{
    using System;
    using CourseApp.Interfaces;

    public class Zebra : Animals, IDrawable
    {
        public Zebra(string name, string size, int age, string colour, string genus, string mane)
            : base(name, size, age,colour, genus)
        {
            Name = name;
            Size = size;
            Age = age;
            Colour = colour;
            Genus = genus;
            Mane = mane;
        }

        public string Mane { get; set; }

        public string Have()
        {
            var date = @$"Зебра
Имя: {Name}
Размерчик: {Size}
Возраст: {(Age <= 0 ? "none" : Age)}
Цвет: {Colour}
Пол: {Genus}
Грива: {Mane}";
            Console.WriteLine(date);
            return " ";
        }
    }
}
