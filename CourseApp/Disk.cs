namespace CourseApp;
using System;

public class Disk
{
    private int diskCapacity;

    private int yearOfRelease;

    private string modelDisk;

    private int filledPlace;

    public Disk(string modelDisk, int diskCapacity, int yearOfRelease)
    {
        ModelDisk = modelDisk;
        DiskCapacity = diskCapacity;
        YearOfRelease = yearOfRelease;
    }

    public Disk()
    {
        ModelDisk = " ";
        DiskCapacity = 0;
        YearOfRelease = 0;
    }

    public string ModelDisk
    {
        get
        {
            return modelDisk;
        }

        set
        {
            this.modelDisk = value;
        }
    }

    public int DiskCapacity
    {
        get
        {
            return diskCapacity;
        }

        set
        {
            if (value >= 100 && value <= 50000)
            {
                this.diskCapacity = value;
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

    public void DiskInfoShow()
    {
        Console.WriteLine($"{ModelDisk} {yearOfRelease}года: объем этогй модели равен {diskCapacity}");
    }

    public int Download(int quantity)
    {
        if (quantity <= this.diskCapacity - filledPlace)
        {
            this.filledPlace = this.filledPlace + quantity;
            Console.WriteLine($"Вы заполнили диск на: {quantity} ГБ, осталось {this.diskCapacity - this.filledPlace} ГБ свободного места ");
            return this.filledPlace;
        }
        else
        {
            Console.WriteLine($"Не хватает места для загрузки");
            return 0;
        }
    }

    public int Clearing(int quantity)
    {
        if (quantity <= filledPlace)
        {
            this.filledPlace = this.filledPlace - quantity;
            Console.WriteLine($"Вы очистили диск на: {quantity} ГБ, стало {this.diskCapacity - this.filledPlace} ГБ свободного места ");
            return this.filledPlace;
        }
        else
        {
            Console.WriteLine($"Количество очищаемого привышает количество содержимого");
            return 0;
        }
    }
}
