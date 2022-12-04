namespace CourseApp.RPGSaga.Generator
{
    using System;
    using System.Collections.Generic;
    using CourseApp.RPGSaga.Heroes;

    public class CreatorPlayer
    {
        private List<string> nameList = new List<string>()
        {
            "Abraham", "Adam", "Adrian", "Albert", "Alexander", "Alfred", "Anderson", "Andrew", "Anthony", "Arnold", "Ashley", "Noah", "Liam", "Mason",
            "Jacob ", "William", "Ethan", "Michael",
        };

        private List<string> typesHeroesList = new List<string>() { "Archer", "Knight", "Wizard" };

        public Player FactoryMethod()
        {
            return CreatePlayer();
        }

        private Player CreatePlayer()
        {
            Player player = null;
            var name = nameList[Random.Shared.Next(0, nameList.Count)];
            var healthpoints = Random.Shared.Next(50, 100);
            var strength = Random.Shared.Next(20, 30);
            switch (typesHeroesList[Random.Shared.Next(0, typesHeroesList.Count)])
            {
                case "Archer":
                    player = new Archer(name, healthpoints, strength);
                    break;
                case "Knight":
                    player = new Knight(name, healthpoints, strength);
                    break;
                case "Wizard":
                    player = new Wizard(name, healthpoints, strength);
                    break;
            }

            return player;
        }
    }
}