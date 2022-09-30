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
        public void TestCreatePlane()
        {
            var plane = new Plane( "Airbus", 700, 10000 );
            Assert.Equal("Airbus", plane.Name);
            Assert.Equal(700, plane.Speed);
            Assert.Equal(10000, plane.Height);
        }

// тесты скорости
        [Theory]
        [InlineData(900, 800, 800)]
        [InlineData(900, -1, 700)]
        [InlineData(900, 2000, 700)]
        public void TestSpeed(int initial,int change, int expected)
        {
            var plane= new Plane("Airbus", initial, 0);
            Assert.Equal(initial, plane.Speed);
            plane.Speed = change;
            Assert.Equal(expected, plane.Speed);
        }

// тесты высоты
        [Theory]
        [InlineData(11000, 9000, 9000)]
        [InlineData(11000, -1, 10000)]
        [InlineData(11000, 20000, 10000)]
        public void TestHeight(int initial,int change, int expected)
        {
            var plane= new Plane("Airbus", 0, initial);
            Assert.Equal(initial, plane.Height);
            plane.Height = change;
            Assert.Equal(expected, plane.Height);
        }

// тесты Диагонали
        [Theory]
        [InlineData(9.4, 6.4, 6.4)]
        [InlineData(8.5, -1, 7.1)]
        // [InlineData(3.4, 28, 7.1)]
        public void TestDiagonal(double initial, double change, double expected)
        {
            var plane= new Copter(initial);
            Assert.Equal(initial, plane.Diagonal);
            plane.Diagonal = change;
            Assert.Equal(expected, plane.Diagonal);
        }
    }
}