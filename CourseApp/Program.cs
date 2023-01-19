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

            Game fight1 = new Game();
            Console.WriteLine(fight1.EnterFight(1));
            Console.WriteLine(fight1.Advertisement(knight1, archer));
            fight1.Fight(knight1, archer);

            Game fight2 = new Game();
            fight2.EnterFight(1);
            fight2.Advertisement(knight2, magician);
            fight2.Fight(knight2, magician);

            Game fightFinal = new Game();
            fightFinal.EnterFight(2);
            fightFinal.Advertisement(knight1, knight2);
            fightFinal.Fight(knight1, knight2);
        }
    }
}