namespace CourseApp
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            Phone phone1 = new Phone("+7000000","iPhone", -7);
            phone1.AcceptCall();
            phone1.CloseCall();
            phone1.MakeCall("+1234567");
            phone1.CloseCall();

            var phone2 = phone1;
            phone1.GetDisplay();

            Phone tablet = new Phone("+80000000","Android", 6);
            tablet.GetDisplay();
            Console.WriteLine(tablet.GetDisplay());
            Console.WriteLine("--------------");

            CellPhone cell1 = new CellPhone();
            cell1.Diagonal = 3;
            cell1.Diagonal = -3;
            Console.WriteLine(cell1.GetDisplay());

            Phone cell2 = new CellPhone("+90000","ericson", 5);
            Console.WriteLine(cell2.GetDisplay());

            CellPhone cell3 = (CellPhone)cell2;
            Console.WriteLine(cell3.GetDisplay());
            cell3.DeclineCall();

            CellPhone nokia = new CellPhone("+99999", "Nokia", 2000);
            nokia.AcceptCall();
            nokia.CloseCall();
            nokia.TrackName = "AAAAAA very good song";
            nokia.PlayMusic();
            nokia.SendMessage("+700000", "some message");

            CellPhone simens = nokia;
            simens.Number = "+11111111111111";
            Console.WriteLine(nokia.GetDisplay());
            Console.WriteLine(simens.GetDisplay());
            
            Phone poly = new CellPhone("+876543", "MyPhone", 2000);
            Console.WriteLine("-----------------");
            Console.WriteLine(poly.GetDisplay());

            CellPhone cell = (CellPhone)poly;
        }
    }
}
