namespace CourseApp.Class
{
    public class Salad : Dish, IDeliverDish, ICookingDish
    {
        public Salad(string name, double callories, double weight, string[] composition, double price)
            : base(name, callories, weight, price)
        {
            Composition = composition;
        }

        public Salad()
        {
        }

        public string[] Composition
        {
            get; set;
        }

        public override string GetInfo()
        {
            return @$"Salad: {Name}
Callories: {Callories}
Weight: {Weight}
Price: {Price}";
        }

        public override string Eat()
        {
            Weight = 0.8 * Weight;
            return "We eat part of the salad";
        }

        public override string ToString()
        {
            return $"Salad {Name}, {Callories} callories";
        }

        public void Delivery()
        {
            Price = (int)(Price * 1.3);
            System.Console.WriteLine($"Your salad delivered");
        }

        public string CookingDish(string[] ingredients)
        {
            Composition = ingredients;

            Callories *= 1.2;
            return "Salad prepared and dressed";
        }
    }
}
