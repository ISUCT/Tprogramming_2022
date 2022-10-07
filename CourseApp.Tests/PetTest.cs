namespace CourseApp.Tests
{
    using CourseApp.Entities;
    using Xunit;

    public class PetTest
    {
        [Fact]
        public void BirdTest()
        {
            var bird = new Bird("Кеша", "зелёный", 5);
            var expectedText = @"  зелёный попугай Кеша
           \\
   \\      (o>
   (o>     //\
  _(()_____V_/_____
   ||      ||
           ||";
            Assert.Equal(expectedText, bird.GetInfo());
        }
    }
}