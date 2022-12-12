namespace CourseApp.SelectorGame
{
    using System;
    using System.Collections.Generic;
    using CourseApp.Logger;

    #nullable enable

    public class Selector
    {
        public Selector(ILogger logger)
        {
            Logger = logger;
            NewClasses.Add(false);
            NewClasses.Add(false);
            NewClasses.Add(false);
        }

        private int ChoiceNewHero { get; set; }

        private ILogger Logger { get; set; }

        private List<bool> NewClasses { get; set; } = new List<bool>();

        public List<bool> SelectCustomClass()
        {
            Logger.PrintStartSelectHero();
            string? confirm = "Нет";

            while (true)
            {
                Logger.PrintSelectHero();

                string? heroChoice = Console.ReadLine();

                if (int.TryParse(heroChoice, out int i) && i < 4)
                {
                    ChoiceNewHero = i;

                    IsAddNewClass(confirm);

                    Logger.PrintStartNumberPlayers();

                    string? answer = Console.ReadLine();
                    if (!string.IsNullOrEmpty(answer))
                    {
                        if (answer == "Да")
                        {
                            break;
                        }
                    }
                }
                else
                {
                    Logger.PrintWrongNumber();
                }
            }

            return NewClasses;
        }

        public int SelectNumbPlayers()
        {
            int playersNumbers;

            while (true)
            {
                Logger.PrintNumberPlayers();

                string? numberOfPlayers = Console.ReadLine();

                if (int.TryParse(numberOfPlayers, out int i) && (i % 2 == 0))
                {
                    playersNumbers = i;
                    break;
                }
                else
                {
                    Logger.PrintWrongNumber();
                }
            }

            return playersNumbers;
        }

        private void IsAddNewClass(string? confirm)
        {
            if (confirm != "Да")
            {
                Logger.PrintAddAbility(ChoiceNewHero);
                confirm = Console.ReadLine();

                if (confirm == "Да")
                {
                    NewClasses[ChoiceNewHero - 1] = true;
                    confirm = "Нет";
                }
                else
                {
                    NewClasses[ChoiceNewHero - 1] = false;
                }
            }
        }
    }
}
