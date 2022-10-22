namespace Phones
{
    using System;
    using System.Collections.Generic;

    public class SmartPhone<T> : CellPhone, IDisplayable
        where T : IApplication
    {
        private List<T> apps;

        public SmartPhone()
            : this("+70000000", "Pixel", 2022)
        {
        }

        public SmartPhone(string number, string name, int diagonal)
            : base(number, name, diagonal)
        {
            apps = new List<T>();
        }

        public string OsType { get; set; }

        public override string ToString()
        {
            return $"Проводной телефон {Name} номер:{Number}, произведен {Year}";
        }

        public override string Display()
        {
            return this.ToString();
        }

        public void ConnectToInternet()
        {
            Console.WriteLine("Connecting to the internet");
        }

        public virtual void AddApp(T app)
        {
            app.InstallApp();
            apps.Add(app);
        }

        public void StartApp(T application)
        {
            foreach (T app in apps)
            {
                if (application.Equals(app))
                {
                    app.RunApp();
                    return;
                }
            }

            Console.WriteLine($"No such application ");
        }
    }
}