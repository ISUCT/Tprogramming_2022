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
        public void TestCreatePhone()
        {
            var phone = new Phone("Name", -1);
            Assert.Equal("Name", phone.Name);
            Assert.Equal(0, phone.Diagonal);
        }
       [Theory]
       [InlineData(5, 12, 12)]
       [InlineData(5, -1, 5)]
       [InlineData(5, 20, 5)]
        public void TestDiagonal(int initial,int change, int expected)
        {
            var phone = new Phone("Name", initial);
            Assert.Equal(5, phone.Diagonal);
            phone.Diagonal = change;
            Assert.Equal(expected, phone.Diagonal);
        }
    }
}
