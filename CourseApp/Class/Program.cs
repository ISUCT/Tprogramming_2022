namespace CourseApp
{
    using System.Collections.Generic;
    using CourseApp.Class;

    public class Program
    {
        public static void Main(string[] args)
        {
            Dish sushi = new Sushi("California", 176, 28, 350, "standard", 8);
            Dish salad = new Salad("Caesar", 44, 300, new string[] { "chicken", "cherry", "tomatoes", "parmesan", "olive oil", "garlic", "black pepper" }, 400);
            List<Dish> dishs = new List<Dish> { salad, sushi };
            System.Console.WriteLine(sushi.ToString());
            System.Console.WriteLine(salad.ToString());

            for (int i = 0; i < dishs.Count; i++)
            {
                System.Console.WriteLine(dishs[i].Eat());
            }

            Dish dish = new Salad();
            System.Console.WriteLine(dish.GetInfo());

            Salad salad1 = new Salad("Caesar", 44, 300, new string[] { "chicken", "cherry", "tomatoes", "parmesan", "olive oil", "garlic", "black pepper" }, 400);
            salad1.Delivery();
        }
    }
}
