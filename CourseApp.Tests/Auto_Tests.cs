namespace CourseApp.Tests
{
    using Xunit;

    public class Auto_Tests
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }

        [Fact]
        public void TestConstructor()
        {
            var car = new Auto();
            Assert.Equal("Car", car.Name);
            Assert.Equal(45, car.Speed);
            Assert.Equal(80, car.LoadingCapacity);
        }

        [Fact]
        public void TestOk()
        {
            var car = new Auto();
            car.Speed = 50;
            Assert.Equal(50, car.Speed);
        }

        [Fact]
        public void TestBadSpeedLessThanZero()
        {
            var car = new Auto();
            car.Speed = -26;
            Assert.Equal(35, car.Speed);
        }

        [Fact]
        public void TestRide()
        {
        }

        [Fact]
        public void TestStop()
        {
        }

        [Fact]
        public void TestToString()
        {
        }
    }
}
