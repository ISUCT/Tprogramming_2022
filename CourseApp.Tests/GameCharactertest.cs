namespace CourseApp.Tests
{
    using Xunit;

    public class GameCharactertest
    {
        [Theory]
        [InlineData(100, 20)]
        [InlineData(50, 50)]
        [InlineData(500, 1)]
        public void ConstructorParametersArcherTest(int health, int damage)
        {
            var archer = new Archer(health, damage);

            Assert.Equal(health, archer.Health);
            Assert.Equal(damage, archer.Damage);
        }

        [Theory]
        [InlineData(100, 20)]
        [InlineData(50, 50)]
        [InlineData(500, 1)]
        public void ConstructorParametersMageTest(int health, int damage)
        {
            var mage = new Mage(health, damage);

            Assert.Equal(health, mage.Health);
            Assert.Equal(damage, mage.Damage);
        }

        [Fact]
        public void ConstructorFieldsArcherTest()
        {
            var archer = new Archer(100, 20);

            Assert.Equal("Удар Грома", archer.Skill);
            Assert.Equal("Лук", archer.Weapon);
        }

        [Fact]
        public void ConstructorFieldsMageTest()
        {
            var mage = new Mage(100, 20);

            Assert.Equal("Созвучия пустоты", mage.Skill);
            Assert.Equal("Магический посох", mage.Weapon);
        }

        [Fact]
        public void DropWeaponArcherTest()
        {
            var archer = new Archer(100, 20);

            archer.DropWeapon();

            Assert.Equal("-", archer.Weapon);
        }

        [Fact]
        public void DropWeaponMageTest()
        {
            var mage = new Mage(100, 20);

            mage.DropWeapon();

            Assert.Equal("-", mage.Weapon);
        }

        [Fact]
        public void ToStringArcherTest()
        {
            var archer = new Archer(100, 20);

            Assert.Equal(archer.ToString(), $"Archer (Health = {archer.Health} Damage = {archer.Damage} Skill = {archer.Skill} Weapon = {archer.Weapon}");
        }

        [Fact]
        public void ToStringMageTest()
        {
            var mage = new Mage(100, 20);

            Assert.Equal(mage.ToString(), $"Mage (Health = {mage.Health} Damage = {mage.Damage} Skill = {mage.Skill} Weapon = {mage.Weapon}");
        }
    }
}
