namespace CourseApp
{
    using System;
    using System.Collections.Generic;

    public class SmartPhone : CellPhone, IDisplayable
    {
        private List<Application> apps;

        public string OsType { get; set; }

        public SmartPhone() : this("+70000000", "Pixel", 2022)
        {    
        }

        public SmartPhone(string number, string name, int diagonal) : base(number, name, diagonal)
        {
            apps = new List<Application>();
        }

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
        public virtual void InstallApp(Application app)
        {
            apps.Add(app);
        }

        public void StartApp(string appName)
        {
            foreach(Application app in apps)
            {
                if (app.Name == appName)
                {
                    app.RunApp();
                    return;
                }
            }
            Console.WriteLine($"No such application {appName}");
        }
    }
}