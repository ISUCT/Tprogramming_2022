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

            Phone phone1 = new Phone();
            phone1.AcceptCall();
        }
    }
}
