namespace CourseApp.Tests
{
  using System;
  using CourseApp;
  using Xunit;

  public class HumanTest
  {
    [Fact]
    public void TestConstructorOneParameter()
    {
      // Arrange
      int age = 60;

      // Act
      Human male = new Male(age);
      Human female = new Female(age);

      // Assert
      Assert.Equal(male.Age, age);
      Assert.Equal(female.Age, age);
    }

    [Fact]
    public void TestConstructorTwoParameter()
    {
      // Arrange
      int age = 30;
      int height = 170;
      int weight = 70;

      // Act
      Human male = new Male(age, height, weight);
      Human female = new Female(age, height, weight);
      bool condition = false;

      if (male.Age == age && female.Age == age && male.Height == height && female.Height == height && male.Weight == weight && female.Weight == weight)
      {
        condition = true;
      }

      // Assert
      Assert.True(condition);
    }

    [Fact]
    public void TestMiddleAge_Set133()
    {
      Human human = new Male(133);
      string result = human.Midlle_Age();
      Assert.True(result == "Input error in age;");
    }

    [Fact]
    public void TestMiddleHeight_Set333()
    {
      Human human = new Male(20, 333, 80);
      string result = human.Average_Height();
      Assert.True(result == "Input error in height;");
    }

    [Fact]
    public void TestAverageWeight_Set444()
    {
      Human human = new Male(20, 199, 444);
      string result = human.Average_Weight();
      Assert.True(result == "Input error in weight;");
    }

    [Fact]
    public void TestPropeprtyAge_Set999()
    {
      Human human = new Male(999);
      int result = human.Age;
      Assert.True(result == 0);
    }

    [Fact]
    public void TestPropeprtyHeight_Set888()
    {
      Human human = new Male(888);
      int result = human.Height;
      Assert.True(result == 0);
    }

    [Fact]
    public void TestPropeprtyWeight_Set777()
    {
      Human human = new Male(777);
      float result = human.Weight;
      Assert.True(result == 0);
    }

    [Fact]
    public void TesttoStringMale()
    {
      Human human = new Male(22, 155, 50);
      string result = $"You are a male of {22} years. Your weight is {50} kg and height {155} cm.";
      Assert.Equal(human.ToString(), result);
    }

    [Fact]
    public void TesttoStringFemale()
    {
      Human human = new Female(22, 155, 50);
      string result = $"You are a female of {22} years. Your weight is {50} kg and height {155} cm.";
      Assert.Equal(human.ToString(), result);
    }
  }
}