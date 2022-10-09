namespace CourseApp;
using System;

public class HardDisk : Disk
{
    private float speedDownload;

    public HardDisk()
    : base("WD", 0, 2015)
    {
    }

    public HardDisk(string modelDisk, int diskCapacity, float speedDownload, int yearOfRelease)
    : base(modelDisk, diskCapacity, yearOfRelease)
    {
        SpeedDownload = speedDownload;
    }

    public float SpeedDownload
    {
        get
        {
            return speedDownload;
        }

        set
        {
            if (value > 100 && value < 600)
            {
                this.speedDownload = value;
            }
            else
            {
                throw new ArgumentException("Speed incorrect");
            }
        }
    }

    public override string SpeedStatus()
    {
        string result = $"Speed dowanload is {SpeedDownload}, slowly!";
        System.Console.WriteLine(result);
        return result;
    }
}