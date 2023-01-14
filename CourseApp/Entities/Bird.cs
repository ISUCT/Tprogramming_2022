namespace CourseApp.Entities
{
    using System;

    public class Bird : Pet
    {
        public Bird(string nick, string color, int age)
            : base(nick,  color, age)
        {
        }

        public override string GetInfo()
        {
            return $"  {Color} попугай {Nick}" + @"
           \\
   \\      (o>
   (o>     //\
  _(()_____V_/_____
   ||      ||
           ||";
        }
    }
}