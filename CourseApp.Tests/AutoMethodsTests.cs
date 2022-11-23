namespace CourseApp.Tests
{
    using CourseApp.RPGSaga;
    using Xunit;

    public class AutoMethodsTests
    {
        [Fact]
        public void GetInfo_SetSampleData_ReturnCorrectInfo_Auto()
        {
            Transport auto = new Auto(4.9, 1.71, 2145, 333, 250, "Audi Q8");
            Assert.Equal(
                @"Info for Audi Q8
Weight: 2145 kg
Length: 4,9 m 
Height: 1,71 m
Power: 333 horsepower
Max Speed: 250 km\h", auto.GetInfo());
        }

        [Fact]
        public void CheckConstructor_SetSampleData_ReturnCorrectInfo_Auto()
        {
            Transport auto = new Auto();

            Assert.Equal(
                @"Info for Auto
Weight: 0 kg
Length: 0 m 
Height: 0 m
Power: 0 horsepower
Max Speed: 0 km\h", auto.GetInfo());
        }

        [Fact]
        public void Movement_CallMovementMethod_CorrectMove_Auto()
        {
            Transport auto = new Auto();
            Assert.Equal(ActionTypes.Move, auto.Movement());
        }

        [Fact]
        public void ToString_CheckStringPresentation_CorrectPresentationOfInstance()
        {
            Transport auto = new Auto(4.9, 1.71, 2145, 333, 250, "Audi Q8");
            Assert.Equal("Auto Audi Q8", auto.ToString());
        }
    }
}
