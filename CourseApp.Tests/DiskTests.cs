namespace CourseApp.Tests
{
    using System;
    using CourseApp;
    using Xunit;

    public class DiskTests
    {
        [Fact]
        public void Download_Set100and100infoOn500DiskCapacity_200returned()
        {
            Disk wd = new Disk("WD", 550, 2012, 500);
            Computer cmp = new Laptop(wd, "custom", 1024);
            cmp.Download(100);
            var result = cmp.Download(100);
            Assert.True(result == 200);
        }

        [Fact]
        public void Clearing_Clear100and50infoOn500DiskCapacity_150returned()
        {
            Disk wd = new Disk("WD", 550, 2012, 500);
            Computer cmp = new Laptop(wd, "custom", 1024);
            cmp.Download(300);
            cmp.Clearing(100);
            var result = cmp.Clearing(50);
            Assert.True(result == 150);
        }

        [Fact]
        public void Constructor_returnedWD5502012()
        {
            Disk wd = new Disk("WD", 550, 2012, 500);
            System.Console.WriteLine();
            Computer cmp = new Laptop(wd, "custom", 1024);
            string result = cmp.GetDiskInfoShow();
            Assert.True(result == "В custom стоит ЖД модели: WD, 2012года: объем этогй модели равен 550. Разрешение экрана этой можели равно: 1024");
        }

        [Fact]
        public void SpeedExeption()
        {
            Disk hdd = new Disk("WD", 550, 2012, 500);
            string expectedErrorMessage = "Speed incorrect";
            var ex = Assert.Throws<ArgumentException>(() => hdd.DSpeed = 700);
            Assert.Equal(expectedErrorMessage, ex.Message);
        }
    }
}
