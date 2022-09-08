namespace CourseApp
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            Computer cmp1 = new Computer("WD", 500, 2011);
            cmp1.Show();
            cmp1.HardDiskCapacity = 200;
            cmp1.Show();
            cmp1.HardDiskCapacity = 700;
            cmp1.Show();

            Computer cmp2 = new Computer("SG", 1300);
            cmp2.Show();
            cmp2.HardDiskCapacity = 1500;
            cmp2.ModelHardDisk = "WD";
            cmp2.Show();
            cmp2.HardDiskCapacity = 1200;
            cmp2.Show();
            cmp2.Download(500);
            cmp2.Clearing(300);
        }
    }
}
