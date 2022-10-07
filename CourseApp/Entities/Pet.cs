namespace CourseApp.Entities
{
    using System;

    public abstract class Pet
    {
        private int age; // поле

        public Pet(string nick, string color, int age) // конструктор
        {
           Nick = nick;
           Color = color;
           Age = age;
        }

        public string Nick { get; set; } // свойство

        public string Color { get; set; } // свойство

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

        public virtual string GetInfo() => "It's a pet"; // крактая запись return, стрелочная функция, в JS пригодится)
        /*
         * public virtual string GetInfo() {
         *  return "It's a pet";
         * }
         */
    }
}
