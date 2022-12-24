namespace CourseApp.Tests
{
    using Xunit;
    using Vehicles;

    public class TestMatch
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }

        [Fact]
        public void TestBattleWinner1()
        {
            var top = new Player("Knight", "top", 100, 10);
            var low = new Player("Knight", "low", 10, 1);
            var winner = Battle(top, low);
            Assert.Equal(top, winner);
        }
        public void TestBattleWinner2()
        {
            top = new Player("Knight", "top", 100, 10);
            low = new Player("Knight", "low", 10, 1);
            var winner = Battle(low, top);
            Assert.Equal(top, winner);
        }
    }
}