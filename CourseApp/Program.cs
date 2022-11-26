namespace CourseApp
{
    using System;
    using AutoApp;

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

            /*Game rpg = new Game(100, 35, "(Рыцарь) Артур", "Удар возмездия");
            int characterHealth = rpg.Health;
            int characterPower = rpg.Power;
            string characterName = rpg.Name;
            string characterAbility = rpg.Ability;
            Console.WriteLine($"Здоровье: {characterHealth}  Сила: {characterPower}  Имя: {characterName}  Способность: {characterAbility}");

            rpg.Health = 50;
            rpg.Power = 20;
            rpg.Name = "(Рыцарь) Ричард";
            rpg.Ability = "Удар возмездия";
            Console.WriteLine(rpg.Print());*/

            Hero knight1 = new Knight(50, 20, "(Рыцарь) Ричард");
            Hero knight2 = new Knight(50, 20, "(Рыцарь) Зигфрид");
            Hero archer = new Archer(50, 20, "(Лучник) Леголас");
            Hero magician = new Magician(50, 20, "(Маг) Дамблдор");

            Console.WriteLine("Кон 1.");
            Console.WriteLine("(Рыцарь) Ричард vs (Лучник) Леголас");
            while ((knight1.Health > 0) && (archer.Health > 0))
            {
                Console.WriteLine(archer.Action());
                Console.WriteLine(knight1.Damage());
                if (knight1.Health <= 0)
                {
                    break;
                }

                Console.WriteLine(knight1.AbilityDisplay());
                Console.WriteLine(archer.KnightAbiltiy());
                if (archer.Health <= 0)
                {
                    break;
                }
            }

            if (knight1.Health <= 0)
            {
                Console.WriteLine("(Рыцарь) Ричард погибает");
            }
            else if (archer.Health <= 0)
            {
                Console.WriteLine("(Лучник) Леголас погибает");
            }

            Console.WriteLine(" ");
            Console.WriteLine("(Рыцарь) Зигрфрид vs (Маг) Дамблдор");
            while ((knight2.Health > 0) && (magician.Health > 0))
            {
                Console.WriteLine(magician.Action());
                knight2.Damage();
                if (knight2.Health <= 0)
                {
                    break;
                }

                Console.WriteLine(knight2.Action());
                magician.Damage();
                if (magician.Health <= 0)
                {
                    break;
                }
            }

            if (knight2.Health <= 0)
            {
                Console.WriteLine("(Рыцарь) Зигфрид погибает");
            }
            else if (magician.Health <= 0)
            {
                Console.WriteLine("(Маг) Дамблдор погибает");
            }

            Console.WriteLine(" ");
            Console.WriteLine("Кон 2.");
            Console.WriteLine("(Рыцарь) Ричард vs (Маг) Дамблдор");
            while ((knight1.Health > 0) && (magician.Health > 0))
            {
                Console.WriteLine(magician.AbilityDisplay());
                Console.WriteLine(knight1.MagicianAbility());
                Console.WriteLine(magician.Action());
                knight1.Damage();
                if (knight1.Health <= 0)
                {
                    break;
                }

                Console.WriteLine(knight1.Action());
                magician.Damage();
                if (magician.Health <= 0)
                {
                    break;
                }
            }

            if (knight1.Health <= 0)
            {
                Console.WriteLine("(Рыцарь) Ричард погибает");
            }
            else if (magician.Health <= 0)
            {
                Console.WriteLine("(Маг) Дамблдор погибает");
            }
        }
    }
}
