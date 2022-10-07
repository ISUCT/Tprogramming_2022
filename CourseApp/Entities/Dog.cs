namespace CourseApp.Entities;

public class Dog : Pet
{
    public Dog(string nick, string color, int age)
        : base(nick, color, age)
    {
    }

    public override string GetInfo()
    {
        return $"   {Color} пёс {Nick}" + @"
     ,-.___,-.
    \\_/_ _\\_/
       )O_O(
      { (_) }
       `-^-'
";
    }
}