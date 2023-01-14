namespace CourseApp.RPGSaga.Interface
{
    public interface IAbility
    {
        public string Name { get; }

        public double Damage { get; set; }

        public int UsageLimit { get; set; }

        public bool SkippingMove { get; set; }

        public bool IsFire { get; }

        public int Duration { get; set; }
    }
}