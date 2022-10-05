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
        public string Nick { get; set; }   // свойство
        public string Color { get; set; }   // свойство
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
        }   // свойство
        public virtual void Show1()
        {
            Console.WriteLine("бла-бла-бла1");
        }
        public virtual void Show2()
        {
            Console.WriteLine("бла-бла-бла2");
        }
    }
}
