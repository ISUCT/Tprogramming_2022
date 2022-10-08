namespace CourseApp
{
    using System;

    public class KeepApp : Application, IAndroidApp
    {
        public KeepApp(string name) : base(name)
        {
        }

        public void CheckGoogle()
        {
            Console.WriteLine("Big brother watching you!");
        }
    }
}