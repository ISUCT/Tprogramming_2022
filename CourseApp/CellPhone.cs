namespace CourseApp
{
    using System;

    public class CellPhone: Phone
    {

        public CellPhone():base("nokia", 2)
        {
            Console.WriteLine("Cell phone without params");
        }

        public CellPhone(string name, int diagonal):base(name, diagonal)
        {
            Console.WriteLine("Cell phone with params");
        }
        public void DeclineCall()
        {
            Console.WriteLine("Decline Call");
        }

        public void GetMessage()
        {
            Console.WriteLine("Getting text message");
        }
        public void SendMessage()
        {
            Console.WriteLine("Sending message");
        }

        
        public override string GetDisplay()
        {
            return $"CellPhone {Name} with diagonal {Diagonal}";
        }

    }
}