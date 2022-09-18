namespace CourseApp
{
    using System;

    public class Computer
    {
        private Disk hdd = new Disk();
        private string computerModel;

        public Computer(string modelDisk, int diskCapacity, int yearOfRelease, string computerModel)
        {
            hdd = new Disk("WD", 500, 2011);
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

        public void AddInfoOnHdd(string modelDisk, int diskCapacity, int yearOfRelease)
        {
            hdd = new Disk(modelDisk, diskCapacity, yearOfRelease);
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
    }
}