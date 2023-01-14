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

        [Fact]
        public void DogTest()
        {
            var dog = new Dog("Рэкс", "черный", 6);
            var expectedText = @"   черный пёс Рэкс
     ,-.___,-.
    \\_/_ _\\_/
       )O_O(
      { (_) }
       `-^-'
";
            Assert.Equal(expectedText, dog.GetInfo());
        }

        [Fact]
        public void CatTest()
        {
            var cat = new Cat("Гаф", "чёрный", 5);
            var expectedText = @"  чёрный котёнок Гаф
       /\_/\
      ( o.o )
       > ^ <";
            Assert.Equal(expectedText, cat.GetInfo());
        }
    }
}