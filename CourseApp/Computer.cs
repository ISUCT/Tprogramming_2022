namespace CourseApp
{
    using System;

    public class Computer
    {
            private float hardDiskCapacity;

            private int yearOfRelease;

            private string modelHardDisk;

            private float freeSpace;

            public Computer(string modelHardDisk, float hardDiskCapacity, int yearOfRelease)
            {
                HardDiskCapacity = hardDiskCapacity;
                ModelHardDisk = modelHardDisk;
                YearOfRelease = yearOfRelease;
            }

            public Computer(string modelHardDisk, float hardDiskCapacity)
            {
                HardDiskCapacity = hardDiskCapacity;
                ModelHardDisk = modelHardDisk;
            }

            public string ModelHardDisk
            {
                get
                {
                    return modelHardDisk;
                }

                set
                {
                    this.modelHardDisk = value;
                }
            }

            public float HardDiskCapacity
            {
                get
                {
                    return hardDiskCapacity;
                }

                set
                {
                   if (value >= 100 && value <= 50000)
                    {
                        this.hardDiskCapacity = value;
                    }
                }
            }

            public int YearOfRelease
            {
                get
                {
                    return yearOfRelease;
                }

                set
                {
                    if (value >= 2000 && value <= 2022)
                    {
                        this.yearOfRelease = value;
                    }
                }
            }

            public float FreeSpace
            {
                get
                {
                    return freeSpace;
                }

                set
                {
                    this.freeSpace = value;
                }
            }

            public void Show()
            {
                System.Console.WriteLine($"{ModelHardDisk} {yearOfRelease}года: объем этогй модели равен {hardDiskCapacity}");
            }

            public void Download(float quantity)
            {
                this.FreeSpace = HardDiskCapacity - quantity;
                System.Console.WriteLine($"Вы заполнили диск на: {quantity} ГБ, осталось {this.FreeSpace} ГБ свободного места ");
            }

            public void Clearing(float quantity)
            {
                this.FreeSpace = this.FreeSpace + quantity;
                System.Console.WriteLine($"Вы очистили диск на: {quantity} ГБ, стало {this.FreeSpace} ГБ свободного места ");
            }
    }
}