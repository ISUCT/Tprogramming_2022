namespace CourseApp.Tests
{
    using CourseApp.Class;
    using Xunit;

    public class HydroplaneMethodsTests
    {
        [Fact]
        public void SpeedUp_SetSampleDate_ReturnsCorrectSpeed()
        {
            Hydroplane hydroplane = new Hydroplane(450, 9, 1361, 80, 90, 8, 2, "DHC-2 Beaver", 255);
            var result = hydroplane.SpeedUp();

            Assert.Equal(hydroplane.GetSpeed(), result);
        }

        [Fact]
        public void SpeedUpDouble_SetSampleDate_ReturnCorrectSpeed()
        {
            var hydroplane = new Hydroplane(450, 9, 1361, 80, 90, 8, 2, "DHC-2 Beaver", 255);
            hydroplane.SpeedUp();
            var result = hydroplane.SpeedUp();

            Assert.Equal(hydroplane.GetSpeed(), result);
        }

        [Fact]
        public void SpeedDown_SetSampleDate_ReturnCorrectSpeed()
        {
            var hydroplane = new Hydroplane(450, 9, 1361, 80, 90, 8, 2, "DHC-2 Beaver", 255);
            hydroplane.SpeedUp();
            hydroplane.SpeedDown();

            Assert.Equal(80, hydroplane.GetSpeed());
        }

        [Fact]
        public void Braking_SetSampleDate_ReturnsCorrectSpeed()
        {
            var hydroplane = new Hydroplane(450, 9, 1361, 80, 90, 8, 2, "DHC-2 Beaver", 255);
            hydroplane.SpeedUp();
            hydroplane.Braking();

            Assert.Equal(0, hydroplane.GetSpeed());
        }
    }
}
