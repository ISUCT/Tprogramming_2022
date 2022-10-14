namespace CourseApp;
using System;

public class Disk
{
    private int diskCapacity;

    private int yearOfRelease;

    private string modelDisk;

    private int filledPlace;

    private int dSpeed;

    public Disk()
    : this("WD", 0, 2015, 500)
    {
    }

    public Disk(string modelDisk, int diskCapacity, int yearOfRelease, int dSpeed)
    {
        ModelDisk = modelDisk;
        DiskCapacity = diskCapacity;
        YearOfRelease = yearOfRelease;
        DSpeed = dSpeed;
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

    public int DSpeed
    {
        get
        {
            return dSpeed;
        }

        set
        {
             if (value > 100 && value < 600)
            {
                  dSpeed = value;
            }
            else
            {
                throw new ArgumentException("Speed incorrect");
            }
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

    public int FilledPlace
    {
        get
        {
            return filledPlace;
        }

        set
        {
            this.filledPlace = value;
        }
    }
}
