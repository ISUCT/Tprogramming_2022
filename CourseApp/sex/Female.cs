namespace CourseApp;

public class Female : Human
{
    public Female(int age)
        : base(age)
    {
    }

    public Female(int age, int height, float weight)
        : base(age, height, weight)
    {
    }

    public override string Average_Height()
    {
        if (Height >= 45 && Height < 165)
        {
            System.Console.WriteLine("Your height is below average in Russia;");
            return "Your height is below average in Russia;";
        }
        else if (Height >= 165 && Height <= 210)
        {
            System.Console.WriteLine("Your height is above average in Russia;");
            return "Your height is above average in Russia;";
        }
        else if (Height == 0)
        {
            System.Console.WriteLine("Input error in height;");
            return "Input error in height;";
        }

        return "Default";
    }

    public override string Average_Weight()
    {
        if (Weight >= 0.3 && Weight <= 72.7)
        {
            System.Console.WriteLine("Your weight is below average in Russia.");
            return "Your weight is below average in Russia.";
        }
        else if (Weight > 72.7 && Weight <= 300)
        {
            System.Console.WriteLine("Your weight is above average in Russia.");
            return "Your weight is above average in Russia.";
        }
        else if (Weight == 0)
        {
            System.Console.WriteLine("Input error in weight;");
            return "Input error in weight;";
        }

        return "Default";
    }

    public override string ToString()
    {
        return $"You are a female of {Age} years. Your weight is {Weight} kg and height {Height} cm.";
    }
}