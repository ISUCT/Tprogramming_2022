namespace CourseApp;

public abstract class Animals
{
    private int age;
    private string color;
    private string gender;

    public Animals()
    {
    }

    public Animals(int age, string color, string gender)
    {
        this.age = age;
        this.color = color;
        this.gender = gender;
    }

    public abstract string GetInfo();

    public abstract string Move();
}