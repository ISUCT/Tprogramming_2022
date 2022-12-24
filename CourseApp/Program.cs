namespace CourseApp
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using RPGSaga;

    public class Program
    {
        public static void Main(string[] args)
        {
            var artur = new Knight() { Name = "Артур", Maxhealth = 80, Power = 5 };
            artur.Greetings();
            artur.DealDamage();
            artur.VengStrike();
            var mc = new MultiplyChars();
            var twoheros = mc.CreateN(2);
            foreach (var player in twoheros)
            {
                player.Greetings();
            }

            /* var def = new Plane() { Speed = 1000, Height = 11000 };
            var ssj = new Copter() { Name = "SSJ100", Speed = 800, Diagonal = 8.2 };
            var airbus = new Plane("Airbus", -1, 9500);
            var pt300 = new Copter("ПТ300", 800, 5000);
            var vw = new Car("VW Polo", 140);

            var transport = new List<Vehicle>() { def, ssj, airbus, pt300, vw };
            foreach (var vehicle in transport)
            {
                Console.WriteLine(vehicle.Display());
            } */
        }
    }
}