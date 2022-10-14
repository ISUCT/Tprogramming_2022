namespace CourseApp
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            Computer cmp = new Laptop("WD", 550, 2012, 500, "castom", 1980);
            cmp.DiskInfoShow();
            cmp.Download1(50);
            cmp.DiskInfoShow();
            cmp.Showpla();
            cmp.FreeSpace();
            cmp.Clearing(50);
            cmp.ShowSpeedInfo();
            cmp.AddFreeSpace(500);
            cmp.DiskInfoShow();
        }
    }
}
