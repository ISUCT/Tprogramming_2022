namespace CourseApp
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            // int a = 5;
            Phone phone = new Phone();
            phone.AcceptCall();
            phone.CloseCall();
            phone.MakeCall("+1234567");
            phone.CloseCall();
            Console.WriteLine($"ver={phone.Version} num={phone.Number}");

            Phone phone1 = new Phone(5, "+7000000");
            Console.WriteLine($"ver={phone1.Version} num={phone1.Number}");
            phone1.AcceptCall();
        }
    }
}
