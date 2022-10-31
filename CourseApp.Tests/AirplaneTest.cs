namespace CourseApp.Tests
{
    using Xunit;

    public class AirplaneTest
    {
        [Fact]
        public void TestConstructor()
        {
            // Arrange
            int speed = 201;
            int flight = 5;
            string model = "Boeing";

            Airplane expected = new Passenger(201, 5, "Boeing");

            // Act
            Airplane airplane = new Fighter(speed, flight, model);

            // Assert
            Assert.Equal(expected.Speed, airplane.Speed);
            Assert.Equal(expected.Model, airplane.Model);
            Assert.Equal(expected.Flight, airplane.Flight);
        }

        [Theory]
        [InlineData(270, 800, "A320")]
        [InlineData(260, 800, "A320")]
        [InlineData(210, 800, "A320")]
        public void TakeOffTest(int speed, int flight, string model)
        {
            Airplane plane = new Passenger(speed, flight, model);

            string condition;

            if (speed >= 260)
            {
                condition = "Cамолет взлетел";
            }
            else
            {
                condition = "Слишком маленькая скорость для взлета";
            }

            Assert.Equal(plane.GetTakeOff(), condition);
        }

        [Theory]
        [InlineData(810, 800, "A320")]
        [InlineData(840, 800, "A320")]
        [InlineData(700, 800, "A320")]
        public void FlyTest(int speed, int flight, string model)
        {
            Airplane plane = new Passenger(speed, flight, model);

            string condition;

            if (speed < 850 && speed > 800)
            {
                condition = "Самолет летит";
            }
            else
            {
                condition = "Наберите нужную скорость";
            }

            Assert.Equal(plane.GetFly(), condition);
        }

        [Theory]
        [InlineData(210, 800, "A320")]
        [InlineData(240, 800, "A320")]
        [InlineData(201, 800, "A320")]
        public void LandingTest(int speed, int flight, string model)
        {
            Airplane plane = new Passenger(speed, flight, model);

            string condition;

            if (speed > 200 && speed < 250)
            {
                condition = "Самолет приземлился";
            }
            else
            {
                condition = "Повысьте или понизьте скорость";
            }

            Assert.Equal(plane.GetLanding(), condition);
        }

        [Theory]
        [InlineData(210, 800, "A320")]
        [InlineData(260, 800, "A320")]
        public void ToStringTest(int speed, int flight, string model)
        {
            Airplane passenger = new Passenger(speed, flight, model);
            Airplane fighter = new Fighter(speed, flight, model);

            var conditionPassenger = $"Passenger ( speed: {speed}, flight: {flight}, model: {model})";
            var conditionFighter = $"Fighter ( speed: {speed}, flight: {flight}, model: {model})";

            Assert.Equal(passenger.ToString(), conditionPassenger);
            Assert.Equal(fighter.ToString(), conditionFighter);
        }

        [Fact]
        public void RoleTest()
        {
            Airplane passenger = new Passenger(210, 800, "A320");
            Airplane fighter = new Fighter(210, 800, "A320");

            var conditionPassenger = "Роль пассажирского самолета - перевозка пассажиров и багажа.";
            var conditionFighter = "Роль военного самолета - уничтожение противника.";

            Assert.Equal(passenger.MyRole(), conditionPassenger);
            Assert.Equal(fighter.MyRole(), conditionFighter);
        }
    }
}
