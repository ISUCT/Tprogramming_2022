namespace CourseApp.Tests
{
    using CourseApp.Class;
    using Xunit;

    public class PlaneMethodsTests
    {
        [Fact]
        public void GetInfo_SetSampleData_ReturnCorrectInfo()
        {
            var plane = new Plane("DHC-2 Beaver", 255, 450, 9.22, 2.74, 1361);
            Assert.Equal(
                @"Info for Plane DHC-2 Beaver
Weight: 1361kg
Length: 9.22m 
Height: 2.74m
Power: 450 horsepower
Max Speed: 255km\h", plane.GetInfo());
        }

        [Fact]
        public void CheckConstructor_SetSampleData_ReturnCorrectInfo()
        {
            var plane = new Plane();

            Assert.Equal(
                @"Info for Plane No_name
Weight: 0kg
Length: 0m 
Height: 0m
Power: 0 horsepower
Max Speed: 0km\h", plane.GetInfo());
        }

        [Fact]
        public void Movement_CallMovementMethod_CorrectMoveInfo()
        {
            var plane = new Plane();
            plane.Direction = "Ivanovo";
            Assert.Equal("No_name is moving at a speed 0km/h in the Ivanovo", plane.Movement());
        }

        [Fact]
        public void Landing_CallLandingMethod_CorrectLandingInfo()
        {
            var plane = new Plane();
            Assert.Equal("No_name going to land", plane.Landing());
        }

        [Fact]
        public void Takeoff_CallLandingMethod_CorrectTakeoffInfo()
        {
            var plane = new Plane();
            Assert.Equal("No_name taking off", plane.Takeoff());
        }

        [Fact]
        public void CustomException_WrongData_CorrectExceptionMessage()
        {
            var plane = new Plane();
            plane.Speed = 300;
            Assert.Equal("Error: speed is too large or too little for No_name", plane.Exc);
        }
    }
}
