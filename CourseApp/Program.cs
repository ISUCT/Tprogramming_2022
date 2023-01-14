namespace CourseApp
{
    using System;
    using AutoApp;
    using RPGsagaApp;

    public class Program
    {
        public static void Main(string[] args)
        {
            Auto cr = new Auto();
            cr.Print();

            Auto car = new Auto("Limousine", 35, 70);
            string autoName = car.Name;
            int autoSpeed = car.Speed;
            Console.WriteLine($"Название: {autoName}  Скорость: {autoSpeed}");

            car.Name = "LadaSedan";
            car.Ride();
            car.Speed = 120;
            car.Print();
            car.Stop();

            Automobile minibus = new Minibus("Маршрутка");
            Automobile bus = new Bus("Автобус");
            Automobile trolleybus = new Trolleybus("Троллейбус");
            Console.WriteLine(" ");
            Console.WriteLine(minibus.Display());
            minibus.Move();
            Console.WriteLine(bus.Display());
            bus.Move();
            Console.WriteLine(trolleybus.Display());
            trolleybus.Move();
            Console.WriteLine("-------------------------------------------------");

            Game saga = new Game();
            saga.Print();

            Game rpg = new Game(100, 35, "(Рыцарь) Артур", "Удар возмездия");
            int characterHealth = rpg.Health;
            int characterPower = rpg.Power;
            string characterName = rpg.Name;
            string characterAbility = rpg.Ability;
            Console.WriteLine($"Здоровье: {characterHealth}  Сила: {characterPower}  Имя: {characterName}  Способность: {characterAbility}");

            rpg.Health = 50;
            rpg.Power = 20;
            rpg.Name = "(Рыцарь) Ричард";
            rpg.Ability = "Удар возмездия";
            Console.WriteLine(rpg.Print());

            Hero knight1 = new Knight(50, 20, "(Рыцарь) Ричард", "Удар возмездия");
            Hero knight2 = new Knight(50, 20, "(Рыцарь) Зигфрид", "Удар возмездия");
            Hero archer = new Archer(50, 20, "(Лучник) Леголас", "Огненные стрелы");
            Hero magician = new Magician(50, 20, "(Маг) Дамблдор", "Заворожение");
            Console.WriteLine(" ");
        }
    }
}