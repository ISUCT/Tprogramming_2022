namespace CourseApp.Tests
{
    using Xunit;

    public class CountryTest
    {
        [Fact]
        public void RussiaTest()
        {
            var rus = new Russia("Russia", "Moscow", 17000);
            Assert.Equal("Russia", rus.Name);
            Assert.Equal("Moscow", rus.Capital);
            Assert.Equal(17000, rus.Square);
        }

        [Fact]
        public void CanadaTest()
        {
            var can = new Canada("Canada", "Ottawa", 10000);
            Assert.Equal("Canada", can.Name);
            Assert.Equal("Ottawa", can.Capital);
            Assert.Equal(10000, can.Square);
        }

        [Fact]
        public void USATest()
        {
            var usa = new USA("USA", "Washington", 7000);
            Assert.Equal("USA", usa.Name);
            Assert.Equal("Washington", usa.Capital);
            Assert.Equal(7000, usa.Square);
        }

        [Fact]
        public void RussiaCountryAgeTest()
        {
            var rus = new Russia("Russia", "Moscow", 17000);
            var result = rus.CountryAge();
            Assert.Equal("1159 years ", result);
        }

        [Fact]
        public void CanadaCountryAgeTest()
        {
            var can = new Canada("Canada", "Ottawa", 10000);
            var result = can.CountryAge();
            Assert.Equal("155 years ", result);
        }

        [Fact]
        public void USACountryAgeTest()
        {
            var usa = new USA("USA", "Washington", 7000);
            var result = usa.CountryAge();
            Assert.Equal("245 years ", result);
        }

        [Fact]
        public void RussiaPresidentsNameTest()
        {
            var rus = new Russia("Russia", "Moscow", 17000);
            var result = rus.PresidentsName();
            Assert.Equal("Putin ", result);
        }

        [Fact]
        public void CanadaPresidentsNameTest()
        {
            var can = new Canada("Canada", "Ottawa", 10000);
            var result = can.PresidentsName();
            Assert.Equal("Carl ", result);
        }

        [Fact]
        public void USAPresidentsNameTest()
        {
            var usa = new USA("USA", "Washington", 7000);
            var result = usa.PresidentsName();
            Assert.Equal("Biden ", result);
        }

        [Fact]
        public void RussiaNameOfElementTest()
        {
            var rus = new Russia("Russia", "Moscow", 17000);
            var result = rus.NameOfElement();
            Assert.Equal("Russia: ", result);
        }

        [Fact]
        public void CanadaNameOfElementTest()
        {
            var can = new Canada("Canada", "Ottawa", 10000);
            var result = can.NameOfElement();
            Assert.Equal("Canada: ", result);
        }

        [Fact]
        public void USANameOfElementTest()
        {
            var usa = new USA("USA", "Washington", 7000);
            var result = usa.NameOfElement();
            Assert.Equal("USA: ", result);
        }

        [Fact]
        public void RussiaToStringTest()
        {
            var rus = new Russia("Russia", "Moscow", 17000);
            var result = rus.ToString();
            Assert.Equal("Moscow is a capital of Russia", result);
        }

        [Fact]
        public void CanadaToStringTest()
        {
            var can = new Canada("Canada", "Ottawa", 10000);
            var result = can.ToString();
            Assert.Equal("Ottawa is a capital of Canada", result);
        }

        [Fact]
        public void USANameToStringTest()
        {
            var usa = new USA("USA", "Washington", 7000);
            var result = usa.ToString();
            Assert.Equal("Washington is a capital of USA", result);
        }
    }
}