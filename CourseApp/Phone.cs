namespace CourseApp
{
    using System;

    public class Phone
    {
        public string Number;

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