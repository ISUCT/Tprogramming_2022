namespace CourseApp.Tests.Task_1
{
    using System;
    using System.IO;
    using CourseApp.Task_1;
    using Xunit;

    [Collection("Sequential")]
    public class PistolEditTest : IDisposable
    {
        private const string Inp1 = @"y
ttt
test t t
test test -25
auto test 15
q";

        private const string Out1 = @"You have one semi-auto pistol : colt1911
Do you want to edit the pistol?
Write y(yes) or n(no)
Enter, separated by a space, the type of shooting, the name of pistol and the maximum count of ammo in the magazine
Example: auto glock18 33
Incorrect input, try again!
Incorrect max ammo, use numbers!
Incorrect max ammo, use numbers more then 0, try again!
Use Enter button for shoot, insert r in console for reload, insert q for quit
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
            Game.Start();

            // assert
            var output = stringWriter.ToString();
            Assert.Equal($"{expected}", output);
        }
    }
}
