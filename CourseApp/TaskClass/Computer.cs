namespace CourseApp
{
    using System;

    public class Computer
    {
        private Disk hdd = new HardDisk();

        private string computerModel;

        public Computer(string modelDisk, int diskCapacity, float speedDownload, int yearOfRelease, string computerModel)
        {
            hdd = new HardDisk(modelDisk, diskCapacity, speedDownload, yearOfRelease);
            ComputerModel = computerModel;
        }

        public string ComputerModel
        {
            get
            {
                return computerModel;
            }

            set
            {
                if (value != " ")
                {
                    this.computerModel = value;
                }
            }
        }

        public void AddInfoOnHdd(string modelDisk, int diskCapacity, float speedDownload, int yearOfRelease)
        {
            hdd = new HardDisk(modelDisk, diskCapacity, speedDownload, yearOfRelease);
        }

        public void GetInfoForHdd()
        {
            this.hdd.DiskInfoShow();
        }

        public void DownloadInfoForHdd(int quantity)
        {
            this.hdd.Download(quantity);
        }

        public void ClearInfoForHdd(int quantity)
        {
            this.hdd.Clearing(quantity);
        }

        public void AddFreeSpace(int freeSpace)
        {
            hdd.DiskCapacity = hdd.DiskCapacity + freeSpace;
        }

        public void ShowSpeedInfo()
        {
            this.hdd.SpeedStatus();
        }
    }
}