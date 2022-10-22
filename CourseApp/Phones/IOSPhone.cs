namespace Phones
{
    public class IOSPhone<T> : SmartPhone<T>
        where T : IIOsApp
    {
        public IOSPhone()
            : this("+70000000", "Pixel", 2022)
        {
        }

        public IOSPhone(string number, string name, int diagonal)
            : base(number, name, diagonal)
        {
        }
    }
}