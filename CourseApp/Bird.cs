namespace CourseApp
{
    using System;
    
    public class Bird : Pet
    {
        public Bird(string nick, string color, int age) : base( nick,  color, age)
        {
            Console.WriteLine(" Моя домашняя птица");
        }
        public override void Show1()
        {
            Console.WriteLine($"{Color} попугай {Nick}");
            var text = @"
           \\
   \\      (o>
   (o>     //\
  _(()_____V_/_____
   ||      ||
           ||";
            Console.WriteLine(text);
        }
    }
}    