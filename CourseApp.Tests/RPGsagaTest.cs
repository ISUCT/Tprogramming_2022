namespace RPGsagaApp.Tests
{
    using RPGsagaApp;
    using Xunit;

    public class RPGsagaTest
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }

        [Fact]
        public void TestConstructor()
        {
            var hero1 = new Knight(50, 20, "(Рыцарь) Ричард");
            Assert.Equal(50, hero1.Health);
            Assert.Equal(20, hero1.Power);
            Assert.Equal("(Рыцарь) Ричард", hero1.Name);

            var hero2 = new Archer(50, 20, "(Лучник) Леголас");
            Assert.Equal(50, hero2.Health);
            Assert.Equal(20, hero2.Power);
            Assert.Equal("(Лучник) Леголас", hero2.Name);

            while ((hero1.Health > 0) && (hero2.Health > 0))
            {
                hero1.Action();
                hero2.Damage();
                if (hero2.Health <= 0)
                {
                    break;
                }

                hero2.Action();
                hero1.Damage();
                if (hero1.Health <= 0)
                {
                    break;
                }
            }
        }

        [Fact]
        public void TestConstructor2()
        {
            var hero1 = new Knight(50, 20, "(Рыцарь) Зигфрид");
            Assert.Equal(50, hero1.Health);
            Assert.Equal(20, hero1.Power);
            Assert.Equal("(Рыцарь) Зигфрид", hero1.Name);

            var hero2 = new Magician(50, 20, "(Маг) Дамблдор");
            Assert.Equal(50, hero2.Health);
            Assert.Equal(20, hero2.Power);
            Assert.Equal("(Маг) Дамблдор", hero2.Name);

            while ((hero1.Health > 0) && (hero2.Health > 0))
            {
                hero2.Action();
                hero1.Damage();
                if (hero1.Health <= 0)
                {
                    break;
                }

                hero1.Action();
                hero2.Damage();
                if (hero2.Health <= 0)
                {
                    break;
                }
            }
        }

        [Fact]

        public void TestConstructorFinal()
        {
        }
    }
}
