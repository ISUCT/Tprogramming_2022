namespace CourseApp.Tests
{
    using Xunit;

    public class CountryTest
    {
        [Fact]
        public void RussiaTest()
        {
            var rus = new Country("Russia", "Moscow", 17000);
            Assert.Equal("Russia", rus.Name);
            Assert.Equal("Moscow", rus.Capital);
            Assert.Equal(17000, rus.Square);
        }

        [Fact]
        public void CanadaTest()
        {
            var can = new Country("Canada", "Ottawa", 10000);
            Assert.Equal("Canada", can.Name);
            Assert.Equal("Ottawa", can.Capital);
            Assert.Equal(10000, can.Square);
        }
    }
}
