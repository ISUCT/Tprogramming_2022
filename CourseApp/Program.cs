namespace CourseApp
{
    using System;
    using Phones;

    public class Program
    {
        public static void Main(string[] args)
        {
            Phone phone1 = new LandlinePhone("+7000000", "Проводной", -7);
            var phone2 = phone1;
            CellPhone cell1 = new CellPhone();
            cell1.Diagonal = 3;
            cell1.Diagonal = -3;
            Console.WriteLine(cell1);
            Phone cell2 = new CellPhone("+90000", "ericson", 5);
            Console.WriteLine(cell2);

            CellPhone cell3 = (CellPhone)cell2;

            CellPhone nokia = new CellPhone("+99999", "Nokia", 2000);
            nokia.AcceptCall();
            nokia.CloseCall();
            nokia.TrackName = "AAAAAA very good song";
            nokia.PlayMusic();

            Phone poly = new CellPhone("+876543", "MyPhone", 2000);
            Console.WriteLine("-----------------");
            Console.WriteLine(poly);

            CellPhone cell = (CellPhone)poly;

            Console.WriteLine(poly);

            var smart = new SmartPhone<IIOsApp>();

            var pen = new Pen();
            var store = new Store();
            store.AddItem(phone1);
            store.AddItem(cell1);
            store.AddItem(cell2);
            store.AddItem(smart);
            store.AddItem(pen);
            Console.WriteLine("-------------------------");
            store.Show();
            Console.WriteLine("-------------------------");

            var faceTime = new FaceTime("FaceTime");
            smart.AddApp(faceTime);

            smart.StartApp(faceTime);
            Console.WriteLine("-------------------------");
            var pixel = new AndroidPhone<IAndroidApp>("+77777", "GPixel", 2022);
            var iphone = new IOSPhone<IIOsApp>("+78888888", "IPhone14", 2022);

            // Следующая строка не будет работать
            // pixel.InstallApp(faceTime);
            pixel.AddApp(new KeepApp("Keep"));
            iphone.AddApp(faceTime);
        }
    }
}
