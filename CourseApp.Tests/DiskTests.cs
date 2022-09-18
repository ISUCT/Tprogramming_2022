namespace CourseApp.Tests
{
    using CourseApp;
    using Xunit;

    public class DiskTests
    {
        [Fact]
        public void Download_Set100and100infoOn500DiskCapacity_200returned()
        {
            Disk hdd = new Disk("WD", 500, 2011);
            var tmp = hdd.Download(100);
            var result = hdd.Download(100);
            Assert.True(result == 200);
        }

        [Fact]
        public void Clearing_Clear100and50infoOn500DiskCapacity_150returned()
        {
            Disk hdd = new Disk("WD", 500, 2011);
            hdd.Download(300);
            hdd.Clearing(100);
            var result = hdd.Clearing(50);
            Assert.True(result == 150);
        }
    }
}
