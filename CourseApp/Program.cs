namespace CourseApp
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            // int a = 5;
            Phone phone = new Phone("+7000000", 1990);
            Console.WriteLine(phone.Year);
            phone.Display();
            phone.AcceptCall();
            phone.CloseCall();
            phone.MakeCall("+1234567");
            phone.CloseCall();

            Phone phone1 = new Phone("+88888", 1700);
            phone1.Display();
            phone1.AcceptCall();

            CellPhone nokia = new CellPhone("+99999", 2000);
            nokia.Display();
            nokia.AcceptCall();
            nokia.CloseCall();

            nokia.TrackName = "AAAAAA very good song";
            nokia.PlayMusic();
            nokia.SendMessage("+700000", "some message");
            nokia.Display();

            CellPhone simens = nokia;
            simens.Number = "+11111111111111";
            nokia.Display();
            simens.Display();
            
            Phone poly = new CellPhone("+876543", 2000);
            Console.WriteLine("-----------------");
            poly.Display();

            CellPhone cell = (CellPhone)poly;
            cell.Display();
        }
    }
}
