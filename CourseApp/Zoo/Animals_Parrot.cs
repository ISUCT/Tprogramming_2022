namespace CourseApp
{
    using System;
    using CourseApp.Interfaces;

    public class Parrot : Animals, IDrawable
    {
        public Parrot(string name, string size, int age, string colour, string genus, string kind)
            : base(name, size, age,colour, genus)
        {
            Name = name;
            Size = size;
            Age = age;
            Colour = colour;
            Genus = genus;
            Kind = kind;
        }

        public string Kind { get; set; }

        public string Have()
        {
            var date = @$"Попугайчик
Имя: {Name}
Размер: {Size}
Возраст: {(Age <= 0 ? "none" : Age)}
Цвет: {Colour}
Пол: {Genus}
Вид {Kind}";
            Console.WriteLine(date);
            return " ";
        }
    }
}
