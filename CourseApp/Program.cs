namespace CourseApp
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            Computer cmp = new Computer("WD", 550, 2012, "cool");
            cmp.GetInfoForHdd();
            cmp.DownloadInfoForHdd(100);
            cmp.ClearInfoForHdd(200);
        }
    }
}
