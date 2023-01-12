namespace CourseApp.Tests
{
    using Character;
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

        [Fact]
        public void TestTheMagianToString()
        {
            var mag = new TheMagian("Rise", "CristalStaff", 85);
            var result = mag.ToString();
            Assert.Equal("Какой же красивый замок", result);
            Character magian = mag;
            Assert.Equal(result, magian.ToString());
        }

        [Fact]

        public void TestArcherToString()
        {
            var ar = new Archer("Azir", "Black Onion", 79);
            var resul = ar.ToString();
            Assert.Equal("Ура у меня всё хорошо!", resul);
            Character arc = ar;
            Assert.Equal(resul, arc.ToString());
        }

        [Fact]

        public void TestGuardianToString()
        {
            var gurd = new Guardian("Leo", "zweihender", 95);
            var resul = gurd.ToString();
            Assert.Equal("Как хорошо, что меня ещё не уволили)", resul);
            Character gur = gurd;
            Assert.Equal(resul, gur.ToString());
        }

        [Fact]

        public void TestGuardianGuild()
        {
            var guard = new Guardian("Leo", "zweihender", 95);
            var result = guard.Guild();
            Assert.Equal("я состою в гильдии Пылающий Вепрь", result);
            Character gur = guard;
            Assert.Equal(result, gur.Guild());
        }

        [Fact]

        public void TestArcherGuild()
        {
            var archer = new Archer("Azir", "Black Onion", 79);
            var resul = archer.Guild();
            Assert.Equal("я состою в гильдии Милость Дриады", resul);
            Character arc = archer;
            Assert.Equal(resul, arc.Guild());
        }

        [Fact]
        public void TestTheMagianGuild()
        {
            var mag = new TheMagian("Rise", "CristalStaff", 85);
            var result = mag.Guild();
            Assert.Equal("я состою в гильдии Банши", result);
            Character magian = mag;
            Assert.Equal(result, magian.Guild());
        }
    }
}
