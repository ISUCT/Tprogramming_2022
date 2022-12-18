namespace CourseApp.Tests.Task_one
{
    using System;
    using System.IO;
    using CourseApp.Task_one;
    using Xunit;

    [Collection("Sequential")]
    public class CountryTests : IDisposable
    {
        private const string Inp1 = "England 121321 3213";

        private const string Out1 = @"The country of England has a population of 121321 people and an area of 3213 km^2
Incorrect value of population.
Incorrect value of area.
The country of England has a population of 121321 people and an area of 15 km^2
";

        public void Dispose()
        {
            var standardOut = new StreamWriter(Console.OpenStandardOutput());
            standardOut.AutoFlush = true;
            var standardIn = new StreamReader(Console.OpenStandardInput());
            Console.SetOut(standardOut);
            Console.SetIn(standardIn);
        }

        [Theory]
        [InlineData(Inp1, Out1)]
        public void EditingWithAndWithoutErorrs(string input, string expected)
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            var stringReader = new StringReader(input);
            Console.SetIn(stringReader);

            // act
            string[] buff = input.Split(' ');
            Country one = new Country(buff[0], int.Parse(buff[1]), int.Parse(buff[2]));
            one.Info();
            one.Population = -15;
            one.Square = 0;
            one.Square = 15;
            one.Info();

            // assert
            var output = stringWriter.ToString();
            Assert.Equal($"{expected}", output);
        }
    }
}