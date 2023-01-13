namespace CourseApp.Tests
{
    using CourseApp.Class;
    using Xunit;

    public class DishTests
    {
        [Fact]
        public void SushiConstructorTest()
        {
            Dish sushi = new Sushi("California", 176, 28, 350, "Standard", 8);
            Assert.Equal(
                @"Sushi: California
Callories: 176
Weight: 28
Price: 350
Type: Standard", sushi.GetInfo());
        }

        [Fact]
        public void SaladConstructorTest()
        {
            Dish salad = new Salad("Caesar", 44, 300, new string[] { "chicken", "cherry", "tomatoes", "parmesan", "olive oil", "garlic", "black pepper" }, 400);
            Assert.Equal(
                @"Salad: Caesar
Callories: 44
Weight: 300
Price: 400", salad.GetInfo());
        }

        [Fact]
        public void EmptyConstructorTest()
        {
            Dish dish = new Salad();
            Assert.Equal(
                @"Salad: No_Name_Null
Callories: 0
Weight: 0
Price: 0", dish.GetInfo());
        }

        [Fact]
        public void ToStringTest()
        {
            Dish dish = new Sushi("California", 176, 28, 350, "standard", 8);
            Assert.Equal("Sushi California - standard", dish.ToString());
        }

        [Fact]
        public void AbstractMethodTest()
        {
            Dish sushi = new Sushi("California", 176, 28, 350, "standard", 8);
            Assert.Equal("We eat one sushi", sushi.Eat());
        }

        [Fact]
        public void TestInterfacesDelivery()
        {
            Salad dish = new Salad("Caesar", 44, 300, new string[] { "chicken", "cherry", "tomatoes", "parmesan", "olive oil", "garlic", "black pepper" }, 400);
            int newPrice = (int)(dish.Price * 1.3);
            dish.Delivery();
            Assert.Equal(
                $@"Salad: Caesar
Callories: 44
Weight: 300
Price: {newPrice}", dish.GetInfo());
        }

        [Fact]
        public void TestInterfaceCooking()
        {
            Salad dish = new Salad();
            Assert.Equal("Salad prepared and dressed", dish.CookingDish(new string[] { "ingredients" }));
        }
    }
}
