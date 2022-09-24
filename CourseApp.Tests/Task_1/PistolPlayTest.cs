namespace CourseApp.Tests.Task_1
{
    using System;
    using System.IO;
    using CourseApp.Task_1;
    using Xunit;

    [Collection("Sequential")]
    public class PistolPlayTest : IDisposable
    {
        private const string Inp1 = @"n
q";

        private const string Out1 = @"You have one semi-auto pistol : colt1911
Do you want to edit the pistol?
Write y(yes) or n(no)
Use Enter button for shoot, insert r in console for reload, insert q for quit
";

        private const string Inp2 = @"n



r
r
r


r
q
";

        private const string Out2 = @"You have one semi-auto pistol : colt1911
Do you want to edit the pistol?
Write y(yes) or n(no)
Use Enter button for shoot, insert r in console for reload, insert q for quit

RELOAD IMMEDIATELY!!!

RELOAD IMMEDIATELY!!!

RELOAD IMMEDIATELY!!!

Your pistol reloaded!

Your pistol reloaded!

Your pistol reloaded!

BANG!

BANG!

BANG!

Your pistol reloaded!
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
        public void QuitWithoutPlaying(string input, string expected)
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

        [Theory]
        [InlineData(Inp1, Out1)]
        public void ThreeShotWithoutAmmo_ThreeReload_ThreeShots_Reload_Quit(string input, string expected)
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
