namespace CourseApp
{
    using System;

    public class Phone
    {
        private int version;
        public string Number;
        
        public int Version
        {
            get 
            {
                return version;
            }
            set 
            {
                if (value >0 && value < 20)
                {
                    version = value;
                }
            }
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

        public Phone() :this(1, "+000000000")
        {}

        public Phone(int version, string number)
        {
            this.Version = version;
            Number = number;
        }
    }
}