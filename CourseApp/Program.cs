namespace CourseApp
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            Phone phone1 = new Phone("iPhone", -7);
            var phone2 = phone1;
            phone1.GetDisplay();
            phone1.Diagonal = 7;
            phone1.GetDisplay();
            phone1.Diagonal = -16;
            phone1.GetDisplay();

            Phone tablet = new Phone("Android", 6);
            tablet.Diagonal = 6;
            tablet.GetDisplay();
            tablet.Diagonal = -10;
            tablet.GetDisplay();
            tablet.Diagonal = 8;
            Console.WriteLine(tablet.GetDisplay());
            Console.WriteLine("--------------");

            CellPhone cell1 = new CellPhone();
            cell1.Diagonal = 3;
            cell1.Diagonal = -3;
            Console.WriteLine(cell1.GetDisplay());

            Phone cell2 = new CellPhone("ericson", 5);
            // cell2.GetMessage();
            // cell2.SendMessage();
            // cell2.DeclineCall();
            Console.WriteLine(cell2.GetDisplay());

            CellPhone cell3 = (CellPhone)cell2;
            Console.WriteLine(cell3.GetDisplay());
            cell3.DeclineCall();

        }
    }
}
