namespace CourseApp.Tests
{
    using CourseApp.RPGSaga;
    using Xunit;

    public class PlaneMethodsTests
    {
        [Fact]
        public void GetInfo_SetSampleData_ReturnCorrectInfo()
        {
            Transport plane = new Plane(9.22, 2.74, 1361, 450, 255, "DHC-2 Beaver");
            Assert.Equal(
                @"Info for DHC-2 Beaver
Weight: 1361 kg
Length: 9,22 m 
Height: 2,74 m
Power: 450 horsepower
Max Speed: 255 km\h", plane.GetInfo());
        }

        [Fact]
        public void CheckConstructor_SetSampleData_ReturnCorrectInfo()
        {
            Transport plane = new Plane();

            Assert.Equal(
                @"Info for Plane
Weight: 0 kg
Length: 0 m 
Height: 0 m
Power: 0 horsepower
Max Speed: 0 km\h", plane.GetInfo());
        }

        [Fact]
        public void Movement_CallMovementMethod_CorrectMoveInfo()
        {
            var plane = new Plane();
            Assert.Equal(ActionTypes.Move, plane.Movement());
        }

        [Fact]
        public void Landing_CallLandingMethod_CorrectLandingInfo()
        {
            var plane = new Plane();
            Assert.Equal(ActionTypes.LAnding, plane.Landing());
        }

        [Fact]
        public void Takeoff_CallLandingMethod_CorrectTakeoffInfo()
        {
            var plane = new Plane();
            Assert.Equal(ActionTypes.TAkeoff, plane.Takeoff());
        }

        [Fact]
        public void ToString_CheckStringPresentation_CorrectPresentationOfInstance()
        {
            Transport plane = new Plane(9.22, 2.74, 1361, 450, 255, "DHC-2 Beaver");
            Assert.Equal("Plane DHC-2 Beaver", plane.ToString());
        }
    }
}
