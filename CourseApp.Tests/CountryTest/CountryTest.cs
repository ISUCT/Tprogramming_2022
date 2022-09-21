namespace CourseApp.Tests
{
    using Xunit;

    public class CountryTest
    {
        [Fact]
        public void EmptryConstructorTest()
        {
            Country country = new Country();

            string countryName = "Vitalia";
            int countryPopulation = 3000;
            int countryGdp = 1000;
            bool result = false;


            if (country.CountryName == countryName && country.Gdp == countryGdp && country.Population == countryPopulation && country.HymnBehavior is Literary) {
                result = true;
            }

            Assert.True(result);
        }

        [Fact]
        public void OneParameterConstructorTest()
        {
            Country country = new Country("Kenva");

            string countryName = "Kenva";
            int countryPopulation = 3000;
            int countryGdp = 1000;
            bool result = false;


            if (country.CountryName == countryName && country.Gdp == countryGdp && country.Population == countryPopulation && country.HymnBehavior is Literary) {
                result = true;
            }

            Assert.True(result);
        }

        [Fact]
        public void TwoParameterConstructorTest()
        {
            Country country = new Country("Kenva", 20000);

            string countryName = "Kenva";
            int countryPopulation = 20000;
            int countryGdp = 1000;
            bool result = false;


            if (country.CountryName == countryName && country.Gdp == countryGdp && country.Population == countryPopulation && country.HymnBehavior is Literary) {
                result = true;
            }

            Assert.True(result);
        }

        [Fact]
        public void ThreeParameterConstructorTest()
        {
            Country country = new Country("Kenva", 20000, 5000);

            string countryName = "Kenva";
            int countryPopulation = 20000;
            int countryGdp = 5000;
            bool result = false;


            if (country.CountryName == countryName && country.Gdp == countryGdp && country.Population == countryPopulation) {
                result = true;
            }

            Assert.True(result);
        }

        [Fact]
        public void FourParameterConstructorTest()
        {
            Country country = new Country("Kenva", 20000, 5000, new Religic());

            string countryName = "Kenva";
            int countryPopulation = 20000;
            int countryGdp = 5000;
            bool result = false;


            if (country.CountryName == countryName && country.Gdp == countryGdp && country.Population == countryPopulation && country.HymnBehavior is Religic) {
                result = true;
            }

            Assert.True(result);
        }

        [Fact]
        public void PopulationCensusTest()
        {
            Country country = new Country("Balva", 10000, 5000, new National());

            bool result = country.Population == country.PopulationCensus();

            Assert.True(result);
        }

        [Fact]
        public void PerformHymnTest()
        {
            Country country = new Country("Balva", 10000, 5000, new National());

            bool result = country.PerformHymn().Equals("National");

            Assert.True(result);
        } 

        [Fact]
        public void PrintCountryInformationTest() 
        {   
            string countryName = "Balva";
            int countryPopulation = 10000;
            int countryGpd = 5000;
            IHymnBehavior countryHymnBehavior = new National();

            Country country = new Country(countryName, countryPopulation, countryGpd, countryHymnBehavior);
            
            bool result = country.PrintCountryInformation().Equals($"Country name is {countryName}, Gdp is {countryGpd}, Population is {countryPopulation}, Hymn is {countryHymnBehavior.HymnType}");

            Assert.True(result);
        }
    }
}
