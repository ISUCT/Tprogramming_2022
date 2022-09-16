namespace CourseApp.Tests
{
    using Xunit;

    public class DemoTest
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }

        [Fact]
        public void TestDefaultConstructor()
        {
            var phone = new Phone();
            Assert.Equal(1, phone.Version);
            Assert.Equal("+000000000", phone.Number);
        }

        [Fact]
        public void TestVersionOk()
        {
            var phone = new Phone();
            phone.Version = 5;
            Assert.Equal(5, phone.Version);
        }

        [Fact]
        public void TestBadVersionLessThanZero()
        {
            var phone = new Phone();
            phone.Version = -5;
            Assert.Equal(1, phone.Version);
        }

        [Fact]
        public void TestBadVersionGtThan20()
        {
            var phone = new Phone();
            phone.Version = 21;
            Assert.Equal(1, phone.Version);
        }
    }
}
