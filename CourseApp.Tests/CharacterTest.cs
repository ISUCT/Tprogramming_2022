namespace CourseApp.Tests
{
    using Xunit;

    public class CharacterTest
    {
        [Fact]

        public void TestGur()
        {
            var gur = new Character("zweihender", 60);
            Assert.Equal("zweihender", gur.TypeOfWeapon);
            Assert.Equal(60, gur.Lvl);
        }

        [Fact]

        public void TestMag()
        {
            var mag = new Character("Magian", "crystal staf", 58);
            Assert.Equal("Magian", mag.Clas);
            Assert.Equal("crystal staf", mag.TypeOfWeapon);
            Assert.Equal(58, mag.Lvl);
        }
    }
}
