namespace CourseApp.Tests
{
    using Xunit;

    public class CharacterTest
    {
        [Fact]

        public void TestGur()
        {
            var guard = new Guardian("Leo", "zweihender", 95);
            Assert.Equal("zweihender", guard.TypeOfWeapon);
            Assert.Equal(95, guard.Lvl);
        }

        [Fact]

        public void TestMag()
        {
            var magian = new TheMagian("Rise", "CristalStaff", 85);
            Assert.Equal("Rise", magian.Name);
            Assert.Equal("CristalStaff", magian.TypeOfWeapon);
            Assert.Equal(85, magian.Lvl);
        }

        [Fact]

        public void TestArcher()
        {
            var archer = new Archer("Azir", "Black Onion", 79);
            Assert.Equal("Azir", archer.Name);
            Assert.Equal("Black Onion", archer.TypeOfWeapon);
            Assert.Equal(79, archer.Lvl);
        }

        [Fact]

        public void TestArcherGetInfo()
        {
            var arch = new Archer("Azir", "Black Onion", 79);
            var res = arch.GetInfo();
            Assert.Equal("Я заступил на службу в 12:00 ", res);
            Character archer = arch; // ссылка типа базового класса на дочерний
            Assert.Equal(res, archer.GetInfo());
        }

        [Fact]

        public void TestGuardianGetInfo()
        {
            var guar = new Guardian("Leo", "zweihender", 95);
            var rs = guar.GetInfo();
            Assert.Equal("Я работаю в элитных войсках короля Людовика 2 ", rs);
            Character guard = guar;
            Assert.Equal(rs, guard.GetInfo());
        }

        [Fact]

        public void TestTheMagianGetInfo()
        {
            var mag = new TheMagian("Rise", "CristalStaff", 85);
            var result = mag.GetInfo();
            Assert.Equal("Я служу для защиты нашего прекрасного замка ", result);
            Character magian = mag;
            Assert.Equal(result, magian.GetInfo());
        }
    }
}
