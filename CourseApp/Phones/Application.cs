namespace Phones
{
    public abstract class Application : IApplication
    {
        public Application(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public abstract void InstallApp();

        public abstract void RunApp();
    }
}