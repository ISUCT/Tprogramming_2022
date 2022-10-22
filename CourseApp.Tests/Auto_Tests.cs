namespace AutoApp.Tests
{
    using AutoApp;
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
            Assert.Equal(45, car.Speed);
        }

        [Fact]
        public void TestRide()
        {
            var car = new Auto();
            car.Speed = 35;
            car.LoadingCapacity = 70;
            Assert.Equal($"Поехал автомобиль 35", car.Ride());
        }

        [Fact]
        public void TestStop()
        {
            var car = new Auto();
            car.Name = "Limousine";
            car.LoadingCapacity = 70;
            Assert.Equal("Остановился автомобиль", car.Stop());
        }

        [Fact]
        public void TestToString()
        {
            var car = new Auto();
            car.Name = "Limousine";
            car.Speed = 35;
            car.LoadingCapacity = 70;
            Assert.Equal($"Название: Limousine  Скорость: 35", car.Print());
        }

        [Fact]
        public void TestMinibus()
        {
            var car = new Minibus("Маршрутка");
            Assert.Equal("Маршрутка движется", car.Move());
        }

        [Fact]
        public void TestBus()
        {
            var car = new Bus("Автобус");
            Assert.Equal("Автобус движется", car.Move());
        }

        [Fact]
        public void TestTrolleybus()
        {
            var car = new Trolleybus("Троллейбус");
            Assert.Equal("Троллейбус движется", car.Move());
        }
    }
}
