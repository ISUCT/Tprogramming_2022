namespace CourseApp
{
    using System;
    using System.Collections.Generic;
    using CourseApp.Interfaces;

    public class MiniWorld : IDrawable
    {
        public MiniWorld(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public string Have()
        {
            var user = new UserInterface();
            Console.WriteLine($"Зоопарк {Name}");
            Console.WriteLine($"Обитатели зоопарка:\n");
            user.Have(Animals());
            Console.WriteLine($"Окружение:\n");
            user.Have(Objects());
            return " ";
        }

        public List<IDrawable> Animals()
        {
            var list = new List<IDrawable>();
            list.Add(new Rabbit("Тузик", "Средненькая, 20 см", 1 , "Темно-коричневый", "Женский"));
            list.Add(new Rabbit("Винтик", "Крупненький, 35 см", 2 , "Белый в бежевые пятнышки", "Мужской"));
            list.Add(new Parrot("Бусинка", "13 см", 1,"Бело-желтый", "Женский", "Какаду"));
            list.Add(new Parrot("Кузя", "15 см", 1, "Зелено-голубой", "Мужской", "Кубинский амазон"));
            list.Add(new Zebra("Карамелька", "Средненькая", 5, "Черная в белую полосочку", "Женский", "Недостаточно пушистая"));
            return list;
        }
        public List<IDrawable> Objects()
        {
            var list = new List<IDrawable>();
            list.Add(new Object("Для того, чтобы животные не разбегались", "Клетка","Железо и дерево", "Для каждого животного отдельный", "В каждой части зоопарка"));
            list.Add(new Object("Для мусора", "Мусорный бак","50 в высоту, диаметр 30", "Пластмасса", "В зоопарке, при входе и по центру"));
            list.Add(new Object("Для покупки еды для животных", "Магазин с кормом", "Дерево", "Большой", "В центре"));
            list.Add(new Thing("Для того, чтобы знать, где какое животное находится", "Карта", "30 на 30", "Бумага"));
            return list;
        }
    }
}