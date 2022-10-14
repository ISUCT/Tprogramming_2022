namespace CourseApp
{
    using System;

    public class Laptop : Computer
    {
        private int permissionDisplay;

        public Laptop(string modelDisk, int diskCapacity, int yearOfRelease, int speedDownload, string computerModel, int permission)
         : base(modelDisk, diskCapacity, yearOfRelease, speedDownload, computerModel)
         {
            PermissionDisplay = permission;
         }

        public int PermissionDisplay
        {
            get
            {
                return permissionDisplay;
            }

            set
            {
                permissionDisplay = value;
            }
        }

        public override void AddFreeSpace(int freeSpace)
        {
            System.Console.WriteLine("no possibility");
        }

        public override string GetDiskInfoShow()
        {
            return $"В {ComputerModel} стоит ЖД модели: {this.Hdd.ModelDisk}, {this.Hdd.YearOfRelease}года: объем этогй модели равен {this.Hdd.DiskCapacity}. Разрешение экрана этой можели равно: {this.PermissionDisplay}";
        }
    }
}