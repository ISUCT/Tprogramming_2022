namespace CourseApp
{
    using System;

    public class Pet
    {
        private int age; // поле

        public Pet(string nick, string color, int age) // конструктор 
        {
           Nick = nick;
           Color = color;
           Age = age;
        }

        // свойства
        public string Nick { get; set; }

        public string Color { get; set; }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value != 1 && value > 0)
                {
                    this.age = value;
                }
            }
        }
        public void Show()
        {
            Console.WriteLine($"{Nick} - это {Color} питомец, {Age} лет");
        }
    }
}
