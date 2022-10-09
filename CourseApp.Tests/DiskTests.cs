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
            Disk hdd = new HardDisk("WD", 500, 500, 2011);
            var tmp = hdd.Download(100);
            var result = hdd.Download(100);
            Assert.True(result == 200);
        }

        [Fact]
        public void Clearing_Clear100and50infoOn500DiskCapacity_150returned()
        {
            Disk hdd = new HardDisk("WD", 500, 500, 2011);
            hdd.Download(300);
            hdd.Clearing(100);
            var result = hdd.Clearing(50);
            Assert.True(result == 150);
        }

        [Fact]
        public void Constructor_returnedWD5502012()
        {
            Disk hdd = new HardDisk("WD", 550, 500, 2012);
            string result = hdd.DiskInfoShow();
            Assert.True(result == "WD 2012года: объем этогй модели равен 550");
        }

        [Fact]
        public void SpeedStatus()
        {
            Disk hdd = new HardDisk("WD", 550, 500, 2012);

            string result = hdd.SpeedStatus();
            Assert.True(result == "Speed dowanload is 500, slowly!");
        }

        [Fact]
        public void SpeedExeption()
        {
            HardDisk hdd = new HardDisk("WD", 550, 500, 2012);
            string expectedErrorMessage = "Speed incorrect";
            var ex = Assert.Throws<ArgumentException>(() => hdd.SpeedDownload = 700);
            Assert.Equal(expectedErrorMessage, ex.Message);
        }
    }
}
