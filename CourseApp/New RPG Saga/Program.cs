namespace CourseApp.RPG_Saga
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        private static Random randomizer = new Random();
        private static string[] names = new string[32] { "Гром", "Кристофер", "Белль", "Диана", "Виктория", "Саймон", "Зерко", "Мариэлла", "Анок", "Мрик", "Вайл", "Кроль", "Оник", "Ева", "Нарри", "Эльза", "Александр", "Мариэль", "Марри ", "Инко", "Зик", "Гроль", "Крайк", "Мраль", "Салли", "Верш", "Пика", "Арик", "Эммо", "Ешка", "Грим", "Викто" };

        public static void Main()
        {
            List<Players> heroes = new List<Players>();
            List<Players> arena = new List<Players>();
            bool death = false;
            int counter = 0;

            Console.Write("Введите чётное количество героев: ");
            int numberPlayers = Convert.ToInt16(Console.ReadLine()); // записываем введённое пользователем число в переменную, преобразовав его из string в int16
            Console.WriteLine();

            if (Check(numberPlayers) == false)
            {
                Console.WriteLine("Введнено нечётное количество игроков!");
                return;
            }

            Console.WriteLine("В битве учавствуют:");
            Console.WriteLine();

            for (int i = 0; i < numberPlayers; i++)
            {
                heroes.Add(CreateHeroes());
                Console.WriteLine(heroes[i]);
            }

            while (heroes.Count > 1)
            {
                for (int i = 0; i < 2; i++)
                {
                    var candidate = heroes[randomizer.Next(0, heroes.Count)];
                    arena.Add(candidate);
                    heroes.Remove(candidate);
                }

                counter += 1;

                Logger.NewRegistration(counter);

                while (death == false)
                {
                    if (arena[1].Health <= 0)
                    {
                        Logger.WriteLog($"{arena[0]} убивает персонажа {arena[1]}");
                        arena[0].Ult = false;
                        heroes.Add(arena[0]);
                        arena.Clear();
                        death = true;
                        break;
                    }
                    else if (arena[0].Health <= 0)
                    {
                        Logger.WriteLog($"{arena[1]} убивает персонажа {arena[0]}");
                        arena[1].Ult = false;
                        heroes.Add(arena[1]);
                        arena.Clear();
                        death = true;
                        break;
                    }

                    switch (randomizer.Next(1, 100))
                    {
                        case > 50:
                            arena[0].Ultimate();
                            Logger.WriteLog($"{arena[0]} использует свою суперспособность!");
                            break;
                        case < 50:
                            GiveDamage(arena[1], arena[0]);
                            break;
                    }

                    if (arena[1].Health <= 0)
                    {
                        Logger.WriteLog($"{arena[0]} убивает персонажа {arena[1]}");
                        arena[0].Ult = false;
                        heroes.Add(arena[0]);
                        arena.Clear();
                        death = true;
                        break;
                    }
                    else if (arena[0].Health <= 0)
                    {
                        Logger.WriteLog($"{arena[1]} убивает персонажа {arena[0]}");
                        arena[1].Ult = false;
                        heroes.Add(arena[1]);
                        arena.Clear();
                        death = true;
                        break;
                    }

                    switch (randomizer.Next(1, 100))
                    {
                        case < 50:
                            arena[1].Ultimate();
                            Logger.WriteLog($"{arena[1]} использует свою суперспособность!");
                            break;
                        case > 50:
                            GiveDamage(arena[0], arena[1]);
                            break;
                    }
                }

                death = false;
            }

            Console.WriteLine();
            Console.WriteLine($"{heroes[0]} становится победителем! Ура!!!");
        }

        public static Players CreateHeroes()
        {
            switch (randomizer.Next(1, 4))
            {
                case 1:
                    return new Knight(names[randomizer.Next(0, 31)]);
                case 2:
                    return new Fairy(names[randomizer.Next(0, 31)]);
                case 3:
                    return new Goblin_archer(names[randomizer.Next(0, 31)]);
            }

            return null;
        }

        public static bool Check(int numberPlayers)
        {
            if (numberPlayers % 2.0 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void GiveDamage(Players heroTaker, Players damager)
        {
            if ((heroTaker is Goblin_archer) && (heroTaker.Ult == true))
            {
                Debuff(damager);
                if (damager.Health <= 0)
                {
                    return;
                }
            }
            else if ((damager is Goblin_archer) && (damager.Ult == true))
            {
                Debuff(heroTaker);
                if (heroTaker.Health <= 0)
                {
                    return;
                }
            }

            if (heroTaker is Fairy)
            {
                if (heroTaker.Ult == true)
                {
                    Logger.WriteLog($"{damager} находится под властью чар {heroTaker} и пропускает ход");
                    heroTaker.Ult = false;
                }
                else
                {
                    Logger.WriteLog($"{damager} наносит {damager.Punch()} урона персонажу {heroTaker}");
                    heroTaker.Health -= damager.Punch();
                }
            }
            else
            {
                Logger.WriteLog($"{damager} наносит {damager.Punch()} урона персонажу {heroTaker}");
                heroTaker.Health -= damager.Punch();
            }
        }

        public static void Debuff(Players player)
        {
            Logger.WriteLog($"{player} горит и получает урон 2HP");
            player.Health -= 2;
        }
    }
}