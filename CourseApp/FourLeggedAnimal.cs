namespace CourseApp
{
    using System;

    public class FourLeggedAnimal : Pet
    {
        public FourLeggedAnimal(string nick, string color, int age) : base(nick, color, age)
        {
            Console.WriteLine(" Мой четвероногий друг");
        }
        public override void Show1()
        {
            Console.WriteLine($"  {Color} котёнок {Nick}");
            var text = @"
       /\_/\
      ( o.o )
       > ^ < ";
            Console.WriteLine(text);
        }
        public override void Show2()
        {
            Console.WriteLine($"   {Color} пёс {Nick}");
            Console.WriteLine("     ,-.___,-. ");
            Console.WriteLine("     \\_/_ _\\_/");
            Console.WriteLine("       )O_O( ");
            Console.WriteLine("      { (_) } ");
            Console.WriteLine("       `-^-'  ");
        }
    }
}   