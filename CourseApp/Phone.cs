namespace CourseApp
{
    using System;

    public class Phone
    {
        public string Number {get; set;}

        private int year = 1880;

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

        public Phone(): this("+7000000", 1990)
        {
            Console.WriteLine("Phone Simple constructor called");
        }
        public Phone(string number, int year)
        {
            Number = number;
            Year = year;
            Console.WriteLine("Phone constructor called");
        }

        public virtual void Display()
        {
            Console.WriteLine($"Простой телефон номер:{Number}, произведен {Year}");
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