namespace CourseApp.Class
{
    using System;

    public abstract class Dish
    {
        private string name;
        private double callories;
        private double weight;
        private double price;

        public Dish()
        {
            callories = 0;
            weight = 0;
            name = "No_Name_Null";
            price = 0;
        }

        public Dish(string name, double callories, double weight, double price)
        {
            Callories = callories;
            Weight = weight;
            Name = name;
            Price = price;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                try
                {
                    if ((value == " ") || (value == null))
                    {
                        throw new Exception($"Name is incorrect!");
                    }
                    else
                    {
                        name = value;
                    }
                }
                catch (Exception e)
                {
                    new ArgumentException($"Error: {e.Message}");
                    Console.WriteLine($"Error: {e.Message}");
                }
            }
        }

        public double Price
        {
            get
            {
                return price;
            }

            set
            {
                if (value < 0)
                {
                    price = 0;
                }
                else
                {
                    price = value;
                }
            }
        }

        public double Callories
        {
            get
            {
                return callories;
            }

            set
            {
                if (value < 0)
                {
                    callories = 0;
                }
                else
                {
                    callories = value;
                }
            }
        }

        public double Weight
        {
            get
            {
                return weight;
            }

            set
            {
                if (value < 0)
                {
                    weight = 0;
                }
                else
                {
                    weight = value;
                }
            }
        }

        public virtual string GetInfo()
        {
            return @$"Dish: {Name}
Callories: {Callories}
Weight: {Weight}
Price: {Price}";
        }

        public override string ToString()
        {
            return $"Блюдо: {name} Цена:{Price}";
        }

        public abstract string Eat();
    }
}
