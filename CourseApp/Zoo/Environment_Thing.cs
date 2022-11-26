namespace CourseApp
{
    using System;
    using CourseApp.Interfaces;

    public class Thing : Environment, IDrawable
    {
        public Thing(string why, string role, string size, string material)
            : base(why, role, size, material)
        {
            Why = why;
            Role = role;
            Size = size;
            Material = material;
        }

        public string Have()
        {
            var Have = @$"Вещь
Зачем: {Why}
Название: {Role}
Размер: {Size}
Материал: {Material}";
            Console.WriteLine(Have);
            return " ";
        }
    }
}