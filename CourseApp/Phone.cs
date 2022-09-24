namespace CourseApp
{
    using System;

    public class Phone
    {
        private int year = 1880;
        public string Name { get; set; }
        public string Number {get; set;}

        public Phone(): this("+7000000","untitled", 1990)
        {
            Console.WriteLine("Phone Simple constructor called");
        }

        public Phone(string number,string name, int year)
        {
            Number = number;
            Year = year;
            Name = name;
            Console.WriteLine("Phone constructor called");
        }

        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                if (value >= 1880 && value <= 2022)
                {
                    this.year = value;
                }
            }
        }

        public virtual string GetDisplay()
        {
            return $"Простой телефон номер:{Number}, произведен {Year}";
        }

        public void AcceptCall()
        {
            Console.WriteLine("Принимаю звонок");
        }
        public void CloseCall()
        {
            Console.WriteLine("Завершаю звонок");
        }

        public void MakeCall(string phoneNumber)
        {
            Console.WriteLine($"Звонок на номер {phoneNumber}");
        }

    }
}