namespace CourseApp.Tests
{
    using Xunit;

    public class GameCharactertest
    {
        [Theory]
        [InlineData(100, 20)]
        [InlineData(50, 50)]
        [InlineData(500, 1)]
        public void ConstructorParametersTest(int health, int damage)
        {
            var archer = new Archer(health, damage);
            var mage = new Mage(health, damage);
            bool condition = false;

            if (archer.Health == health && archer.Damage == damage && mage.Health == health && mage.Damage == damage)
            {
                condition = true;
            }

            Assert.True(condition);
        }

        [Fact]
        public void ConstructorPrivateFieldsTest()
        {
            var archer = new Archer(100, 20);
            var mage = new Mage(100, 20);
            bool condition = false;

            if (archer.Skill_One == "Быстрый выстрел" && archer.Skill_Two == "Морозная стрела" && archer.Skill_Three == "Крылья защиты" && archer.Ultimate == "Удар Грома" && archer.Weapon == "Лук")
            {
                condition = true;
            }

            Assert.True(condition);

            condition = false;

            if (mage.Skill_One == "Огненный шар" && mage.Skill_Two == "Ледянное копьё" && mage.Skill_Three == "Магический щит" && mage.Ultimate == "Созвучия пустоты" && mage.Weapon == "Магический посох")
            {
                condition = true;
            }

            Assert.True(condition);
        }

        [Fact]
        public void CharacterSkillsTest()
        {
            var archer = new Archer(100, 20);

            Assert.Equal(archer.GetCharacterSkills(), $"Первый скилл вашего класса это {archer.Skill_One}\nВторой скилл вашего класса это {archer.Skill_Two}\nТретий скилл вашего класса это {archer.Skill_Three}\nУльта вашего класса это {archer.Ultimate}");
        }

        [Fact]
        public void GetCharacterDamageTest()
        {
            var archer = new Archer(100, 20);

            Assert.Equal(archer.GetCharacterDamage(), $"Ваш урон - {archer.Damage}");
        }

        [Fact]
        public void GetCharacterWeaponsTest()
        {
            var archer = new Archer(100, 20);

            Assert.Equal(archer.GetCharacterWeapons(), $"Ваше оружие - это {archer.Weapon}");
        }

        [Fact]
        public void GetCharacterHealthTest()
        {
            var archer = new Archer(100, 20);

            Assert.Equal(archer.GetCharacterHealth(), $"Ваше здоровье - {archer.Health}");
        }

        [Fact]
        public void UseUltimateTest()
        {
            var archer = new Archer(100, 20);
            var mage = new Mage(100, 20);

            Assert.Equal(archer.GetUltimate(), $"Лучник использует - {archer.Ultimate}!!!!");
            Assert.Equal(mage.GetUltimate(), $"Маг использует - {mage.Ultimate}!!!!");
        }

        [Fact]
        public void ToStringTest()
        {
            var archer = new Archer(100, 20);
            var mage = new Mage(100, 20);

            Assert.Equal(archer.ToString(), $"Archer (Health = {archer.Health} Damage = {archer.Damage} Skill_One = {archer.Skill_One} Skill_Two = {archer.Skill_Two} Skill_Three = {archer.Skill_Three} Ultimate = {archer.Ultimate}");

            Assert.Equal(mage.ToString(), $"Archer (Health = {mage.Health} Damage = {mage.Damage} Skill_One = {mage.Skill_One} Skill_Two = {mage.Skill_Two} Skill_Three = {mage.Skill_Three} Ultimate = {mage.Ultimate}");
        }
    }
}
