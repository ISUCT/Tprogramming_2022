namespace CourseApp
{
    public abstract class Environment
    {
        public Environment(string why,  string role, string size, string material)
        {
            Why = why;
            Role = role;
            Size = size;
            Material = material;
        }
        public string Why { get; set; }

        public string Role { get; set; }

        public string Size { get; set; }

        public string Material { get; set; }
    }
}

