namespace Phones
{
    public class AndroidPhone<T> : SmartPhone<T>
        where T : IAndroidApp
    {
        public AndroidPhone()
            : base("+70000000", "Pixel", 2022)
        {
        }

        public AndroidPhone(string number, string name, int diagonal)
            : base(number, name, diagonal)
        {
        }

        public override void AddApp(T app)
        {
            base.AddApp(app);
        }
    }
}