namespace CourseApp
{
    public class EntitiesFactory
    {
        private string[] names =
        {
            "Олег",
            "Владилен",
            "Борислав",
            "Всеволод",
            "Гаврила",
            "Казимир",
        };

        public enum Classes
        {
            Archer = 0,
            Knight,
            Wizard,
            ClassesLength,
        }

        public Entity CreateEntity()
        {
            System.Random random = new System.Random();
            int classIndex = random.Next((int)Classes.ClassesLength);
            int nameIndex = random.Next(names.Length);
            switch (classIndex)
            {
                case (int)Classes.Archer:
                    return new Archer(random.Next(1, 50), random.Next(1, 20), names[nameIndex]);
                case (int)Classes.Knight:
                    return new Knight(random.Next(1, 50), random.Next(1, 20), names[nameIndex]);
                case (int)Classes.Wizard:
                    return new Wizard(random.Next(1, 50), random.Next(1, 20), names[nameIndex]);
                default:
                    return new Knight(random.Next(1, 50), random.Next(1, 20), names[nameIndex]);
            }
        }
    }
}