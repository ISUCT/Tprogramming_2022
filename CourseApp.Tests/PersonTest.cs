namespace CourseApp.Tests
{
    using CourseApp;
    using Xunit;

    public class PersonTest
    {
        [Fact]
        public void TestMiddleAge_Set133()
        {
            Person person = new Person(133);
            string result = person.Midlle_Age();
            Assert.True(result == "Input error in age;");
        }

        [Fact]
        public void TestMiddleHeight_Set333()
        {
            Person person = new Person(20, 333, 80);
            string result = person.Average_Height();
            Assert.True(result == "Input error in height;");
        }

        [Fact]
        public void TestAverageWeight_Set444()
        {
            Person person = new Person(20, 199, 444);
            string result = person.Average_Weight();
            Assert.True(result == "Input error in weight;");
        }

        [Fact]
        public void TestPropeprtyAge_Set999()
        {
            Person person = new Person(999);
            int result = person.Age;
            Assert.True(result == 0);
        }

        [Fact]
        public void TestPropeprtyHeight_Set888()
        {
            Person person = new Person(888);
            int result = person.Height;
            Assert.True(result == 0);
        }

        [Fact]
        public void TestPropeprtyWeight_Set777()
        {
            Person person = new Person(777);
            float result = person.Weight;
            Assert.True(result == 0);
        }
    }
}