using CourseApp.Class;

public class Sushi : Dish
{
    private int number;

    public Sushi(string name, double callories, double weight, double price, string type, int number)
            : base(name, callories, weight, price)
    {
        TypeOfSuchi = type;
        this.number = number;
    }

    public Sushi()
    {
    }

    public int Number
    {
        get
        {
            return number;
        }

        set
        {
            if (value < 0)
            {
                number = 0;
            }
        }
    }

    public string TypeOfSuchi { get; set; }

    public override string ToString()
    {
        return $"Sushi {Name} - {TypeOfSuchi}";
    }

    public override string GetInfo()
    {
        return @$"Sushi: {Name}
Callories: {Callories}
Weight: {Weight}
Price: {Price}
Type: {TypeOfSuchi}";
    }

    public override string Eat()
    {
        if (number > 0)
        {
            number -= 1;
            return "We eat one sushi";
        }
        else
        {
            return "We can't eat sushi because there isn't any";
        }
    }
}
