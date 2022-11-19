namespace CourseApp.Tests
{
    using System;
    using CourseApp;
    using Xunit;

    public class DemoTest
    {
        [Fact]
        public void Test1()
        {
            Gun g = new Gun();
            string expect = "macerov";
            Assert.Equal(expect, g.Model);
        }

        [Fact]
        public void Test2()
        {
            Gun g = new Gun();
            decimal expect = 12.12m;
            Assert.Equal(expect, g.Kalibr);
        }

        [Fact]
        public void Test3()
        {
            Gun g = new Gun();
            string expect = "lll";
            Assert.Equal(expect, g.Years);
        }
    }
}
