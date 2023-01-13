namespace CourseApp.Tests
{
    using Xunit;

    public class TestClass
    {
        [Fact]
        public void GetInfo_SampleData_CorrectInfo()
        {
            Rabbit rabbit = new Rabbit(3, "Black", "female");
            Assert.Equal(
                @$"Animal: Rabbit
Age: 3
Gender: female
Color: Black
Name: {rabbit.Name}", rabbit.GetInfo());
        }

        [Fact]
        public void SwitchName_Name_CorrectName()
        {
            Rabbit rabbit = new Rabbit(3, "Black", "female");
            rabbit.SwitchName("Alice");
            Assert.Equal("Alice", rabbit.Name);
        }

        [Fact]
        public void Move_CallingMethod_CorrectMovementData()
        {
            Rabbit rabbit = new Rabbit(3, "Black", "female");
            Assert.Equal("Rabbit jump", rabbit.Move());
        }

        [Fact]
        public void Eat_SameEatData_CorrectEatData()
        {
            Rabbit rabbit = new Rabbit(3, "Black", "female");
            Assert.Equal("Rabbit to eat Clover", rabbit.Eat("Clover"));
        }

        [Fact]
        public void Constructor_SampleData_CorrectInfo()
        {
            Rabbit rabbit = new Rabbit(3, "Black", "female");
            Assert.Equal(
                @$"Animal: Rabbit
Age: 3
Gender: female
Color: Black
Name: No_Name", rabbit.GetInfo());
        }
    }
}
