namespace CourseApp
{
    using System;

    public abstract class Computer
    {
        private Disk hdd;

        private string computerModel;

        public Computer(Disk hardDrive, string computerModel)
        {
            hdd = hardDrive;
            ComputerModel = computerModel;
        }

        public Disk Hdd
        {
            get
            {
                return hdd;
            }

            set
            {
                hdd = value;
            }
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

        public void AddInfoOnHdd(string modelDisk, int diskCapacity, int speedDownload, int yearOfRelease)
        {
            hdd = new Disk(modelDisk, diskCapacity, yearOfRelease, speedDownload);
        }

        public abstract void AddFreeSpace(int freeSpace);

        public void SetInfoDisk(string modelDisk, int diskCapacity, int yearOfRelease)
        {
            hdd.ModelDisk = modelDisk;
            hdd.DiskCapacity = diskCapacity;
            hdd.YearOfRelease = yearOfRelease;
        }

        public void ShowPla()
        {
            System.Console.WriteLine(hdd.FilledPlace);
        }

        public void ShowSpeedInfo()
        {
            System.Console.WriteLine(this.hdd.DSpeed);
        }

        public int GetFreeSpase()
        {
            return hdd.DiskCapacity - hdd.FilledPlace;
        }

        public void FreeSpace()
        {
            System.Console.WriteLine($"Свободного местра на диске: {GetFreeSpase()}");
        }

        public virtual string GetDiskInfoShow()
        {
            return $"{this.hdd.ModelDisk} {this.hdd.YearOfRelease}года: объем этогй модели равен {hdd.DiskCapacity}";
        }

        public void DiskInfoShow()
        {
            System.Console.WriteLine(GetDiskInfoShow());
        }

        public int Download(int quantity)
        {
            if (quantity <= this.hdd.DiskCapacity - this.hdd.FilledPlace)
            {
                this.hdd.FilledPlace = this.hdd.FilledPlace + quantity;
                Console.WriteLine($"Вы заполнили диск на: {quantity} ГБ, осталось {this.hdd.DiskCapacity - this.hdd.FilledPlace} ГБ свободного места ");
                return this.hdd.FilledPlace;
            }
            else
            {
                Console.WriteLine($"Не хватает места для загрузки");
                return 0;
            }
        }

        public int Clearing(int quantity)
        {
            if (quantity <= this.hdd.FilledPlace)
            {
                this.hdd.FilledPlace = this.hdd.FilledPlace - quantity;
                Console.WriteLine($"Вы очистили диск на: {quantity} ГБ, стало {this.hdd.DiskCapacity - this.hdd.FilledPlace} ГБ свободного места ");
                return this.hdd.FilledPlace;
            }
            else
            {
                Console.WriteLine($"Количество очищаемого привышает количество содержимого");
                return 0;
            }
        }
    }
}