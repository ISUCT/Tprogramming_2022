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
            Computer cmp = new Laptop("WD", 500, 2011, 500, "PC", 1980);
            cmp.Download1(100);
            var result = cmp.Download1(100);
            Assert.True(result == 200);
        }

        [Fact]
        public void Clearing_Clear100and50infoOn500DiskCapacity_150returned()
        {
            Computer cmp = new Laptop("WD", 500, 2011, 500, "PC", 1980);
            cmp.Download1(300);
            cmp.Clearing(100);
            var result = cmp.Clearing(50);
            Assert.True(result == 150);
        }

        [Fact]
        public void Constructor_returnedWD5502012()
        {
            Computer cmp = new Laptop("WD", 550, 2012, 500, "PC", 1980);
            string result = cmp.GetDiskInfoShow();
            Assert.True(result == "WD 2012года: объем этогй модели равен 550");
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
