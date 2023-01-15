namespace CourseApp.Tests
{
    using CourseApp;
    using Xunit;

    public class DemoTest
    {
        private Knight k;
        private Blind b;
        private Attack a;

        public DemoTest()
        {
            k = new Knight(20, 20, "knight");
            b = new Blind();
            a = new Attack(5);
        }

        [Fact]
        public void Test1()
        {
            Assert.Equal(20, k.Health);
            Assert.Equal(20, k.Damage);
            Assert.Equal("knight", k.Name);
            Assert.Equal(new Attack(20).Damage, k.ActiveAbility.Damage);
        }

        [Fact]
        public void Test2()
        {
            k.AddEffect(b);
            Assert.Equal(0, k.CheckState());
            Assert.Equal(new StepSkip().Damage, k.MakeStep().Damage);
        }

        [Fact]
        public void Test3()
        {
            k.AddEffect(a);
            Assert.Equal(5, k.CheckState());
        }

        [Fact]
        public void Test3()
        {
            k.Refresh();
            Assert.Equal(0, k.CheckState());
        }
    }
}
