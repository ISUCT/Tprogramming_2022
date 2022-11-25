namespace CourseApp
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            Disk wd = new Disk("WD", 550, 2012, 500);
            Computer cmp = new Laptop(wd, "custom", 1024);
            cmp.DiskInfoShow();
            cmp.Download(50);
            cmp.DiskInfoShow();
            cmp.ShowPla();
            cmp.FreeSpace();
            cmp.Clearing(50);
            cmp.ShowSpeedInfo();
            cmp.AddFreeSpace(500);
            cmp.DiskInfoShow();
        }
    }
}
