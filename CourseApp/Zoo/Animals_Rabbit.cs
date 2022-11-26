namespace CourseApp
{
    using System;
    using CourseApp.Interfaces;

    public class Rabbit : Animals, IDrawable
    {
        public Rabbit(string name, string size, int age, string colour, string genus)
            : base(name, size, age, colour, genus)
        {
            Name = name;
            Size = size;
            Age = age;
            Colour = colour;
            Genus = genus;
        }

        public string Have()
        {
            var date = @$"Кролик
Имя: {Name}
Размер: {Size}
Возраст: {(Age <= 0 ? "none" : Age)}
Цвет: {Colour}
Пол: {Genus}";
            Console.WriteLine(date);
            return " ";
        }
    }
}