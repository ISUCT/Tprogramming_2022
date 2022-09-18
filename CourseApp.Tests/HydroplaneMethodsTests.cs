namespace CourseApp.Tests
{
    using CourseApp.Class;
    using Xunit;

    public class HydroplaneMethodsTests
    {
        [Fact]
        public void SpeedUp_SetSampleDate_ReturnsCorrectSpeed()
        {
            Hydroplane hydroplane = new Hydroplane(80, 90, "DHC-2 Beaver", 255);
            hydroplane.SpeedUp();

            Assert.Equal(80, hydroplane.GetSpeed);
        }

        [Fact]
        public void SpeedDown_SetSampleDate_ReturnCorrectSpeed()
        {
            var hydroplane = new Hydroplane(80, 90, "DHC-2 Beaver", 255);
            hydroplane.SpeedUp();
            hydroplane.SpeedDown();

            Assert.Equal(80, hydroplane.GetSpeed);
        }

        [Fact]
        public void Braking_SetSampleDate_ReturnsCorrectSpeed()
        {
            var hydroplane = new Hydroplane(80, 90, "DHC-2 Beaver", 255);
            hydroplane.SpeedUp();
            hydroplane.Braking();

            Assert.Equal(0, hydroplane.GetSpeed);
        }

        [Fact]
        public void GetInfo_SetSampleData_ReturnCorrectInfo()
        {
            var hydroplane = new Hydroplane(80, 90, "DHC-2 Beaver", 255);
            Assert.Equal(
                @"Model: DHC-2 Beaver
Landing speed: 80km/h 
Takeoff speed: 90km/h 
Max speed: 255km/h", hydroplane.GetInfo());
        }

        [Fact]
        public void CheckConstructor_SetSampleData_ReturnCorrectInfo()
        {
            Plane hydroplane = new Hydroplane(90, 110, "SameHydroplane", 300);

            Assert.Equal(
                @"Model: SameHydroplane
Landing speed: 90km/h 
Takeoff speed: 110km/h 
Max speed: 300km/h", hydroplane.GetInfo());
        }
    }
}
