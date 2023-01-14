namespace CourseApp.Entities;

public class Cat : Pet
{
    public Cat(string nick, string color, int age)
        : base(nick, color, age)
    {
    }

    public override string GetInfo()
    {
        return $"  {Color} котёнок {Nick}" + @"
       /\_/\
      ( o.o )
       > ^ <";
    }
}