namespace Phones
{
    using System;

    public class KeepApp : Application, IAndroidApp
    {
        public KeepApp(string name)
            : base(name)
        {
        }

        public void CheckGoogle()
        {
            Console.WriteLine("Big brother watching you!");
        }

        public override void InstallApp()
        {
            Console.WriteLine("Installing Keep");
        }

        public override void RunApp()
        {
            Console.WriteLine("Running Keep");
        }
    }
}