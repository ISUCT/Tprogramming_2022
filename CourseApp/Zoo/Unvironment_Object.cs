namespace CourseApp
{
    using System;
    using CourseApp.Interfaces;

    public class Object : Environment, IDrawable
    {
        public Object(string why, string role, string size, string material, string location)
            : base(why, role, size, material)
        {
            Role = role;
            Why = why;
            Size = size;
            Material = material;
            Location = location;
        }

        public string Location { get; set; }

        public string Have()
        {
            var Have = @$"Объект
Зачем: {Why}
Название: {Role}
Размер: {Size}
Материал: {Material}
Месторасположение: {Location}";
            Console.WriteLine(Have);
            return " ";
        }
    }
}