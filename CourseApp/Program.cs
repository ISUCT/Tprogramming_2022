namespace CourseApp
{
    using System;

    public class Program
        {
            public static void Main(string[] args)
            {
                Country rus = new Country("Russia", "Moskow", 17000);
                Country can = new Country("Canada", "Ottawa");
                Country usa = new Country("USA");
                rus.Print();
                rus.TheCapital();
                rus.Welcome();

                can.Print();
                can.TheCapital();
                can.Welcome();

                usa.Print();
                usa.TheCapital();
                usa.Welcome();
        }
    }
}