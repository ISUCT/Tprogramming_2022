namespace Phones
{
    using System;

    public class FaceTime : Application, IIOsApp
    {
        public FaceTime(string name)
            : base(name)
        {
        }

        public void CheckWallet()
        {
            Console.WriteLine("Checking FaceTimeApp");
        }

        public override void InstallApp()
        {
            Console.WriteLine("Installing FaceTime");
        }

        public override void RunApp()
        {
            Console.WriteLine("Running FaceTime");
        }
    }
}